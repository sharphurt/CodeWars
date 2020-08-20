using System;
using System.Linq;

namespace AreArraysTheSame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    class AreTheySame
    {
        public static bool comp(int[] a, int[] b) =>
            a != null && b != null && b.OrderBy(e => e).SequenceEqual(a.Select(e => e * e).OrderBy(e => e));
    }
}