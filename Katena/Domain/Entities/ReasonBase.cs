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
		[Display(Name = "Первый вес")]
		public double? Weight { get; set; }

		[Required]
		[Display(Name = "Второй вес")]
		public double? Weight1 { get; set; }

		[Required]
		[Display(Name = "Третий вес")]
		public double? Weight2 { get; set; }

		[Required]
		[Display(Name = "Четвертый вес")]
		public double? Weight3 { get; set; }

		[Required]
		[Display(Name = "Пятый вес")]
		public double? Weight4 { get; set; }

		[Required]
		[Display(Name = "Шестой вес")]
		public double? Weight5 { get; set; }

		[Required]
		[Display(Name = "Седьмой вес")]
		public double? Weight6 { get; set; }

		[Required]
		[Display(Name = "Восьмой вес")]
		public double? Weight7 { get; set; }

		[Required]
		[Display(Name = "Девятый вес")]
		public double? Weight8 { get; set; }

		[Required]
		[Display(Name = "Десятый вес")]
		public double? Weight9 { get; set; }

		[Required]
		[Display(Name = "Одиннадцатый вес")]
		public double? Weight10 { get; set; }

		[Required]
		[Display(Name = "Двенадцатый вес")]
		public double? Weight11 { get; set; }

        [Required]
        [Display(Name = "Тринадцатый вес")]
        public double? Weight12 { get; set; }

        [Required]
        [Display(Name = "Четырнадцатый вес")]
        public double? Weight13 { get; set; }

        [Required]
        [Display(Name = "Пятнадцатый вес")]
        public double? Weight14 { get; set; }
    }
}
