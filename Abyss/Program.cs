using System.Globalization;
using System.Linq;

namespace Abyss
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class Abyss
    {
        public static Gate Sort(string queue)
        {
            var onesCount = queue.ToCharArray().Select(c => int.Parse(c.ToString())).Sum();
            return new Gate(queue.PadLeft(onesCount, '1'), queue.PadLeft(queue.Length - onesCount, '0'));
        }
    }

    public struct Gate
    {
        public string Left;
        public string Right;

        public Gate(string left, string right)
        {
            Left = left;
            Right = right;
        }
    }
}