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
        public Zero(int M, int N)
        {
            int k = 11;
            m = M - 1;
            n = N - 1;

            matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = k;
                    k++;
                }
            }
        }

        public void SetZero(int down, int across)
        {
            matrix[across, down] = 0;
            return;
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
