namespace Int32ToIPv4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static string UInt32ToIP(uint ip) => $"{ip >> 24}.{(ip & 0xFF0000) >> 16}.{(ip & 0xFF00) >> 8}.{ip & 0xFF}";
    }
}