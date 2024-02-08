using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	public interface IQuestionPack
	{
		IQueryable<QuestionPackBase> GetAllPacks();
		QuestionPackBase GetPackById(Guid Id);
		void SavePack(QuestionPackBase entity);
		void DeletePack(Guid Id);
	}
}
