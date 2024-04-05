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
				entity.Weight = 0;
				entity.Weight1 = 0;
				entity.Weight2 = 0;
				entity.Weight3 = 0;
				entity.Weight4 = 0;
				entity.Weight5 = 0;
				entity.Weight6 = 0;
				entity.Weight7 = 0;
				entity.Weight8 = 0;
				entity.Weight9 = 0;
				entity.Weight10 = 0;
				entity.Weight11 = 0;
				entity.Weight12 = 0;
				entity.Weight13 = 0;
				entity.Weight14 = 0;
				entity.Weight15 = 0;
				entity.typeWeight1 = 0;
				entity.typeWeight2 = 0;
				entity.typeWeight3 = 0;
				entity.typeWeight4 = 0;
				entity.reasonsId = new List<Guid> {Guid.NewGuid()};
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

        [HttpPost]
        public IActionResult AddReason(Guid answerId, Guid reasonId)
        {
            AnswersBase answer = dataManager.Answers.GetAnswerById(answerId);
            dataManager.Answers.AddReason(answer, reasonId);
            return View("Edit", answer);
        }

        [HttpPost]
		public IActionResult DeleteReason(Guid id, Guid answerId) 
		{
			AnswersBase answer = dataManager.Answers.GetAnswerById(answerId);
			dataManager.Answers.DeleteReason(answer, id);
			dataManager.Reasons.DeleteReasonById(id);
			return View("Edit", answer);
		}
    }
}