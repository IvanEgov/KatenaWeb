using Humanizer;
using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Models;
using Katena.TestProg;
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
				return View();
			}
/*			ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageTests");*/
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}

		[HttpPost]
		public IActionResult NextQuestion(Guid pack, int index, Guid question, Guid answers, Guid reason, bool checkReason = false)
		{
            //TODO: Test logic
          //  

            ViewBag.reason = checkReason;
			
			if (!checkReason)
			{
				index = index + 1;
				if (reason != new  Guid("00000000-0000-0000-0000-000000000000"))
				{
					CalculationLoogiсReason calcReason = new CalculationLoogiсReason(dataManager.Reasons.GetReasonById(reason));
					calcReason.MassCheckReason();
					ViewBag.distr_mentorP = calcReason.distr_mentorP;
                    ViewBag.distr_lookingP  = calcReason.distr_lookingP;
                    ViewBag.distr_hunterP = calcReason.distr_hunterP;
                    ViewBag.distr_mentor = calcReason.distr_mentor;
                    ViewBag.distr_looking = calcReason.distr_looking;
                    ViewBag.distr_hunter = calcReason.distr_hunter;
                }
            }
			else
			{
				ViewBag.answer = dataManager.Answers.GetAnswerById(answers);
				if (answers != new Guid("00000000-0000-0000-0000-000000000000"))
				{
					CalculationLoogiсAnswer calcAnswer = new CalculationLoogiсAnswer(dataManager.Answers.GetAnswerById(answers));
					calcAnswer.MassCheckAnswer();
					ViewBag.style_PP = calcAnswer.style_PP;
                    ViewBag.style_AA = calcAnswer.style_AA;
                    ViewBag.style_EE = calcAnswer.style_EE;
                    ViewBag.style_II = calcAnswer.style_II;
                    ViewBag.style_P = calcAnswer.style_P;
                    ViewBag.style_A = calcAnswer.style_A;
                    ViewBag.style_E = calcAnswer.style_E;
                    ViewBag.style_I = calcAnswer.style_I;
                }
            }
			
			ViewBag.pack = dataManager.Packs.GetPackById(pack);
			ViewBag.index = index;
			
			if(ViewBag.pack != null)
			{
                if (ViewBag.index == ViewBag.pack.QuestionsIds.Count)
                {
                    /// Допсиать расчет результатат
                    /// 
                }
            }
			

			return View("Index", dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}
	}
}
