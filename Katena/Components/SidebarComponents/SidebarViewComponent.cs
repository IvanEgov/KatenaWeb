using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Components.SidebarComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            IQueryable<NewsBase> news = dataManager.News.GetNews();
            List<NewsBase> reversedNews = news.ToList();
            reversedNews.Reverse();
            return Task.FromResult((IViewComponentResult)View("Default", reversedNews));
        }
    }
}
