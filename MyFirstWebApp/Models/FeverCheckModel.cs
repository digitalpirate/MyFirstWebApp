namespace MyFirstWebApp.Models
{
    public class FeverCheckModel
    {
        public static string FeverMessage()
        {
            return "Enter your temperature.";
        }
        public string CheckTemperature(double temperature)
        {
            if (temperature > 38)
            {
                return "Fever";
            }
            else
            {
                return "Normal";
            }
                
        }
    }
}
