using System.Linq;

namespace PersistentBugger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Persist
    {
        public static int Persistence(long n)
        {
            var counter = 0;
            while (n > 9)
            {
                n = MultiplyDigits(n);
                counter++;
            }

            return counter + 1;
        }
        
        private static long MultiplyDigits(long n) =>
            n.ToString().Select(e => int.Parse(e.ToString())).Aggregate((a, b) => a * b);
    }
}