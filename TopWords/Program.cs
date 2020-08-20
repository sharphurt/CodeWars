using System;
using System.Collections.Generic;
using System.Linq;

namespace TopWords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var f = TopWords.Top3("a a a  b  c c  d d d d  e e e e e");
            var d = TopWords.Top3(
                string.Join("\n", new string[]
                {
                    "In a village of La Mancha, the name of which I have no desire to call to",
                    "mind, there lived not long since one of those gentlemen that keep a lance",
                    "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                    "coursing. An olla of rather more beef than mutton, a salad on most",
                    "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                    "on Sundays, made away with three-quarters of his income."
                }));
            var t = TopWords.Top3("  , 'e'   .. ");

            var j = 4;
        }
    }

    public class TopWords
    {
        public static List<string> Top3(string s)
        {
            var words = s.ToLower().Split(new[] {'.', ',', '!', '?', ';', ':', ')', '(', '/', '\\', ' '},
                StringSplitOptions.RemoveEmptyEntries);
            var cache = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!cache.ContainsKey(word))
                    cache[word] = 0;
                cache[word]++;
            }

            return cache.OrderByDescending(args => args.Value).Take(3).Select(a => a.Key).ToList();
        }
    }
}