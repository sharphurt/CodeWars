using System.Linq;

namespace SumOfTwoLowest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers) => numbers.OrderBy(n => n).Take(2).Sum();
    }
}