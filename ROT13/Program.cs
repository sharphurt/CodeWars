using System.Linq;

namespace ROT13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string Rot13(string message) => string.Concat(message.Select(c => (char) (c + 13)));
    }
}