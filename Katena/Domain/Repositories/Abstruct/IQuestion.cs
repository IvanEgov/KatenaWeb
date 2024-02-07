using ASPLearn.Domain.Entities;

namespace ASPLearn.Domain.Repositories.Abstruct
{
	public interface IQuestion
	{
		IQueryable<QuestionBase> GetAllQuestions();
		QuestionBase GetQuestionById(Guid Id);
		void SaveQuestion(QuestionBase entity);
		void DeleteQuestion(Guid Id);
	}
}
