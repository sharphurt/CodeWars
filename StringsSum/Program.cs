using System.Globalization;
using System.Numerics;

namespace Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static string SumStrings(string a, string b)
        {
            BigInteger.TryParse(a, out var outA);
            BigInteger.TryParse(b, out var outB);
            return (outA + outB).ToString();
        }
    }
}