using System;
using System.Linq;

namespace RepeatString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        
        public static string repeatStr(int n, string s) => string.Concat(Enumerable.Repeat(s, n));
    }
}