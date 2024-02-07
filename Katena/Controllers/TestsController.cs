using Katena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Katena.Controllers
{
	public class TestsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
