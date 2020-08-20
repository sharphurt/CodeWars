using System.Linq;

namespace Summation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static int summation(int num) => Enumerable.Range(1, num).Sum();
    }
}