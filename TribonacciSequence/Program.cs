using System;
using System.Linq;

namespace TribonacciSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var output = Xbonacci.Tribonacci(new double[] {1, 1, 1}, 10);
        }
    }

    public class Xbonacci
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return Array.Empty<double>();
            var sequence = signature.Concat(new double[n - 3]).ToArray();
            for (var i = 3; i < n; i++)
                sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
            return sequence;
        }
    }
}