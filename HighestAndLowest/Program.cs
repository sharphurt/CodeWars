using System.Linq;

namespace HighestAndLowest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            var nums = numbers.Split(' ').Select(int.Parse);
            return nums.Max() + " " + nums.Min();
        }
    }
}