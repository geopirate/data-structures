using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Rotate
    {
        int[,] matrix;
        int x = 0;
        int y;

        public Rotate(int n)
        {
            int k = 1;
            y = n - 1;
            matrix = new int[n,n];
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    matrix[i, j] = k;
                    k++;
                }
            }
        }

        public void Rotator()
        {
            int k = y;
       
            for(int i  = x; i < y; i++)
            {
                int temp = matrix[x, i];
                matrix[x, i] = matrix[k, x];
                matrix[k, x] = matrix[y, k];
                matrix[y, k] = matrix[i, y];
                matrix[i, y] = temp;
                k--;
            }
        }

        public void Print()
        {
            for(int d = 0; d <=y; d++)
            {
                for(int f = 0; f <=y; f++)
                {
                    Console.Write($"{matrix[d,f]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
