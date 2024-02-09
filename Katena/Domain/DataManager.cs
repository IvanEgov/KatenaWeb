using Katena.Domain.Entities;
using Katena.Domain.Repositories;
using Katena.Domain.Repositories.Abstruct;
namespace Katena.Domain
{
	public class DataManager
	{
		public IQuestionPack Packs { get; set; }
		public IQuestion QuestionBase { get; set; }
		public ITextField TextFields { get; set; }

		public DataManager(IQuestionPack packs, IQuestion questionBase, ITextField textFields)
		{
			Packs = packs;
			QuestionBase = questionBase;
			TextFields = textFields;
		}
	}
}
