namespace IsItATriangle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c) => a + b > c && a + c > b && b + c > a;
    }
}