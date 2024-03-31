using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	//Публичный интерфейс, позволяющий получать все вопросы, конкретный вопрос по Id, ответ на конкретный вопрос по Id вопроса, действию и мотиву,
	//Сохранить новый вопрос(или изменение в старом), удалить вопрос по Id
	public interface IQuestion
	{
		IQueryable<QuestionBase> GetAllQuestions();
		QuestionBase GetQuestionById(Guid Id);
		AnswersBase GetAnswer(Guid Id, string KeyAction);
		void AddAnswer(QuestionBase question, Guid answerId);
		void DeleteAnswer(QuestionBase question, Guid answerId);
		void SaveQuestion(QuestionBase entity);
		void DeleteQuestion(Guid Id);
	}
}
