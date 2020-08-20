using System.Linq;

namespace SumWithoutMaxMin
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static int Sum(int[] n) =>
            n == null || n.Length == 0 ? 0 : n.Length > 1 ? n[0] : n.Sum() - n.Max() - n.Min();
    }
}