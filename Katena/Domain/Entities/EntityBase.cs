using System.ComponentModel.DataAnnotations;

namespace Katena.Domain.Entities
{
	public class EntityBase
	{
		[Required]
		public Guid Id { get; set; }

		[Display(Name = "Название (заголовок)")]
		public virtual string Title { get; set; }

		[Display(Name = "Полное описание")]
		public virtual string Text { get; set; }

	}
}
