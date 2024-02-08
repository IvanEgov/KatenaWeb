using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	public interface IQuestion
	{
		IQueryable<QuestionBase> GetAllQuestions();
		QuestionBase GetQuestionById(Guid Id);
		IQueryable<QuestionBase> GetAnswer();
		void SaveQuestion(QuestionBase entity);
		void DeleteQuestion(Guid Id);
	}
}
