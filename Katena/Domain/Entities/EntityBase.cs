using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
	public class EntityBase
	{
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
		public Guid Id { get; set; }

		[Display(Name = "Название (заголовок)")]
		public virtual string Title { get; set; }

		[Display(Name = "Полное описание")]
		public virtual string Text { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
