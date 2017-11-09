using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLetters
{
    class PrintLetters
    {
        static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] Letters;
        int N;
        int P = 0;

        public PrintLetters(int n)
        {
            N = n;
            Letters = new char[N];
            foreach(char x in Letters)
            {
                Letters[x] = ALPHABET[x];
            }
        }

        private void Traversal()
        {

        }

        public void Print()
        {

        }
    }
}
