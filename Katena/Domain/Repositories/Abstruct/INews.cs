using Katena.Domain.Entities;

namespace Katena.Domain.Repositories.Abstruct
{
    public interface INews
    {
        IQueryable<NewsBase> GetNews();
        NewsBase GetNewsById(Guid id);
        void SaveNews(NewsBase entity);
        void DeleteNews(Guid id);
    }
}
