using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult GuessNumber()
        {
            ViewBag.Message = GuessingGameModel.GuessingGameMessage();
            return View();
        }
    }
}
