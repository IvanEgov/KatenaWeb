using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Katena.Controllers
{
    [Authorize]
    public class CabinetController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;

        public CabinetController(UserManager<ApplicationUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null || currentUser.FirmId == null)
            {
                return RedirectToAction("Register", "Account");
            }

            if (currentUser.UserRole == "Director")
            {
                var employees = await _context.Users
                    .Where(u => u.FirmId == currentUser.FirmId && u.UserRole == "Employee")
                    .ToListAsync();

                var testResults = await _context.TestResults
                    .Where(tr => tr.FirmId == currentUser.FirmId)
                    .Include(tr => tr.User)
                    .OrderByDescending(tr => tr.TestDate)
                    .ToListAsync();

                ViewBag.Employees = employees;
                ViewBag.TestResults = testResults;
                ViewBag.IsDirector = true;
            }
            else
            {
                var myResults = await _context.TestResults
                    .Where(tr => tr.UserId == currentUser.Id)
                    .OrderByDescending(tr => tr.TestDate)
                    .ToListAsync();

                ViewBag.MyResults = myResults;
                ViewBag.IsDirector = false;
            }

            return View();
        }

       /* public async Task<IActionResult> AddEmployee()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser?.UserRole != "Director")
            {
                return RedirectToAction("Index");
            }

            return View();
        }*/

        [HttpPost]
        public async Task<IActionResult> AddEmployee(string email, string fullName)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser?.UserRole != "Director" || currentUser.FirmId == null)
            {
                return RedirectToAction("Index");
            }

            var tempPassword = GenerateTempPassword();

            var newUser = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FirmId = currentUser.FirmId,
                UserRole = "Employee",
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(newUser, tempPassword);

            if (result.Succeeded)
            {
                ViewBag.SuccessMessage = $"Сотрудник добавлен! Временный пароль: {tempPassword}";
                return View();
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }

        public async Task<IActionResult> EmployeeCard(string userId)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser?.FirmId == null)
            {
                return RedirectToAction("Index");
            }

            var employee = await _context.Users.FindAsync(userId);

            if (employee == null || employee.FirmId != currentUser.FirmId)
            {
                return NotFound();
            }

            var testResults = await _context.TestResults
                .Where(tr => tr.UserId == userId)
                .OrderByDescending(tr => tr.TestDate)
                .ToListAsync();

            ViewBag.Employee = employee;
            ViewBag.TestResults = testResults;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetEmployeePassword(string userId)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            // Проверка: только директор своей фирмы может это делать
            if (currentUser?.UserRole != "Director" || currentUser.FirmId == null)
            {
                return RedirectToAction("Index");
            }

            var employee = await _userManager.FindByIdAsync(userId);

            if (employee == null || employee.FirmId != currentUser.FirmId)
            {
                return NotFound();
            }

            // Генерируем токен для сброса и новый временный пароль
            var token = await _userManager.GeneratePasswordResetTokenAsync(employee);
            var newPassword = GenerateTempPassword();

            // Сбрасываем пароль
            var result = await _userManager.ResetPasswordAsync(employee, token, newPassword);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = $"✅ Пароль для {employee.Email} успешно сброшен!<br><strong>Новый пароль:</strong> {newPassword}";
            }
            else
            {
                TempData["ErrorMessage"] = "❌ Ошибка при сбросе пароля.";
            }

            return RedirectToAction("EmployeeCard", new { userId = userId });
        }

        private string GenerateTempPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}