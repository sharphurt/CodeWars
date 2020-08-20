using System;

namespace TimeFormat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds) =>
            $"{seconds / 3600 :00}:{TimeSpan.FromSeconds(seconds).Minutes:00}:{TimeSpan.FromSeconds(seconds).Seconds:00}";
    }
}