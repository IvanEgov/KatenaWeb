using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TextFieldController : Controller
	{
		private readonly DataManager dataManager;
		public TextFieldController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Edit(string codeWord)
		{
			TextField entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
			return View("~/Areas/Admin/Views/TextField/Edit.cshtml", entity);
		}
			
		[HttpPost]
		public IActionResult Edit(TextField model)	
		{
			if (ModelState.IsValid)
			{
				dataManager.TextFields.SaveTextField(model);
				return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
			}
			return View(model);
		}
	}
}