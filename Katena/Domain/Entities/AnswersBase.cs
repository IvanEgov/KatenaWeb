using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
    public class AnswersBase
    {
        //Id Ответа
        [Required]
        public Guid Id { get; set; }

        //Действие
        [Required]
        [Display(Name ="Действие")]
        public string Action { get; set; }

		//Вес
		[Required]
        [Display(Name ="Принять решение(Производитель)")]
        public double? Weight { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Производитель)")]
		public double? Weight1 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Производитель)")]
		public double? Weight2 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Производитель)")]
		public double? Weight3 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Принять решение(Администратор)")]
		public double? Weight4 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Администратор)")]
		public double? Weight5 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Администратор)")]
		public double? Weight6 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Администратор)")]
		public double? Weight7 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Принять решение(Предприниматель)")]
		public double? Weight8 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Предприниматель)")]
		public double? Weight9 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Предприниматель)")]
		public double? Weight10 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Предприниматель)")]
		public double? Weight11 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Принять решение(Интегратор)")]
		public double? Weight12 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Интегратор)")]
		public double? Weight13 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Интегратор)")]
		public double? Weight14 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Интегратор)")]
		public double? Weight15 { get; set; }

		//Вес сложности варианта ответа
		[Required]
		[Display(Name="Вес сложности")]
		public double? hardWeight { get; set; }

		public List<Guid> reasonsId { get; set; }
	}
}
