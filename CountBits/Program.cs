using System;
using System.Linq;

namespace CountBits
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static int CountBits(int n) => Convert.ToString(n, 2).Count(c => c == '1');
    }
}