using System;

namespace RGBToHex
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.Rgb(-34, 215, 258));
            Console.WriteLine(Kata.Rgb(-34, 215, 258));

        }
    }

    public class Kata
    {
        public static string Rgb(int r, int g, int b) =>
            $"{(r < 0 ? 0 : r > 255 ? 255 : r):X2}" +
            $"{(g < 0 ? 0 : g > 255 ? 255 : g):X2}" +
            $"{(b < 0 ? 0 : b > 255 ? 255 : b):X2}";
    }
}