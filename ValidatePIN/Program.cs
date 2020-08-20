using System.Text.RegularExpressions;

namespace ValidatePIN
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        
    }
    
    public class Kata
    {
        public static bool ValidatePin(string pin) => Regex.IsMatch(pin, "[0-9]{6}|[0-9]{4}");
    }
    
}