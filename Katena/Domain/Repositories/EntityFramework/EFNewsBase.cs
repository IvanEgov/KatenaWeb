using Katena.Domain.Entities;
using Katena.Domain.Repositories.Abstruct;
using Microsoft.EntityFrameworkCore;

namespace Katena.Domain.Repositories.EntityFramework
{
    public class EFNewsBase : INews
    {
        private readonly AppDbContext context;
        public EFNewsBase(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<NewsBase> GetNews()
        {
            return context.News;
        }

        public NewsBase GetNewsById(Guid id)
        {
            return context.News.FirstOrDefault(x => x.Id == id);
        }

        public void SaveNews(NewsBase entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteNews(Guid id)
        {
            context.News.Remove(new NewsBase() { Id = id });
            context.SaveChanges();
        }
    }
}
