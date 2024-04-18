using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
    public class NewsBase
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; } = "Новость дня";

        [Display(Name = "Содержание")]
        public string Text { get; set; } = "Содержание заполняется администратором";
        
        [Display(Name = "Титульная картинка")]
        public virtual string? TitleImagePath { get; set; }
    }
}
