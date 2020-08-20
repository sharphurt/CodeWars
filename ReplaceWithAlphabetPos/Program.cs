using System;
using System.Linq;

namespace ReplaceWithAlphabetPos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((int)'a');
            Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
        }
    }

    public static class Kata
    {
        public static string AlphabetPosition(string text) =>
            string.Join(" ", text.ToLower().Where(char.IsLetter).Select(c => c - '`'));
    }
}