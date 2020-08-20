namespace CalculateBIM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string Bmi(double weight, double height)
        {
            var bim = weight / (height * height);
            if (bim <= 18.5)
                return "Underweight";
            if (bim <= 25.0)
                return "Normal";
            if (bim <= 30.0)
                return "Overweight";
            return "Obese";
        }
    }
}