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
				entity.Name = "Введите имя";
				entity.Description = "Введите описание";
				entity.Instructions = "Введите инструкцию";
				entity.QuestionsIds = new List<Guid> {Guid.NewGuid()};
				entity.ResaultsId = new List<Guid> {Guid.NewGuid()};
				dataManager.Packs.SavePack(entity);
				entity.Id = Guid.NewGuid();
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
            if (ModelState.IsValid)
            {
                dataManager.Packs.SavePack(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

		[HttpPost]
		public IActionResult AddQuestion(Guid id, QuestionPackBase model)
		{
			model.QuestionsIds.Add(id);
			return View(model);
		}

        [HttpPost]
		public IActionResult Delete(Guid id)
		{
			dataManager.Packs.DeletePack(id);
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}
	}
}