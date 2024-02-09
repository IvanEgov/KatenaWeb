using System.ComponentModel.DataAnnotations;

namespace Katena.Models
{
	public class LoginViewModel
	{
		[Required]
		[Display(Name = "Логин")]
		public string UserName {  get; set; }

		[Required]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[Required]
		[Display(Name = "Запомнить меня?")]
		public bool RememberMe { get; set; }
	}
}
