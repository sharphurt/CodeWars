using System.Linq;

namespace CountingSheeps
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(b => b);
    }
}