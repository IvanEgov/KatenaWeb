using Katena.Domain;
using Katena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Katena.Controllers
{
	public class ContactsController : Controller
	{
		private readonly DataManager dataManager;

		public ContactsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index()
		{
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
		}
	}
}