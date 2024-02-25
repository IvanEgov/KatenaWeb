using Katena.Domain.Entities;
using Katena.Domain;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ResaultController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public ResaultController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Edit(Guid id, QuestionPackBase pack)
		{
			ResaultsBase entity;
			if (id == default)
			{
				entity = new ResaultsBase();
				entity.Type = string.Empty;
				entity.Gender = string.Empty;
				entity.Resault =  string.Empty;
				entity.Style = string.Empty;
				dataManager.Resaults.SaveResault(entity);
				entity.Id = Guid.NewGuid();
				/*dataManager.Packs.AddResault(pack, entity);*/
			}
			else
			{
				entity = dataManager.Resaults.GetResaultById(id);
                /*dataManager.Packs.AddResault(pack, entity);*/
            }
			return View(entity);
		}

		[HttpPost]
		public IActionResult Delete(Guid id)
		{
			dataManager.Resaults.DeleteResaultById(id);
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}
	}
}