using System.Linq;

namespace IQTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class IQ
    {
        public static int Test(string numbers)
        {
            var nums = numbers.Split(' ').Select(int.Parse).Select((n, i) => new {i, n});
            return nums.Where(n => n.n % 2 == 0 != nums.Count(a => a.n % 2 == 0) > 1).Select(n => n.i + 1).First();
        }
    }
}