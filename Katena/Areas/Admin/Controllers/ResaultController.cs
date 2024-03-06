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

		public IActionResult Edit(Guid id)
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
			}
			else
			{
				entity = dataManager.Resaults.GetResaultById(id);
            }
			return View(entity);
		}

        [HttpPost]
        public IActionResult Edit(ResaultsBase model)
        {
            dataManager.Resaults.SaveResault(model);
            return View(model);
        }
    }

 
}