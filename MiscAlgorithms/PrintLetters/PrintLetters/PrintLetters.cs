using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLetters
{
    class PrintLetters
    {
        // static string of all of the letters
        static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        // the array that will store our letters for the program
        char[] Letters;
        // the number of letters we are given
        int N;

        // constructor to create the array for manipulation
        public PrintLetters(int n)
        {
            N = n;
            // creats array of the length of the number given
            Letters = new char[N];
            // puts the corresponding letter in our new array for the affected letters
            for(int i = 0; i<n; i++)
            {
                Letters[i] = ALPHABET[i];
            }
        }

        public void Traversal()
        {
            for (int q = N-1; q > 0; q--)
            {
                Console.Write($"{new string(Letters)} ");

                for (int i = 0; i < q; i++)
                {
                    char temp = Letters[i];
                    Letters[i] = Letters[i + 1];
                    Letters[i + 1] = temp;
                    Console.Write($"{new string(Letters)} ");
                }
                Console.WriteLine();
            }
        }
    }
}
