using Katena.Domain;
using Katena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Katena.Controllers
{
    public class AbilitiesController : Controller
    {
		private readonly DataManager dataManager;

		public AbilitiesController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index()
        {
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageAbilities"));
		}
    }
}
