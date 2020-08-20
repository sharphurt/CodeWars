using System.Globalization;

namespace CapitalizingEveryWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class JadenCase
    {
        public static string ToJadenCase(this string str) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
    }
}