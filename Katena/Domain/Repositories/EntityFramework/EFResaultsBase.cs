using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
    public class EFResaultsBase : IResaults
    {
        private readonly AppDbContext context;

        public EFResaultsBase(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ResaultsBase> GetAllResaults()
        {
            return context.Resaults;
        }

        public ResaultsBase GetResaultById(Guid id)
        {
            return context.Resaults.FirstOrDefault(x => x.Id == id);
        }

        public void SaveResault(ResaultsBase entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public void DeleteResaultById(Guid id)
        {
            context.Resaults.Remove(new ResaultsBase { Id = id });
            context.SaveChanges();
        }
    }
}
