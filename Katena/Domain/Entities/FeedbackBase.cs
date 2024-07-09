using System.ComponentModel.DataAnnotations;
namespace Katena.Domain.Entities
{
	public class FeedbackBase
	{
		//Id дла пойска в базе
		[Required]
		public Guid id { get; set; }
		//Почта
		[Required]
		public string mail { get; set; }
		//Имя пользователя
		[Required]
		public string name { get; set; }
		[Required]
		public string message { get; set; }
	}
}
