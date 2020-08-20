using System;

namespace SumOfNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum.GetSum(-1, 0));
        }
    }

    public class Sum
    {
        public static int GetSum(int a, int b)
        {
            var result = 0;
            for (var i = Math.Min(a, b); i <= Math.Max(a, b); i++)
                result += i;
            return result;
        }
    }
}