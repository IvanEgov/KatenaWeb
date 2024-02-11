using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
    public class ResaultsBase
    {
        //Id Результата
        [Required]
        public Guid Id { get; set; }

        //Пол
        [Required] 
        public string Gender { get; set; }

        //Стиль
        [Required]
        public string Style { get; set; }
        
        //Тип личности
        [Required]
        public string Type { get; set; }

        //Результат(описание)
        [Required]
        public string Resault { get; set; }
    }
}
