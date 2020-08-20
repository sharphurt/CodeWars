using System;
using System.Linq;

namespace HighestScoringWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.High("man i need a taxi up to ubud"));
            Console.WriteLine(Kata.High("what time  are we climbing up to the volcano"));
            Console.WriteLine(Kata.High("take me to semynak"));
            Console.WriteLine(Kata.High("pbmziycygvfmflnufcusgevuiz ydsxtnwrntzkuyglrxuk"));
        }
    }

    public class Kata
    {
        public static string High(string s)
        {
            return s.Split(' ').OrderBy(w => w.Select(c => c - (int)'a').Sum()).Last();
        }
    }
}