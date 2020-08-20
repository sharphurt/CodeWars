using System.Linq;

namespace FindTheOddInt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    class Kata
    {
        public static int find_it(int[] seq) => seq.OrderBy(c => seq.Count(i => i == c) % 2 != 0).First();
    }
}