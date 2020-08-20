using System;
using System.Linq;

namespace MorseDecoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MorseCodeDecoder.Decode("···· · −·−−   ·−−− ··−"));
        }
    }
    
    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            return string.Join(" ", morseCode
                .Trim(' ')
                .Split(new[] {"   "}, StringSplitOptions.None)
                .Select(seq => string.Concat(seq.Split(' ').Select(MorseCode.Get).ToArray())));
        }
    }

    class MorseCode
    {
        public static char Get(string code)
        {
            return 'f';
        } 
    }
}