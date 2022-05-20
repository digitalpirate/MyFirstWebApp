using System;
namespace MyFirstWebApp.Models
{
    public class GuessingGameModel
    {
        public static int SecretNumber()
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 101);
            return secretNumber;
        }
        public static bool Game(int guess,int answer)
        {
            if (guess == answer)
                return true;
            return false;
        }
        public static string HighOrLow(int guess, int answer)
        {
            if (guess > answer)
                return "Too high";
            else
                return "Too low";
        } 
    }
}
