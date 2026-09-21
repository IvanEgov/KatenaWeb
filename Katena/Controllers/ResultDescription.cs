using Microsoft.AspNetCore.Mvc;

namespace Katena.Controllers
{
	public class ResultDescription : Controller
	{
		public IActionResult Index(string gender)
		{
			ViewBag.Gender = gender;
			return View();
		}
	}
}
