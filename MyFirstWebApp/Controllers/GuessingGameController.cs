using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace MyFirstWebApp.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult GuessNumber()
        {            
            int secret = GuessingGameModel.SecretNumber();
            HttpContext.Session.SetInt32("SecretNumber", secret);
            ViewBag.Message = "Secret Number Set!";
            return View();
        }
        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {
            int answer=(int)HttpContext.Session.GetInt32("SecretNumber");
            
            bool didIWin=GuessingGameModel.Game(guess, answer);
            
            if (didIWin == true)
                ViewBag.Message = "You guessed right";
            else
                ViewBag.Message = GuessingGameModel.HighOrLow(guess, answer);

            return View();
        }
    }
}
