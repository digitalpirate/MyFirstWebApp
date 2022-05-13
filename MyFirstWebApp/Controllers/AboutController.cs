using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
