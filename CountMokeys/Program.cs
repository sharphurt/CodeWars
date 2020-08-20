using System.Linq;

namespace CountMokeys
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class MonkeyCounter
    {
        public static int[] MonkeyCount(int n) => Enumerable.Range(1, n).ToArray();
    }
}