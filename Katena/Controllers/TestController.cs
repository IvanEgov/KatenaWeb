using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Controllers
{
    public class TestController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public TestController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(Guid id)
        {
            QuestionPackBase entity = dataManager.Packs.GetPackById(id);
            return View(entity);
        }
    }
}
