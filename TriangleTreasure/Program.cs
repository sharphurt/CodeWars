using System.Linq;

namespace TriangleTreasure
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static int Triangular(int n) => n > 0 ? Enumerable.Range(1, n).Sum() : 0;
    }
}