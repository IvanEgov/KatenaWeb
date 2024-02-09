using Microsoft.EntityFrameworkCore;
using Katena.Domain;
using Katena.Domain.Repositories.Abstruct;
using Katena.Domain.Entities;
using Microsoft.Identity.Client;
using static Katena.Domain.Entities.QuestionBase;

namespace Katena.Domain.Repositories.EntietyFramework
{
	//Функционал Questions через бд
	public class EFQuestion : IQuestion
	{
		private readonly AppDbContext context;
		public EFQuestion(AppDbContext context)
		{
			this.context = context;
		}

		public IQueryable<QuestionBase> GetAllQuestions()
		{
			return context.Questions;
		}

		public QuestionBase GetQuestionById(Guid id) 
		{
			return context.Questions.FirstOrDefault(x => x.Id == id);
		}

		public void SaveQuestion(QuestionBase entity) 
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

		public void DeleteQuestion(Guid id)
		{
			context.Questions.Remove(new QuestionBase() { Id = id });
			context.SaveChanges();
		}

        public IQueryable<QuestionBase> GetAnswer()
        {
            throw new NotImplementedException();
        }

		public Answer GetAnswer(Guid Id, string KeyAction, string KeyReason)
		{
			return GetQuestionById(Id).Answers[KeyAction][KeyReason];
        }
    }
}
