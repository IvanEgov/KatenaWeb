using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katena.Domain.Entities
{
    public class QuestionBase
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Вопрос")]
        public string? Name { get; set; }

        public List <Guid>? AnswerId { get; set; }
    }
}