using System;
using System.Linq;

namespace CharWithLongestRepetition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static Tuple<char?, int> LongestRepetition(string s)
        {
            var longestChar = s.GroupBy(c => c).OrderBy(chars => chars.Count()).Last();
            return new Tuple<char?, int>(longestChar.Key, longestChar.Count());
        }
    }
}