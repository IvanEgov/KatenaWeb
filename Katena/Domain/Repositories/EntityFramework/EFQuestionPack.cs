using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
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

		public void AddQuestion(QuestionPackBase pack, Guid questionId)
		{
			Guid check = pack.QuestionsIds.FirstOrDefault(x => x == questionId);
			if (check == Guid.Empty) 
			{
                pack.QuestionsIds.Add(questionId);
            }
			context.SaveChanges();
		}

		public void DeleteQuestion(QuestionPackBase pack, Guid questionId)
		{
			pack.QuestionsIds.Remove(questionId);
			context.SaveChanges();
		}

		public void AddResault(QuestionPackBase pack, Guid resultId) 
		{
			Guid check = pack.ResaultsId.FirstOrDefault(x => x == resultId);
			if (check == Guid.Empty) 
			{
                pack.ResaultsId.Add(resultId);
            }
            context.SaveChanges();

		}

		public void DeleteResult(QuestionPackBase pack, Guid resultId)
		{
			pack.ResaultsId.Remove(resultId);
			context.SaveChanges();
		}

		public void SavePack(QuestionPackBase entity)
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
