using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace FindDividors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kata.Divisors(12002013);
            var stopwatch = new Stopwatch();
            stopwatch.Restart();
            var result = Kata.Divisors(234565432);
            stopwatch.Stop();
            var output = String.Join(", ", result);
            Console.WriteLine(output);
            Console.WriteLine($"Elapsed {stopwatch.ElapsedMilliseconds} ms.");
        }
    }

    public class Kata
    {
        public static int[] Divisors(int n) => Enumerable.Range(1, n).Where(i => n % i == 0).ToArray();

        public static void PrintAnnotatedMethods() =>
            GetAnnotatedMethods().ToList().ForEach(m => Console.WriteLine(m.Name));
        
        private static IEnumerable<MethodInfo> GetAnnotatedMethods() =>
            typeof(Test).GetMethods().Where(m => m.GetCustomAttributes(false).Any(a => a is MyAttribute));
    }

    public class Test
    {
        [MyAttribute]
        public static void MethodWithAttribute1()
        {
        }


        [MyAttribute]
        public static void MethodWithAttribute2()
        {
        }

        [MyAttribute]
        public static void MethodWithAttribute3()
        {
        }

        public static void MethodNoAttribute1()
        {
        }

        public static void MethodNoAttribute2()
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyAttribute : Attribute
    {
    }
}