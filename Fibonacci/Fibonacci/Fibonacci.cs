using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class FibonacciFinder
    {
        public void FindNth(int a, int b, int x)
        {
            // if x is 2, we found what we are looking for since we started with the first 2 already
            if (x < 3)
            {
                // writes the targeted number to the console and return
                Console.WriteLine($"{b}.");
                return;
            }
            // find the next number in the sequence
            int c = a + b;
            // decrement our counter to get closer to the targeted number
            x--;
            // calls this function again to get the next number in the sequence
            FindNth(b, c, x);
            return;
        }
    }
}
