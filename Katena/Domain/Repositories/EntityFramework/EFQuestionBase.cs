using Microsoft.EntityFrameworkCore;
using Katena.Domain.Repositories.Abstruct;
using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.EntietyFramework
{
	//Функционал Questions через бд
	public class EFQuestionBase : IQuestion
	{
		private readonly AppDbContext context;
		public EFQuestionBase(AppDbContext context)
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

		//Подумать, что делать с весами
        public AnswersBase GetAnswer(Guid id, string KeyAction)
        {
			QuestionBase question = GetQuestionById(id);
			foreach(Guid Id in question.AnswerId)
			{
				AnswersBase answer = context.Answers.FirstOrDefault(x => x.Id == Id);
				if (answer.Action == KeyAction)
				{
					return answer;
				}
			}
			return new AnswersBase();
        }

		public void AddAnswer(QuestionBase question, Guid answerId) 
		{
			Guid check = question.AnswerId.FirstOrDefault(x => x == answerId);

            if (check == Guid.Empty)
			{
                question.AnswerId.Add(answerId);
            }
			context.SaveChanges();
		}
		
		public void DeleteAnswer(QuestionBase question, Guid answerId)
		{
			question.AnswerId.Remove(answerId);
			context.SaveChanges();
		}

        public void SaveQuestion(QuestionBase entity) 
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

		public void DeleteQuestion(Guid id)
		{
			context.Questions.Remove(new QuestionBase {Id = id });
			context.SaveChanges();
		}
    }
}
