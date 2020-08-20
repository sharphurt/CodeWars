using System;
using System.Linq;

namespace TenMinuteWalk
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}));
            Console.WriteLine(Kata.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}));
            Console.WriteLine(Kata.IsValidWalk(new string[] {"w"}));
            Console.WriteLine(Kata.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"}));

        }
    }
    
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            var balances = new int[2];
            foreach (var dir in walk)
            {
                if (dir == "n") balances[0]++;
                if (dir == "s") balances[0]--;
                if (dir == "w") balances[1]++;
                if (dir == "e") balances[1]--;
            }

            return balances[0] == 0 && balances[1] == 0 && walk.Length == 10;
        }
    }
}