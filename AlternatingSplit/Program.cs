using System.Linq;

namespace AlternatingSplit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string Encrypt(string text, int n)
        {
            for (var index = 0; index < n; index++)
                text = string.Concat(
                    text.Select((c, i) => new {c, i}).Where(g => g.i % 2 == 0).Select(g => g.c),
                    text.Select((c, i) => new {c, i}).Where(g => g.i % 2 == 1).Select(g => g.c)
                );

            return text;
        }
    }
}