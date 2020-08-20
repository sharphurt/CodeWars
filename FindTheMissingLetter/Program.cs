using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheMissingLetter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // n
            var hui = Kata.FindMissingLetter("hijklmopqr".ToUpper().ToCharArray());
            var f = 2;
        }
    }

    public class Kata
    {
        public static char FindMissingLetter(char[] array)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz"
                .ToCharArray().Select(c => char.IsUpper(array[0]) ? char.ToUpper(c) : c);
            return alphabet
                .SkipWhile(c => c != array[0])
                .Except(array)
                .First();
        }
    }
}