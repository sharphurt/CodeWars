using System.Linq;

namespace FindOutlier
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kata.Find(new[] {0, 2, 4, 5, 6, 8, 10});
        }
    }

    public class Kata
    {
        public static int Find(int[] nums) => nums.GroupBy(n => n % 2).First(g => g.Count() == 1).Min();
    }
}