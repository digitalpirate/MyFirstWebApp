using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}
