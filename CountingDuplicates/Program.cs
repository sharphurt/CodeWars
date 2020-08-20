using System;
using System.Linq;

namespace CountingDuplicates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.DuplicateCount("aabBcde"));
        }
    }

    public class Kata
    {
        public static int DuplicateCount(string str) =>
            str.ToLower().Where(c => str.ToLower().Count(a => a == c) > 1).Distinct().Count();
    }
}