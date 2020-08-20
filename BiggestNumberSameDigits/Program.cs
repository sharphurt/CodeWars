using System.Linq;

namespace BiggestNumberSameDigits
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            var biggest = long.Parse(string.Join("", n.ToString().ToCharArray().OrderByDescending(c => c)));
            if (biggest == n) biggest = -1;
            return biggest;
        }
    }
}