using System;
using System.Collections.Generic;
using System.Linq;

namespace SumDigPower
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class SumDigPower
    {
        public static long[] SumDigPow(long a, long b)
        {
            var result = new List<long>();
            for (var i = a; i <= b; i++)
                if (CheckNumberForThis(i))
                    result.Add(i);
            return result.ToArray();
        }

        private static bool CheckNumberForThis(long num) =>
            Math.Abs(num.ToString().Select(c => int.Parse(c.ToString()))
            .Select((n, i) => new {n = Math.Pow(n, i + 1)})
            .Sum(g => g.n) - num) < double.Epsilon * 100;
    }
}