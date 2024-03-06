using Katena.Domain.Entities;
using Katena.Domain;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class QuestionController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public QuestionController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Edit(Guid id)
		{
			QuestionBase entity;
			if (id == default)
			{
				entity = new QuestionBase();
				entity.Name = "Вопрос еще не задан";
				entity.AnswerId = new List<Guid> {Guid.Empty};
				dataManager.QuestionBase.SaveQuestion(entity);
			}
			else
			{
				entity = dataManager.QuestionBase.GetQuestionById(id);
			}
			return View(entity);
		}

        [HttpPost]
        public IActionResult Edit(QuestionBase model)
        {
            dataManager.QuestionBase.SaveQuestion(model);
            return View(model);
        }

        [HttpPost]
		public IActionResult AddAnswer(Guid questionId, Guid answerId)
		{
			QuestionBase question = dataManager.QuestionBase.GetQuestionById(questionId);
			dataManager.QuestionBase.AddAnswer(question, answerId);
			return View("Edit", question);
        }

        [HttpPost]
        public IActionResult DeleteAnswer(Guid id, Guid questionId)
        {
			QuestionBase question = dataManager.QuestionBase.GetQuestionById(questionId);
            dataManager.QuestionBase.DeleteAnswer(question, id);
            dataManager.Answers.DeleteAnswerById(id);
            return View("Edit", question);
        }
    }
}