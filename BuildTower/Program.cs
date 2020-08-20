using System;

namespace BuildTower
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var f = string.Join(",", Kata.TowerBuilder(3));
            var g = 4;
        }
    }

    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            var tower = new string[nFloors];
            var maxLength = 1 + (nFloors - 1) * 2;
            for (var i = 0; i < nFloors; i++)
                tower[i] = new string(' ', (maxLength - (1 + i * 2)) / 2) 
                           + new string('*', 1 + i * 2)
                           + new string(' ', (maxLength - (1 + i * 2)) / 2);
            return tower;
        }
    }
}