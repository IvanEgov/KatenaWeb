using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	public interface IReason
	{
		IQueryable<ReasonBase> GetAllReasons();
		ReasonBase GetReasonById(Guid Id);
		void SaveReason(ReasonBase entity);
		void DeleteReasonById(Guid Id);
	}
}
