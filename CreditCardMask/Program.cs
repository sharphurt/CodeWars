namespace CreditCardMask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        // return masked string
        public static string Maskify(string cc) =>
            cc.Length <= 4 ? cc : cc.Substring(cc.Length - 4, 4).PadLeft(cc.Length, '#');
    }
}