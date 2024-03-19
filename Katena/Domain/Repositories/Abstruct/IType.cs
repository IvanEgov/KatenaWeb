using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
	public interface IType
	{
		IQueryable<TypeBase> GetAllType();
		TypeBase GetTypeById(Guid Id);
		void SaveType(TypeBase entity);
		void DeleteTypeById(Guid Id);
	}
}
