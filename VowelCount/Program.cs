using System;
using System.Linq;

namespace VowelCount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetVowelCount("abracadabra"));
        }
    }

    public static class Kata
    {
        public static int GetVowelCount(string str) => 
            str.Count(c => new[] {'a', 'e', 'i', 'o', 'u'}.Contains(c));
    }
}