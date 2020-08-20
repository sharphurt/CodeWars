using System.Collections.Generic;
using System.Linq;

namespace NumberOfPeopleInTheBus
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(inout => inout[0] - inout[1]);
        }
    }
}