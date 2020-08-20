namespace DisemvovelTrolls
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static string Disemvowel(string str) => string.Concat(str.Split("aeiouAEIOU".ToCharArray()));
    }
}