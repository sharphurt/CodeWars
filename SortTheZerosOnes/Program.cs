using System.Linq;

namespace SortTheZerosOnes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Account
    {
        public static string BinarySort(string s1) => string.Concat(s1.Where(c => c == '0' || c == '1').OrderBy(c => c));
    }
}