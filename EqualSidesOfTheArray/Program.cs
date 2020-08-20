using System;
using System.Linq;

namespace EqualSidesOfTheArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindEvenIndex(new int[] {1,2,3,4,3,2,1}));
        }
    }
    
    public class Kata
    {
        public static int FindEvenIndex(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var a = arr.Take(i + 1).Sum();
                var b = arr.Skip(i).Sum();
                if (a == b)
                    return i;
            }

            return -1;
        }
    }
}