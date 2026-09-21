using System.ComponentModel.DataAnnotations;

namespace Katena.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введите email")]
        [Display(Name = "Логин")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}