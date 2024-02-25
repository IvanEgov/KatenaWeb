using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Katena.Domain;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntietyFramework
{
	//Функционал QuestionsPack через бд
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

		public void AddQuestion(QuestionPackBase pack, QuestionBase entity)
		{
			pack.QuestionsIds.Add(entity.Id);
			context.SaveChanges();
		}

		public void AddResault(QuestionPackBase pack, ResaultsBase entity) 
		{
			pack.ResaultsId.Add(entity.Id);
			context.SaveChanges();
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

		public string GetResault(Guid Id, string KeyGender, string KeyStyle, string KeyType)
		{
			QuestionPackBase pack = GetPackById(Id);
			foreach(Guid id in pack.ResaultsId)
			{
				ResaultsBase resault = context.Resaults.FirstOrDefault(x => x.Id == id);
				if (resault.Gender == KeyGender && resault.Style == KeyStyle && resault.Type == KeyType)
				{
					return resault.Resault;
				}
			}
            return "none";
        }
	}
}
