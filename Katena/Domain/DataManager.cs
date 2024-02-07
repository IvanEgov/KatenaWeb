using ASPLearn.Domain.Entities;
using ASPLearn.Domain.Repositories;
using ASPLearn.Domain.Repositories.Abstruct;
namespace ASPLearn.Domain
{
	public class DataManager
	{
		public IQuestionPack Packs { get; set; }
		public IQuestion QuestionBase { get; set; }

		public DataManager(IQuestionPack packs, IQuestion questionBase)
		{
			Packs = packs;
			QuestionBase = questionBase;
		}
	}
}
