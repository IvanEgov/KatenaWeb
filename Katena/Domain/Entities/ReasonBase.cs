using System.ComponentModel.DataAnnotations;
namespace Katena.Domain.Entities
{
	public class ReasonBase
	{
		[Required]
		public Guid Id { get; set; }

		[Required]
		[Display(Name="Причина")]
		public string  Reason { get; set; }

		//Веса
		[Required]
		[Display(Name = "Поиск виноватого(З)")]
		public int? Weight { get; set; }

		[Required]
		[Display(Name = "Поиск ценностей(З)")]
		public int? Weight1 { get; set; }

		[Required]
		[Display(Name = "Вектор внимания(З)")]
		public int? Weight2 { get; set; }

		[Required]
		[Display(Name = "Проявление заботы(З)")]
		public int? Weight3 { get; set; }

		[Required]
		[Display(Name = "Ориентация во времени(З)")]
		public int? Weight4 { get; set; }

		[Required]
		[Display(Name = "Поиск виноватого(П)")]
		public int? Weight5 { get; set; }

		[Required]
		[Display(Name = "Поиск ценностей(П)")]
		public int? Weight6 { get; set; }

		[Required]
		[Display(Name = "Вектор внимания(П)")]
		public int? Weight7 { get; set; }

		[Required]
		[Display(Name = "Проявление заботы(П)")]
		public int? Weight8 { get; set; }

		[Required]
		[Display(Name = "Ориентация во времени(П)")]
		public int? Weight9 { get; set; }

		[Required]
		[Display(Name = "Поиск виноватого(Х)")]
		public int? Weight10 { get; set; }

		[Required]
		[Display(Name = "Поиск ценностей(Х)")]
		public int? Weight11 { get; set; }

        [Required]
        [Display(Name = "Вектор внимания(Х)")]
        public int? Weight12 { get; set; }

        [Required]
        [Display(Name = "Проявление заботы(Х)")]
        public int? Weight13 { get; set; }

        [Required]
        [Display(Name = "Ориентация во времени(Х)")]
        public int? Weight14 { get; set; }

		//Веса сложности варианта мотивации
		[Required]
		[Display(Name = "Вес наставкник")]
		public int? typeWeight1 { get; set; }

		[Required]
		[Display(Name = "Вес ищущий")]
		public int? typeWeight2 { get; set; }

		[Required]
		[Display(Name = "Вес охотник")]
		public int? typeWeight3 { get; set; }
	}
}
