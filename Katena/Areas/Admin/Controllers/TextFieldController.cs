using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using SixLabors.ImageSharp;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TextFieldController : Controller
	{
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public TextFieldController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(string codeWord)
		{
			TextField entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
			return View("~/Areas/Admin/Views/TextField/Edit.cshtml", entity);
		}
			
		[HttpPost]
		public IActionResult Edit(TextField model, IFormFile titleImageFile)	
		{
			if (ModelState.IsValid)
			{
                /*if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }*/
                dataManager.TextFields.SaveTextField(model);
				return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
			}
			return View(model);
		}
    }
}