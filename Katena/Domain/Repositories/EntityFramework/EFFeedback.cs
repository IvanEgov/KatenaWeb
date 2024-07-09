using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
	public class EFFeedback: IFeedback
	{
		private readonly AppDbContext context;
		public EFFeedback(AppDbContext context)
		{
			this.context = context;
		}

		public IQueryable<FeedbackBase> GetFeedbacks()
		{
			return context.Feedbacks;
		}

		public FeedbackBase GetFeedbackById(Guid id)
		{
			return context.Feedbacks.FirstOrDefault(x => x.id == id);
		}

		public void SaveFeedback(FeedbackBase entity)
		{
			if (entity.id == default)
				context.Entry(entity).State = EntityState.Added;
			else
				context.Entry(entity).State = EntityState.Modified;
			context.SaveChanges();
		}

		public void DeleteFeedback(Guid id)
		{
			context.Feedbacks.Remove(new FeedbackBase() { id = id });
			context.SaveChanges();
		}
	}
}
