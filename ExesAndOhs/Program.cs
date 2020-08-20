using System;
using System.Linq;

namespace ExesAndOhs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.XO("xo"));
            Console.WriteLine(Kata.XO("xxOo"));
            Console.WriteLine(Kata.XO("xxxm"));
            Console.WriteLine(Kata.XO("Oo"));
            Console.WriteLine(Kata.XO("ooom"));
        }
    }
    
    public static class Kata 
    {
        public static bool XO (string input) => 
            input.ToLower().Count(c => c == 'x') == input.ToLower().Count(c => c == 'o');
    }
}