using Katena.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class FeedBackController : Controller
	{
		private readonly DataManager dataManager;
		private readonly IWebHostEnvironment hostingEnvironment;

		public FeedBackController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			this.dataManager = dataManager;
			this.hostingEnvironment = hostingEnvironment;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
