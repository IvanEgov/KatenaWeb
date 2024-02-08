using Katena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Katena.Controllers
{
    public class AbilitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
