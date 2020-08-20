using System;
using System.Linq;

namespace NameAbbreviature
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string AbbrevName(string name) => 
            string.Join(".", name.Split(' ').Select(w => char.ToUpper(w[0])));
    }
}