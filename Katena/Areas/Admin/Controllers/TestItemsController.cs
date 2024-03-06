using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TestItemsController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public TestItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Edit(Guid id)
		{
			QuestionPackBase entity;
			if (id == default)
			{
				entity = new QuestionPackBase();
				entity.Name = string.Empty;
				entity.Description = string.Empty;
				entity.Instructions = string.Empty;
				entity.QuestionsIds = new List<Guid> {Guid.Empty};
				entity.ResaultsId = new List<Guid> {Guid.Empty};
				dataManager.Packs.SavePack(entity);
			}
			else
			{
				entity = dataManager.Packs.GetPackById(id);
			}
			return View(entity);
		}

        [HttpPost]
        public IActionResult Edit(QuestionPackBase model)
        {
            dataManager.Packs.SavePack(model);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        [HttpPost]
        public IActionResult AddQuestion(Guid questionId, Guid testId)
        {
			QuestionPackBase pack = dataManager.Packs.GetPackById(testId);
            dataManager.Packs.AddQuestion(pack, questionId);
            return View("Edit", pack);
        }

        [HttpPost]
        public IActionResult DeleteQuestion(Guid id, Guid testId)
        {
			QuestionPackBase pack = dataManager.Packs.GetPackById(testId);
            dataManager.Packs.DeleteQuestion(pack, id);
            dataManager.QuestionBase.DeleteQuestion(id);
            return View("Edit", pack);
        }

        [HttpPost]
        public IActionResult AddResault(Guid testId, Guid resaultId)
        {
			QuestionPackBase pack = dataManager.Packs.GetPackById(testId);
            dataManager.Packs.AddResault(pack, resaultId);
            return View("Edit", pack);
        }

        [HttpPost]
        public IActionResult DeleteResult(Guid id, Guid testId)
        {
			QuestionPackBase pack = dataManager.Packs.GetPackById(testId);
            dataManager.Packs.DeleteResult(pack, id);
            dataManager.Resaults.DeleteResaultById(id);
            return View("Edit", pack);
        }

        [HttpPost]

		public IActionResult ReturnHome()
		{
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}

        [HttpPost]
		public IActionResult Delete(Guid id)
		{
			dataManager.Packs.DeletePack(id);
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}
	}
}