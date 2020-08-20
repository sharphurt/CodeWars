using System;

namespace BinaryAddition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static string AddBinary(int a, int b) => Convert.ToString(a + b, 2);
    }
}