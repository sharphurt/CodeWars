using System;

namespace GrowthOfAPopulation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Arge.NbYear(1500, 5, 100, 5000));
        }
    }
    
    class Arge {
    
        public static int NbYear(int p0, double percent, int aug, int p) {
            var population = p0;
            int counter;
            for (counter = 0; population < p; counter++)
                population += (int)(population * (percent * 0.01)) + aug;
            return counter;
        }
    }
}