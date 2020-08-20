using System.Linq;

namespace PangramsDetecter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static bool IsPangram(string str) =>
            str.ToLower().GroupBy(c => c).Count(g => char.IsLetter(g.Key)) == 26;
    }
}