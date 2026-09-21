using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	public interface IFeedback
	{
		IQueryable<FeedbackBase> GetFeedbacks();
		FeedbackBase GetFeedbackById(Guid id);
		void SaveFeedback(FeedbackBase entity);
		void DeleteFeedback(Guid id);
	}
}
