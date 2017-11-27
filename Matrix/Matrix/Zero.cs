using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Zero
    {
        // the matrix to be rotated
        int[,] matrix;
        // keeping track of the last index based on n
        static int m;
        static int n;

        // constructor that creates the matrix to zero
        public Zero(int[,] mat)
        {
            matrix = mat;
            n = matrix.GetLength(0);
            m = matrix.GetLength(1);
        }

        public void Print()
        {
            for (int d = 0; d <= m; d++)
            {
                for (int f = 0; f <= n; f++)
                {
                    Console.Write($"{matrix[d, f]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
