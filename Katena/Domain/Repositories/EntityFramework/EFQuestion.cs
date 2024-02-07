using Microsoft.EntityFrameworkCore;
using Katena.Domain;
using ASPLearn.Domain.Repositories.Abstruct;
using ASPLearn.Domain.Entities;

namespace ASPLearn.Domain.Repositories.EntietyFramework
{
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
			_ = context.Questions.Remove(new QuestionBase() { Id = id });
			context.SaveChanges();
		}
	}
}
