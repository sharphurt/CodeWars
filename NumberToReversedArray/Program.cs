using System.Linq;

namespace NumberToReversedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    class Digitizer
    {
        public static long[] Digitize(long n) => n.ToString().Reverse().Select(c => long.Parse(c.ToString())).ToArray();
    }
}