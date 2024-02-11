using Katena.Domain.Entities;
using static Katena.Domain.Entities.QuestionBase;

namespace Katena.Domain.Repositories.Abstruct
{
	//Публичный интерфейс, позволяющий получать все вопросы, конкретный вопрос по Id, ответ на конкретный вопрос по Id вопроса, действию и мотиву,
	//Сохранить новый вопрос(или изменение в старом), удалить вопрос по Id
	public interface IQuestion
	{
		IQueryable<Question> GetAllQuestions();
		Question GetQuestionById(Guid Id);
		Question.Answers GetAnswer(Guid Id, string KeyAction, string KeyReason);
		void SaveQuestion(Question entity);
		void DeleteQuestion(Guid Id);
	}
}
