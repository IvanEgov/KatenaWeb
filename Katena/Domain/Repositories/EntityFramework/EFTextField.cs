using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
	public class EFTextField : ITextField
	{
		private readonly AppDbContext context;
		public EFTextField(AppDbContext context)
		{
			this.context = context;
		}

		public IQueryable<TextField> GetTextFields()
		{
			return context.TextFields;
		}

		public TextField GetTextFieldById(Guid id)
		{
			return context.TextFields.FirstOrDefault(x => x.Id == id);
		}

		public TextField GetTextFieldByCodeWord(string codeWord)
		{
			return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
		}

		public void SaveTextField(TextField entity)
		{
			if (entity.Id == default)
				context.Entry(entity).State = EntityState.Added;
			else
				context.Entry(entity).State = EntityState.Modified;
			context.SaveChanges();
		}

		public void DeleteTextField(Guid id)
		{
			context.TextFields.Remove(new TextField() { Id = id });
			context.SaveChanges();
		}
	}
}
