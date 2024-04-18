using Katena.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.News.GetNewsById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.News.GetNews());
        }
    }
}
