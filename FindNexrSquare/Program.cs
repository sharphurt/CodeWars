using System;

namespace FindNexrSquare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static long FindNextSquare(long num) => Math.Abs(Math.Sqrt(num) % 1) <= Double.Epsilon * 100
            ? (long) Math.Pow(Math.Ceiling(Math.Sqrt(num) + 1), 2)
            : -1;
    }
}