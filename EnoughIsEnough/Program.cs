using System.Collections.Generic;
using System.Linq;

namespace EnoughIsEnough
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();
            arr.ToList().ForEach(n => { if (result.Count(i => i == n) < x) result.Add(n); });
            return result.ToArray();
        }
    }
}