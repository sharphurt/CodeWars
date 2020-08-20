namespace GetTheMiddle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static string GetMiddle(string s) =>
            s.Length % 2 != 0 ? s[s.Length / 2].ToString() : s.Substring(s.Length / 2 - 1, 2);
    }
}