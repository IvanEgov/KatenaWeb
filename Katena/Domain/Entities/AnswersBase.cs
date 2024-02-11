using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
    public class AnswersBase
    {
        //Id Ответа
        [Required]
        Guid Id { get; set; }

        //Действие
        [Required]
        string Action { get; set; }

        //Мотив
        [Required]
        string Reason { get; set; }

        //Тип личности
        [Required]
        string Type { get; set; }

        //Вес
        [Required]
        double Weight { get; set; }
    }
}
