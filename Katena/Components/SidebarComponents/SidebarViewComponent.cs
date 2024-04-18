using Katena.Domain;
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
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.News.GetNews()));
        }
    }
}
