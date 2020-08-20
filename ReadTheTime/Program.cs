using System;
using System.Globalization;

namespace ReadTheTime
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public static string solve(string time)
        {
            var parsed = TimeSpan.Parse(time, new CultureInfo("en-US"));
            if (parsed.Minutes == 0)
                return
                    $"{Translate(ConvertHoursFormat(parsed.Hours))} {(ConvertHoursFormat(parsed.Hours) == 0 ? "" : "o'clock")}";
            if (parsed.Minutes <= 30)
            {
                if (parsed.Minutes % 30 == 0)
                    return $"half past {Translate(ConvertHoursFormat(parsed.Hours))}";
                return parsed.Minutes % 15 == 0
                    ? $"quarter past {Translate(ConvertHoursFormat(parsed.Hours))}"
                    : $"{Translate(parsed.Minutes)} {(parsed.Minutes == 1 ? "minute" : "minutes")} past {Translate(ConvertHoursFormat(parsed.Hours))}";
            }

            if (parsed.Minutes % 30 == 0)
                return $"half to {Translate(ConvertHoursFormat(parsed.Hours) + 1)}";
            return parsed.Minutes % 15 == 0
                ? $"quarter to {Translate(ConvertHoursFormat(parsed.Hours) + 1)}"
                : $"{Translate(60 - parsed.Minutes)} {(60 - parsed.Minutes == 1 ? "minute" : "minutes")} to {Translate(ConvertHoursFormat(parsed.Hours) + 1)}";
        }

        private static string Translate(int number)
        {
            var numberNames = new[]
            {
                "midnight", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
            };

            if (number > 29)
                return "";
            return number <= 20
                ? numberNames[number]
                : $"{numberNames[number - number % 10]} {numberNames[number % 10]}";
        }

        private static int ConvertHoursFormat(int hours)
        {
            if (hours == 23)
                return -1;
            return hours > 12 ? hours - 12 : hours;
        }
    }
}