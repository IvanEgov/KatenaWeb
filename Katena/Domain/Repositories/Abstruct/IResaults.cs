using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
    public interface IResaults
    {
        IQueryable<ResaultsBase> GetAllResaults();
        ResaultsBase GetResaultById(Guid Id);
        void SaveResault(ResaultsBase entity);
        void DeleteResaultById(Guid Id);
    }
}
