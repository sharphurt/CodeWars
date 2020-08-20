using System;
using System.Linq;

namespace YourOrderPlease
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
                return "";
            return string.Join(" ", 
                words.Split(' ').OrderBy(word => word.ToList().Find(char.IsDigit)));
        }
    }
}