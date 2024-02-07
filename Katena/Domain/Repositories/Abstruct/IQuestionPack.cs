using ASPLearn.Domain.Entities;

namespace ASPLearn.Domain.Repositories.Abstruct
{
	public interface IQuestionPack
	{
		IQueryable<QuestionPackBase> GetAllPacks();
		QuestionPackBase GetPackById(Guid Id);
		void SavePack(QuestionPackBase entity);
		void DeletePack(Guid Id);
	}
}
