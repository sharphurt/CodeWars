using System.Linq;

namespace InvertValues
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input) => input.Select(n => -n).ToArray();
    }
}