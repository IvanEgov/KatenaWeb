using Katena.Domain.Entities;
using Katena.Domain;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;
using Katena.Controllers;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AnswerController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public AnswerController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Edit(Guid id)
		{
			AnswersBase entity;
			if (id == default)
			{
				entity = new AnswersBase();
				entity.Action = string.Empty;
				entity.Type = string.Empty;
				entity.Weight = 0.0;
				entity.Reason = string.Empty;
				dataManager.Answers.SaveAnswer(entity);
			}
			else
			{
				entity = dataManager.Answers.GetAnswerById(id);
			}
			return View(entity);
		}

        [HttpPost]
        public IActionResult Edit(AnswersBase model)
        {
            dataManager.Answers.SaveAnswer(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult ReturnHome()
        {
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}