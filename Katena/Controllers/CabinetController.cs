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

        public async Task<IActionResult> Index(string? selectedUserId, string? mode)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null || currentUser.FirmId == null)
            {
                return RedirectToAction("Register", "Account");
            }

            // ==========================================
            // ЛОГИКА ДЛЯ ДИРЕКТОРА
            // ==========================================
            if (currentUser.UserRole == "Director")
            {
                // Получаем всех сотрудников фирмы
                var employees = await _context.Users
                    .Where(u => u.FirmId == currentUser.FirmId && u.UserRole == "Employee")
                    .ToListAsync();

                ViewBag.Employees = employees;
                ViewBag.IsDirector = true;
                ViewBag.SelectedUserId = selectedUserId;
                ViewBag.Mode = mode;

                // Если выбран конкретный сотрудник, загружаем его данные и результаты
                if (!string.IsNullOrEmpty(selectedUserId) && mode != "createTask")
                {
                    var employee = await _context.Users.FindAsync(selectedUserId);
                    if (employee != null && employee.FirmId == currentUser.FirmId)
                    {
                        ViewBag.SelectedEmployee = employee;
                        ViewBag.EmployeeTestResults = await _context.TestResults
                            .Where(tr => tr.UserId == selectedUserId)
                            .OrderByDescending(tr => tr.TestDate)
                            .ToListAsync();
                    }
                }

                // Загружаем статистику для правой колонки
                ViewBag.TotalTasks = await _context.FirmTasks.CountAsync(t => t.FirmId == currentUser.FirmId);
                ViewBag.ActiveTasks = await _context.FirmTasks.CountAsync(t => t.FirmId == currentUser.FirmId && t.Status != "Выполнена");

                // ДОБАВИТЬ ЭТУ СТРОКУ: Список последних 5 активных задач для правой панели
                ViewBag.ActiveTasksList = await _context.FirmTasks
                    .Where(t => t.FirmId == currentUser.FirmId && t.Status != "Выполнена")
                    .OrderByDescending(t => t.Deadline)
                    .Take(5)
                    .ToListAsync();
            }
            // ==========================================
            // ЛОГИКА ДЛЯ СОТРУДНИКА (ТОТ САМЫЙ ELSE)
            // ==========================================
            else
            {
                ViewBag.IsDirector = false;

                // 1. Загружаем его результаты тестов
                ViewBag.MyResults = await _context.TestResults
                    .Where(tr => tr.UserId == currentUser.Id)
                    .OrderByDescending(tr => tr.TestDate)
                    .ToListAsync();

                // 2. Загружаем назначенные ему задачи (вместе с данными самой задачи)
                ViewBag.MyTasks = await _context.TaskAssignees
                    .Where(ta => ta.UserId == currentUser.Id)
                    .Include(ta => ta.Task) // Важно: подгружаем саму задачу, чтобы знать её название и дедлайн
                    .OrderByDescending(ta => ta.Task.Deadline)
                    .ToListAsync();

                // 3. Загружаем непрочитанные уведомления
                var notifications = await _context.Notifications
                    .Where(n => n.UserId == currentUser.Id && !n.IsRead)
                    .OrderByDescending(n => n.CreatedAt)
                    .Take(5) // Показываем последние 5
                    .ToListAsync();

                ViewBag.Notifications = notifications;

                // 4. Помечаем показанные уведомления как прочитанные
                foreach (var notif in notifications)
                {
                    notif.IsRead = true;
                }
                await _context.SaveChangesAsync();
            }

            return View();
        }

       
        // 1. Показывает форму добавления сотрудника (GET)
        [HttpGet]
        public async Task<IActionResult> AddEmployee()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser?.UserRole != "Director")
            {
                return RedirectToAction("Index");
            }
            return View();
        }
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
                // ViewBag.SuccessMessage = $"Сотрудник добавлен! Временный пароль: {tempPassword}";
                //  return View();
                TempData["SuccessMessage"] = $"✅ Сотрудник добавлен!<br><strong>Временный пароль:</strong> {tempPassword}<br><small>Сохраните его и передайте сотруднику.</small>";
                return RedirectToAction("Index"); // Возвращаемся в общий кабинет с сообщением

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


        [HttpPost]
        public async Task<IActionResult> CreateTask(string title, string description, DateTime deadline, List<string> selectedEmployees)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser?.UserRole != "Director" || currentUser.FirmId == null)
            {
                return RedirectToAction("Index");
            }

            // 1. Создаем задачу
            var newTask = new FirmTask
            {
                Title = title,
                Description = description,
                Deadline = deadline,
                FirmId = currentUser.FirmId,
                CreatorId = currentUser.Id,
                Status = "Новая"
            };
            _context.FirmTasks.Add(newTask);
            await _context.SaveChangesAsync(); // Сохраняем, чтобы получить newTask.Id

            // 2. Назначаем сотрудников и отправляем уведомления
            if (selectedEmployees != null && selectedEmployees.Any())
            {
                foreach (var empId in selectedEmployees)
                {
                    // Проверяем, что сотрудник из той же фирмы
                    var employee = await _context.Users.FindAsync(empId);
                    if (employee != null && employee.FirmId == currentUser.FirmId)
                    {
                        // Добавляем в исполнители
                        _context.TaskAssignees.Add(new TaskAssignee
                        {
                            TaskId = newTask.Id,
                            UserId = empId,
                            Status = "Ожидает"
                        });

                        // Создаем уведомление
                        _context.Notifications.Add(new Notification
                        {
                            UserId = empId,
                            Message = $"Вам назначена новая задача: \"{title}\". Срок выполнения: {deadline:dd.MM.yyyy HH:mm}",
                            TaskId = newTask.Id,
                            IsRead = false
                        });
                    }
                }
                await _context.SaveChangesAsync();
            }

            TempData["SuccessMessage"] = "✅ Задача успешно создана и назначена сотрудникам!";
            return RedirectToAction("Index");
        }
        // Страница смены пароля
        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        // Обработка смены пароля
        [HttpPost]
        public async Task<IActionResult> ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Проверка совпадения новых паролей
            if (newPassword != confirmPassword)
            {
                TempData["ErrorMessage"] = "❌ Новые пароли не совпадают!";
                return View();
            }

            // Проверка текущего пароля
            var isPasswordValid = await _userManager.CheckPasswordAsync(currentUser, currentPassword);
            if (!isPasswordValid)
            {
                TempData["ErrorMessage"] = "❌ Текущий пароль введен неверно!";
                return View();
            }

            // Смена пароля
            var result = await _userManager.ChangePasswordAsync(currentUser, currentPassword, newPassword);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "✅ Пароль успешно изменен!";
                return RedirectToAction("Index");
            }
            else
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                TempData["ErrorMessage"] = $"❌ Ошибка: {errors}";
                return View();
            }
        }

    }
}