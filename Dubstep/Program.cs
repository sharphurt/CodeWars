using System;
using System.Text.RegularExpressions;

namespace Dubstep
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Dubstep
    {
        public static string SongDecoder(string input) =>
            String.Join(" ", input.Split(new [] {"WUB"}, StringSplitOptions.RemoveEmptyEntries)).Trim();
    }
}