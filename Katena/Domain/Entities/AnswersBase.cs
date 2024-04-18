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
        public int? Weight { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Производитель)")]
		public int? Weight1 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Производитель)")]
		public int? Weight2 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Производитель)")]
		public int? Weight3 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Принять решение(Администратор)")]
		public int? Weight4 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Администратор)")]
		public int? Weight5 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Администратор)")]
		public int? Weight6 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Администратор)")]
		public int? Weight7 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Принять решение(Предприниматель)")]
		public int? Weight8 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Предприниматель)")]
		public int? Weight9 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Предприниматель)")]
		public int? Weight10 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Предприниматель)")]
		public int? Weight11 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Принять решение(Интегратор)")]
		public int? Weight12 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Фокус внимания(Интегратор)")]
		public int? Weight13 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Процесс принятия решений(Интегратор)")]
		public int? Weight14 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Ориентирован на(Интегратор)")]
		public int? Weight15 { get; set; }

		//Вес сложности варианта ответа
		[Required]
		[Display(Name= "Вес производитель")]
		public int? typeWeight1 { get; set; }

		//Вес сложности варианта ответа
		[Required]
		[Display(Name = "Вес администартор")]
		public int? typeWeight2 { get; set; }
		
		//Вес сложности варианта ответа
		[Required]
		[Display(Name = "Вес предприниматель")]
		public int? typeWeight3 { get; set; }

		//Вес сложности варианта ответа
		[Required]
		[Display(Name = "Вес интегратор")]
		public int? typeWeight4 { get; set; }

		public List<Guid> reasonsId { get; set; }
	}
}
