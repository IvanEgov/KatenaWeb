using System.Threading.Tasks;
using Katena.Models;
using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly AppDbContext _context; // <-- ДОБАВИЛИ ЭТУ СТРОКУ

        public AccountController(
            UserManager<ApplicationUser> userMgr,
            SignInManager<ApplicationUser> signinMgr,
            AppDbContext context) // <-- ДОБАВИЛИ ЭТОТ ПАРАМЕТР
        {
            userManager = userMgr;
            signInManager = signinMgr;
            _context = context; // <-- ДОБАВИЛИ ЭТУ СТРОКУ
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            // ПОЛНАЯ ОТЛАДКА
            System.Diagnostics.Debug.WriteLine("=== LOGIN ATTEMPT ===");
            System.Diagnostics.Debug.WriteLine($"UserName: '{model.UserName}'");
            System.Diagnostics.Debug.WriteLine($"Password: '{model.Password}'");
            System.Diagnostics.Debug.WriteLine($"RememberMe: {model.RememberMe}");
            System.Diagnostics.Debug.WriteLine($"ModelState.IsValid: {ModelState.IsValid}");

            // Показываем ВСЕ записи в ModelState
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                System.Diagnostics.Debug.WriteLine($"Key: {key}, Value: '{state.AttemptedValue}', IsValid: {state.ValidationState}");

                foreach (var error in state.Errors)
                {
                    System.Diagnostics.Debug.WriteLine($"  ERROR: '{error.ErrorMessage}' | Exception: {error.Exception?.Message}");
                }
            }

            if (ModelState.IsValid)
            {
                ApplicationUser user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(
                        user, model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {
                        System.Diagnostics.Debug.WriteLine("=== LOGIN SUCCESS ===");
                        return Redirect(returnUrl ?? "/Cabinet");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"=== LOGIN FAILED: {result} ===");
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("=== USER NOT FOUND ===");
                }
                ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("=== MODEL STATE INVALID ===");
            }

            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    EmailConfirmed = true
                };

                // Если указано название компании - создаем новую фирму и делаем пользователя Директором
                if (!string.IsNullOrEmpty(model.CompanyName))
                {
                    var firm = new Firm
                    {
                        Name = model.CompanyName
                    };

                    // Сохраняем фирму в базу
                    _context.Firms.Add(firm);
                    await _context.SaveChangesAsync();

                    user.FirmId = firm.Id;
                    user.UserRole = "Director";
                }

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Cabinet");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}