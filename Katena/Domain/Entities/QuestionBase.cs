using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
    //Представление вопроссов, а также структура ответа: вес и тип, т.е. к какому типу относится этот ответ.
    public struct Answer
    {
        public enum Type
        {
            none,
            hunter,
            mentor,
            searching,
            manufacturer,
            manager,
            entrepreneur,
            integrator
        }

        public double weight { get; set; } = 0;
        public Type type { get; set; }
        public Answer(double Weight = 0, Type t = 0)
        {
            weight = Weight;
            type = t;
        }
    }
    public class QuestionBase
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		[Display(Name = "Введите вопрос")]
		public string Quest { get; set; }

		//Хранит действие, мотив и ответ
		public Dictionary<string, Dictionary<string, Answer>> Answers { get; set; }
	}
}