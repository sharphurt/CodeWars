using System;
using System.Collections.Generic;
using System.Linq;

namespace SayMePleaseOperations
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string sayMeOperations(string stringNumbers)
        {
            var operations = new Dictionary<string, Func<int, int, int>>
            {
                {"addition", (a, b) => a + b},
                {"subtraction", (a, b) => a - b},
                {"multiplication", (a, b) => a * b},
                {"division", (a, b) => a / b}
            };

            var result = new List<string>();
            var numbers = stringNumbers.Split(' ').Select(int.Parse).ToList();
            for (var i = 2; i < numbers.Count; i++)
                foreach (var operation in operations.Where(operation =>
                    numbers[i] == operation.Value(numbers[i - 2], numbers[i - 1])))
                {
                    result.Add(operation.Key);
                    break;
                }


            return string.Join(", ", result);
        }
    }
}