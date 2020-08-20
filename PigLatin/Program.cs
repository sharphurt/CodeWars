using System.Linq;

namespace PigLatin
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string PigIt(string str)
        {
            return string.Join(" ", 
                str.Split(' ').Select(w => (w + w[0]).Remove(0, 1) + "ay"));
        }
    }
}