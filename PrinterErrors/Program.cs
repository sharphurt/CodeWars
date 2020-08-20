using System;
using System.Linq;

namespace PrinterErrors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    
    public class Printer 
    {
        public static string PrinterError(String s) => $"{s.Count(c => c > 'm' || c < 'a')}/{s.Length}";
    }
}