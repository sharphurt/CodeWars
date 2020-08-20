using System;

namespace IsItSquare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static bool IsSquare(int n) => Math.Abs(Math.Sqrt(n) % 1) < double.Epsilon * 100;
    }
}