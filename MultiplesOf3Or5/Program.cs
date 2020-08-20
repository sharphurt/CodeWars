using System.Linq;

namespace MultiplesOf3Or5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static int Solution(int value) => Enumerable.Range(0, value).Where(i => i % 5 * (i % 3) == 0).Sum();
    }
}