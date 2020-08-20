using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpandedNumberForm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static string ExpandedForm(long num)
        {
            var numStr = num.ToString().Reverse().Select((n, i) => new {n, i}).Where(g => g.n != '0').ToList();
            var res = numStr.Select(n => (long) Math.Pow(10, n.i) * long.Parse(n.n.ToString())).Reverse().ToList();
            return string.Join(" + ", res);
        }
    }
}