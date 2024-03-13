using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Katena.Controllers
{
	public class TestsController : Controller
	{
		private readonly DataManager dataManager;

		public TestsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index(Guid id)
		{
			if (id != default)
			{
				return View("Show", dataManager.Packs.GetPackById(id));
			}
/*			ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageTests");*/
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}

		public IActionResult TestPartView(QuestionPackBase entity)
		{

		}
	}
}
