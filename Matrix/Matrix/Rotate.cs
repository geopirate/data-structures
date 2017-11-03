using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Rotate
    {
        // the matrix to be rotated
        int[,] matrix;
        // keeping track of the last index based on n
        static int lastIndex;

        // constructor that creates the matrix for rotation
        public Rotate(int n)
        {
            int k = 11;
            lastIndex = n - 1;
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
            // x is the lower bounds of the current round of rotation
            int x = 0;
            // y is the upper bounds of the current round of rotation
            int y = lastIndex;

            // l keeps track of how many rounds of rotation are needed
            for (int l = 0; l < lastIndex / 2; l++)
            {
                // k is the upper bounds of the current digit of rotation
                int k = y;
                // i is the lower bounds of the current digit of rotation
                for (int i = x; i < y; i++)
                {
                    // store top left in a temp variable
                    int temp = matrix[x, i];
                    // replace top left with bottom left
                    matrix[x, i] = matrix[k, x];
                    // replace bottom left with bottom right
                    matrix[k, x] = matrix[y, k];
                    // replace bottom right with top right
                    matrix[y, k] = matrix[i, y];
                    // replace top right with the temp we saved from top left initially
                    matrix[i, y] = temp;
                    // decrementing this and incrementing i moves over to the next digit
                    k--;
                }
                // these move us a row deeper into the matrix
                x++;
                y--;
            }
        }

        public void Print()
        {
            for(int d = 0; d <= lastIndex; d++)
            {
                for(int f = 0; f <= lastIndex; f++)
                {
                    Console.Write($"{matrix[d,f]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
