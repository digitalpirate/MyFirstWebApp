using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    public class FeverCheckController : Controller
    {        
        public IActionResult GetTemperature()
        {
            ViewBag.Message = FeverCheckModel.FeverMessage();
            return View();
        }
        [HttpPost]
        public IActionResult GetTemperature(int temperature)
        {
            ViewBag.Message=FeverCheckModel.CheckTemperature(temperature);
            return View();
        }
    }
}
