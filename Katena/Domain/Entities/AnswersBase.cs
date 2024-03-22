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

		/*//Мотив
        [Required]
        [Display(Name ="Причина")]
        public string Reason { get; set; }

        //Тип личности
        [Required]
        [Display(Name ="Тип личности")]
        public string Type { get; set; }
*/
		//Тип личности
/*		[Required]
		[Display(Name = "Тип личности")]
		public string Type1 { get; set; }

		[Required]
		[Display(Name = "Тип личности")]
		public string Type2 { get; set; }

		[Required]
		[Display(Name = "Тип личности")]
		public string Type3 { get; set; }

		[Required]
		[Display(Name = "Тип личности")]
		public string Type4 { get; set; }

		[Required]
		[Display(Name ="Принимает решение")]
		public string character1 {  get; set; }

		[Required]
		[Display(Name = "Фокус внимания")]
		public string character2 { get; set; }

		[Required]
		[Display(Name = "Процесс принятия решений")]
		public string character3 { get; set; }

		[Required]
		[Display(Name = "Ориентирован на")]
		public string character4 { get; set; }*/

		//Вес
		[Required]
        [Display(Name ="Вес")]
        public double? Weight { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight1 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight2 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight3 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight4 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight5 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight6 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight7 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight8 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight9 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight10 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight11 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight12 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight13 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight14 { get; set; }

		//Вес
		[Required]
		[Display(Name = "Вес")]
		public double? Weight15 { get; set; }

		public List<Guid> reasonsId { get; set; }
	}
}
