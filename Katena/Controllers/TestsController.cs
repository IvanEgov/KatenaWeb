using Humanizer;
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
		
		//respresents number of page while carrying test (-1 - wellcome page,
		//[0:number of questions] - question, number of questions> results)
		private int index;

		public TestsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index(Guid id)
		{
			if (id != default)
			{
				QuestionPackBase pack = dataManager.Packs.GetPackById(id);
				index = -1;
				ViewBag.pack = pack;
				ViewBag.index = index;
				ViewBag.fool = false;
				return View();
			}
/*			ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageTests");*/
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}

		[HttpPost]
		public IActionResult NextQuestion(Guid pack, int index, Guid question, Guid answers, Guid reason)
		{
			//TODO: Test logic
			index = index + 1;
			ViewBag.pack = dataManager.Packs.GetPackById(pack);
			ViewBag.index = index;
			return View("Index", dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}
	}
}
