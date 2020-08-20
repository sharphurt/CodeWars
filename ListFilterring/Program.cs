using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ListFilterring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.OfType<int>();
    }
}