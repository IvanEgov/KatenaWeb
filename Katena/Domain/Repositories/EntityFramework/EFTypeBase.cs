using Katena.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
	public class EFTypeBase
	{
		private readonly AppDbContext context;

		public EFTypeBase(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<TypeBase> GetAllAnswers()
		{
			return context.Types;
		}

		public TypeBase GetAnswerById(Guid id)
		{
			return context.Types.FirstOrDefault(x => x.Id == id);
		}

		public void SaveAnswer(TypeBase entity)
		{
			if (entity.Id == default)
			{
				context.Entry(entity).State = EntityState.Added;
				entity.Id = Guid.NewGuid();
			}
			else
			{
				context.Entry(entity).State = EntityState.Modified;
			}

			context.SaveChanges();
		}

		public void DeleteAnswerById(Guid id)
		{
			context.Types.Remove(new TypeBase { Id = id });
			context.SaveChanges();
		}
	}
}
