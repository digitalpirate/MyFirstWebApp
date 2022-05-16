namespace MyFirstWebApp.Models
{
    public class FeverCheckModel
    {
        public static string FeverMessage()
        {
            return "Enter your temperature.";
        }
        public string CheckTemperature(int temperature)
        {
            if (temperature >= 38)
            {
                return "Fever";
            }
            else if (temperature <= 35)
            {
                return "Hyptothermia";
            }
            else
            {
                return "Normal";
            }
                
        }
    }
}
