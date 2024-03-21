using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReasonController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public ReasonController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}
		public IActionResult Edit(Guid id)
		{
			ReasonBase entity;
			if (id == default)
			{
				entity = new ReasonBase();
				entity.Reason = string.Empty;
				entity.Weight = 0.0;
				entity.Weight1 = 0.0;
				entity.Weight2 = 0.0;
				entity.Weight3 = 0.0;
				entity.Weight4 = 0.0;
				entity.Weight5 = 0.0;
				entity.Weight6 = 0.0;
				entity.Weight7 = 0.0;
				entity.Weight8 = 0.0;
				entity.Weight9 = 0.0;
				entity.Weight10 = 0.0;
				entity.Weight11 = 0.0;
				dataManager.Reasons.SaveReason(entity);
			}
			else
			{
				entity = dataManager.Reasons.GetReasonById(id);
			}
			return View(entity);
		}

		[HttpPost]
		public IActionResult Edit(ReasonBase model)
		{
			dataManager.Reasons.SaveReason(model);
			return View(model);
		}

        [HttpPost]
        public IActionResult ReturnHome()
        {
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
