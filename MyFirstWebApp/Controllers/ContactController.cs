using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
