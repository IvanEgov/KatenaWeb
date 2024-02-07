using Microsoft.AspNetCore.Mvc;

namespace Katena.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
