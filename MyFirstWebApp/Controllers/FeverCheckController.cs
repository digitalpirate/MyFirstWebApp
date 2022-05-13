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
        public IActionResult GetTemperature(double temp)
        {
            FeverCheckModel bodyTemp = new FeverCheckModel();
            ViewBag.Message=bodyTemp.CheckTemperature(temp);
            return View();
        }
    }
}
