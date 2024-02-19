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
			var entity = id == default ? new AnswersBase() : dataManager.Answers.GetAnswerById(id);
			return View(entity);
		}

		[HttpPost]
		public IActionResult Delete(Guid id)
		{
			dataManager.Answers.DeleteAnswerById(id);
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}
	}
}