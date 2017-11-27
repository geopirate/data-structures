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

        // constructor that creates the matrix to all 7s
        public Zero(int M, int N)
        {
            m = M - 1;
            n = N - 1;

            matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = 7;
                }
            }
        }

        public void ZeroOut() {
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (matrix[i, j] == 0) {
                        for (int ii = 0; ii <= m; ii++)
                        {
                            matrix[ii, j] = 0;
                        }
                        for (int jj = 0; jj <= n; jj++)
                        {
                            matrix[i, jj] = 0;
                        }
                        return;
                    }
                }
            }
        }

        public void SetZero(int down, int across)
        {
            matrix[down, across] = 0;

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
