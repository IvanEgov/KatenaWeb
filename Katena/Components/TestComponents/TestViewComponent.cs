using Katena.Areas.Admin.Controllers;
using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace Katena.Components
{
 
    public class TestViewComponent: ViewComponent
    {
        private readonly DataManager _dataManager;

		public TestViewComponent(DataManager dataManager)
		{
			this._dataManager = dataManager;
		}

		public IViewComponentResult Invoke(QuestionPackBase pack, int index = -1, bool reason = false, AnswersBase? answer = null, double? distr_mentorP = 0, double? distr_lookingP = 0, double? distr_hunterP = 0, double? distr_mentor = 0, double? distr_looking = 0,
            double? distr_hunter = 0, double? style_PP = 0, double? style_AA = 0, double? style_EE = 0, double? style_II = 0, double? style_P = 0, double? style_A = 0, double? style_E = 0, double? style_I = 0)
        {
            ViewBag.pack = pack;
            ViewBag.index = index;
            if (index == -1)
            {
                return View("TestWelcome");
            }
            else if (index < pack.QuestionsIds.Count)
            {
                QuestionBase question = _dataManager.QuestionBase.GetQuestionById(pack.QuestionsIds[index]);
                ViewBag.question = question;
                if (reason)
                {
					ViewBag.answer = answer;
					return View("TestReasons");
				}
                return View("TestProcess");
            }
            return View("TestFinish");
        }

    }
}
