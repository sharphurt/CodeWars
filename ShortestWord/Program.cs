using System;
using System.Linq;

namespace ShortestWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindShort("turns out random test cases are easier than writing out basic ones"));
        }
    }
    
    public class Kata
    {
        public static int FindShort(string s) => 
            s.Split(' ').OrderBy(word => word.Length).First().Length;
    }
}