using System.Collections.Generic;
using System.Linq;

namespace FriendOrFoe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names) => names.Where(name => name.Length == 4);
    }
}