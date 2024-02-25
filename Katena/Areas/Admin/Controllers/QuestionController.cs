using Katena.Domain.Entities;
using Katena.Domain;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class QuestionController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public QuestionController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}
        public IActionResult Edit(Guid id)
		{
			QuestionBase entity;
			if (id == default)
			{
				entity = new QuestionBase();
				entity.Name = string.Empty;
                entity.AnswerId = new List<Guid> { };
                dataManager.QuestionBase.SaveQuestion(entity);
				entity.Id = Guid.NewGuid();
			}
			else
			{
				entity = dataManager.QuestionBase.GetQuestionById(id);
            }
			return View(entity);
		}

		[HttpPost]
		public IActionResult Delete(Guid id)
		{
			dataManager.QuestionBase.DeleteQuestion(id);
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}
	}
}