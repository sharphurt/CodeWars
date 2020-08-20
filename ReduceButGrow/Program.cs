using System.Linq;

namespace ReduceButGrow
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int Grow(int[] x) => x.Aggregate((a, b) => a * b);
    }
}