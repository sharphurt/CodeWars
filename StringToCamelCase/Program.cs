using System;
using System.Globalization;
using System.Linq;

namespace StringToCamelCase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.ToCamelCase("the_stealth_warrior"));
        }
    }

    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            var words = str.Split('-', '_');
            return words[0] + string.Join("", words.Skip(1).Select(w => new CultureInfo("en-US").TextInfo.ToTitleCase(w)));
        }
    }
}