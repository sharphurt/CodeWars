using System.Linq;

namespace CountOfPositiveSumOfNegative
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] i) =>
            i == null || i.Length == 0 ? new int[0] : new[] {i.Count(x => x > 0), i.Where(x => x < 0).Sum()};
    }
}