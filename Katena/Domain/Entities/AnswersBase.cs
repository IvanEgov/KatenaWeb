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
        public string Action { get; set; }

        //Мотив
        [Required]
        public string Reason { get; set; }

        //Тип личности
        [Required]
        public string Type { get; set; }

        //Вес
        [Required]
        public double Weight { get; set; }
    }
}
