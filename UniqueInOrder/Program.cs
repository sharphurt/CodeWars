using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueInOrder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Kata.UniqueInOrder("AAAABBBCcCDAABBB").ToArray()));
        }
    }
    
    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var stack = new Stack<T>();
            foreach (var element in iterable)
                if (stack.Count == 0 || !stack.Peek().Equals(element))
                    stack.Push(element);
            return stack.Reverse();
        }
    }
}