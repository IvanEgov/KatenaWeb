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
		public double? Weight { get; set; }

		[Required]
		[Display(Name = "Поиск ценностей(З)")]
		public double? Weight1 { get; set; }

		[Required]
		[Display(Name = "Вектор внимания(З)")]
		public double? Weight2 { get; set; }

		[Required]
		[Display(Name = "Проявление заботы(З)")]
		public double? Weight3 { get; set; }

		[Required]
		[Display(Name = "Ориентация во времени(З)")]
		public double? Weight4 { get; set; }

		[Required]
		[Display(Name = "Поиск виноватого(П)")]
		public double? Weight5 { get; set; }

		[Required]
		[Display(Name = "Поиск ценностей(П)")]
		public double? Weight6 { get; set; }

		[Required]
		[Display(Name = "Вектор внимания(П)")]
		public double? Weight7 { get; set; }

		[Required]
		[Display(Name = "Проявление заботы(П)")]
		public double? Weight8 { get; set; }

		[Required]
		[Display(Name = "Ориентация во времени(П)")]
		public double? Weight9 { get; set; }

		[Required]
		[Display(Name = "Поиск виноватого(Х)")]
		public double? Weight10 { get; set; }

		[Required]
		[Display(Name = "Поиск ценностей(Х)")]
		public double? Weight11 { get; set; }

        [Required]
        [Display(Name = "Вектор внимания(Х)")]
        public double? Weight12 { get; set; }

        [Required]
        [Display(Name = "Проявление заботы(Х)")]
        public double? Weight13 { get; set; }

        [Required]
        [Display(Name = "Ориентация во времени(Х)")]
        public double? Weight14 { get; set; }

		//Вес сложности варианта мотивации
		[Required]
		[Display(Name = "Вес сложности")]
		public double? hardWeight { get; set; }
	}
}
