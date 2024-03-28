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
		private int testIndex;

		public TestsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index(Guid id)
		{
			if (id != default)
			{
				QuestionPackBase nowPack = dataManager.Packs.GetPackById(id);
				testIndex = -1;
				ViewBag.nowPack = nowPack;
				ViewBag.testIndex = testIndex;
				return View();
			}
/*			ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageTests");*/
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}

		[HttpPost]
		public IActionResult NextQuestion(QuestionPackBase nowPack, int index, QuestionBase question = null, AnswersBase answers = null, ReasonBase reason = null)
		{
			//TODO: Test logic
			testIndex = index + 1;
			ViewBag.nowPack = nowPack;
			ViewBag.testIndex = testIndex;
			ViewBag.fool = false;
			return View();
		}
	}
}
