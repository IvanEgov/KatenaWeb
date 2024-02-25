using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	//Публичный интерфейс, позволяющий получить все наборы вопросов(тесты), получить нужный тест по Id, получить результат теста по Id теста, полу,
	//Стилю, типу личности, сохранить новый тест(или изменеие в уже имеющемся), удалить тест.
	public interface IQuestionPack
	{
		IQueryable<QuestionPackBase> GetAllPacks();
		QuestionPackBase GetPackById(Guid Id);
		string GetResault(Guid Id, string KeyGender, string KeyStyle, string KeyType);
		void AddQuestion(QuestionPackBase pack, QuestionBase entity);
		void AddResault(QuestionPackBase pack, ResaultsBase entity);
		void SavePack(QuestionPackBase entity);
		void DeletePack(Guid Id);
	}
}
