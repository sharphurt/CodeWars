using System.Collections.Generic;
using System.Linq;

namespace FindUnique
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers) => numbers.GroupBy(n => n).First(g => g.Count() == 1).Key;
    }
}