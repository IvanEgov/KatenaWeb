using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
	public class EFReasonBase : IReason
	{
		private readonly AppDbContext context;

		public EFReasonBase(AppDbContext context)
		{
			this.context = context;
		}
		public IQueryable<ReasonBase> GetAllReasons()
		{
			return context.Reasons;
		}

		public ReasonBase GetReasonById(Guid id)
		{
			return context.Reasons.FirstOrDefault(x => x.Id == id);
		}

		public void SaveReason(ReasonBase entity)
		{
			if (entity.Id == default)
			{
				context.Entry(entity).State = EntityState.Added;
				entity.Id = Guid.NewGuid();
			}
			else
			{
				context.Entry(entity).State = EntityState.Modified;
			}

			context.SaveChanges();
		}

		public void DeleteReasonById(Guid id)
		{
			context.Reasons.Remove(new ReasonBase { Id = id });
			context.SaveChanges();
		}
	}
}
