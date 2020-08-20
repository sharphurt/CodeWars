using System.Linq;

namespace SumOfPositive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int PositiveSum(int[] arr) => arr.Where(n => n > 0).Sum();
    }
}