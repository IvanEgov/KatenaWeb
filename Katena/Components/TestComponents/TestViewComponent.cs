using Katena.Areas.Admin.Controllers;
using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Katena.Components
{
    
    public class Test : ViewComponent
    {
        private readonly DataManager _dataManager;

        public IViewComponentResult Invoke(QuestionPackBase pack, int index = -1)
        {
            if (index == -1)
            {
                return View("TestWelcome", pack);
            }
            else if (index < pack.QuestionsIds.Count)
            {
                QuestionBase question = _dataManager.QuestionBase.GetQuestionById(pack.QuestionsIds[index]);
                var model = new { question, index };
                return View("TestProcess", model);
            }
            return View("TestFinish", pack);
        }

    }
}
