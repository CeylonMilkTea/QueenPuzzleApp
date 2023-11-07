using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenPuzzleLibrary
{
    public class CalculateQueenPuzzle
    {
        int[] queenPosition;
        List<int[]> result = new List<int[]>();
        public  CalculateQueenPuzzle(int size)
        {
            queenPosition = new int[size];
        }
        public List<int[]> Result()
        {
            StartSolve(0);
            return result;
        }

        private void StartSolve(int row)
        {
            for (int i = 0; i < queenPosition.Length; i++)
            {
                if (IsValide(row, i))
                {
                    queenPosition[row] = i;
                    if (row == queenPosition.Length - 1)
                    {
                        result.Add(queenPosition.ToArray());
                    }
                    else
                    {
                        StartSolve(row + 1);
                    }
                }
            }
        }

        private bool IsValide(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (queenPosition[i] == col || row - i == Math.Abs(queenPosition[i] - col)) // pos repeat || two pos slope is 1
                {
                    return false;
                }
            }
            return true;
        }
    }
}
