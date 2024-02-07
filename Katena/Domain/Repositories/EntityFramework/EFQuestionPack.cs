using ASPLearn.Domain.Entities;
using ASPLearn.Domain.Repositories.Abstruct;
using Katena.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPLearn.Domain.Repositories.EntietyFramework
{
	public class EFQuestionPack : IQuestionPack
	{
		private readonly AppDbContext context;
		public EFQuestionPack(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<QuestionPackBase>GetAllPacks()
		{
			return context.Packs;
		}

		public QuestionPackBase GetPackById(Guid id)
		{
			return context.Packs.FirstOrDefault(x => x.Id == id);
		}

		public void SavePack(QuestionPackBase entity)
		{
			if (entity.Id == default) 
			{
				context.Entry(entity).State = EntityState.Added;
			}
			else
			{
				context.Entry(entity).State = EntityState.Modified;
			}
			context.SaveChanges();
		}

		public void DeletePack(Guid id)
		{
			context.Packs.Remove(new QuestionPackBase() { Id = id });
			context.SaveChanges();
		}
	}
}
