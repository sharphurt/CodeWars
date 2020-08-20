using System.Collections.Generic;
using System.Linq;

namespace ThaRaulKata
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Raul
    {
        public static List<string>[] SeparateKeywords(string[] keywords)
        {
            var result = new [] { new List<string>(), new List<string>() };
            foreach (var word in keywords)
            {
                if (!KeywordDictionary.ContainsKey(word))
                    continue;
                if (KeywordDictionary[word] == "C#")
                    result[0].Add(word);
                else
                    result[1].Add(word);
            }

            result[0].Sort();
            result[1].Sort();
            return result;
        }

        public static Dictionary<string, string> KeywordDictionary = new Dictionary<string, string>
        {
            {"abstract", "C#"},
            {"as", "C#"},
            {"goal", "football"}
        };
    }
}