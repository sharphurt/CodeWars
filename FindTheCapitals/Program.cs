using System.Linq;

namespace FindTheCapitals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static int[] Capitals(string word) =>
            word.Select((c, i) => new {c, i}).Where(g => char.IsUpper(g.c)).Select(g => g.i).ToArray();
    }
}