using Org.BouncyCastle.Bcpg;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katena.Domain.Entities
{
	//Класс, хранящий пак вопросов для теста с id, названием, описанием и т.д., а также результаты теста.
	public class QuestionPackBase
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		[Display(Name = "Название теста")]
		public string? Name { get; set; }

		[Display(Name = "Описание теста")]
		public string? Description { get; set; }

		[Display(Name = "Инструкции выполнения")]
		public string? Instructions { get; set; }

		[Display(Name = "Картинка теста")]
		public virtual string? TitleImagePath { get; set; }

		public List<Guid>? QuestionsIds { get; set; }

		public List<Guid>? ResaultsId { get; set; }

		[Display(Name = "Имена файлов картинок теста в порядке следования вопросов через запятую без пробелов")]
		public virtual string? Background { get; set; }

    }
}
