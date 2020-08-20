using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s = Kata.Anagrams("racer",
                new List<string>
                    {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"});
            var d = 4;
        }
    }

    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words) =>
            words.Where(w => w.ToCharArray().OrderBy(c => c).SequenceEqual(word.ToCharArray().OrderBy(c => c))).ToList();
    }
}