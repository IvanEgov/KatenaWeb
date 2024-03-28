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

		public IViewComponentResult Invoke(QuestionPackBase pack, int index = -1, bool reason = false, AnswersBase answer = null)
        {
            ViewBag.pack = pack;
            ViewBag.index = index;
            if (index == -1)
            {
                return View("TestWelcome");
            }
            else if (index < pack.QuestionsIds.Count && !reason)
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
