using System.Linq;

namespace ZerosToTheEnd
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr) => arr.Where(n => n != 0).Concat(arr.Where(i => i == 0)).ToArray();
    }
}