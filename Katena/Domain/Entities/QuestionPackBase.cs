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
		public string PackName { get; set; }

		[Display(Name = "Описание теста")]
		public string Description { get; set; }

		[Display(Name = "Инструкции выполнения")]
		public string Instructions { get; set; }

		public List<Guid> QuestionsIds { get; set; }

		//Хранит результаты: пол, стиль, типаж, описание
		[NotMapped]
		public Dictionary<string, Dictionary<string, Dictionary<string, string>>> Resaults { get; set; }
	}
}
