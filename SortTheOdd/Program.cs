using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTheOdd
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //{ 1, 3, 2, 8, 5, 4 }
            var f = Kata.SortArray(new int[] {5, 3, 2, 8, 1, 4});
            var c = 0;
        }
    }

    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            var result = new List<int>();
            var sortedArr = array.OrderBy(e => e).Where(e => e % 2 != 0).ToList();
            foreach (var item in array)
            {
                if (item % 2 == 0)
                    result.Add(item);
                else
                {
                    result.Add(sortedArr.First());
                    sortedArr.RemoveAt(0);
                }
            }

            return result.ToArray();
        }
    }
}