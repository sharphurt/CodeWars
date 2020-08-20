using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace SudokuSolutionValidator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sudoku.ValidateSolution(new int[][]
            {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            }));
        }
    }

    public class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            for (var x = 0; x < 3; x++)
            for (var y = 0; y < 3; y++)
            {
                if (GetSmallSquareElements(board, x, y).Sum() != 45
                    || GetColumnElements(board, x).Sum() != 45
                    || GetRowElements(board, y).Sum() != 45)
                    return false;
            }

            return true;
        }

        private static List<int> GetSmallSquareElements(int[][] board, int x, int y)
        {
            var result = new List<int>();
            for (var dx = 0; dx < 3; dx++)
            for (var dy = 0; dy < 3; dy++)
                result.Add(board[x * 3 + dx][y * 3 + dy]);
            return result;
        }

        private static List<int> GetRowElements(int[][] board, int y)
        {
            var result = new List<int>();
            for (var i = 0; i < 9; i++)
                result.Add(board[i][y]);
            return result;
        }
        
        private static List<int> GetColumnElements(int[][] board, int x)
        {
            var result = new List<int>();
            for (var i = 0; i < 9; i++)
                result.Add(board[x][i]);
            return result;
        }
    }
}