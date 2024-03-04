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

        //Мотив
        [Required]
        [Display(Name ="Причина")]
        public string Reason { get; set; }

        //Тип личности
        [Required]
        [Display(Name ="Тип личности")]
        public string Type { get; set; }

        //Вес
        [Required]
        [Display(Name ="Вес")]
        public double Weight { get; set; }
    }
}
