using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // change this to find a different number
            int n = 4;

            FibonacciFinder fib = new FibonacciFinder();
            Console.Write($"The {n}th Fibonacci number is ");
            fib.FindNth(0, 1, n);


            Console.Read();
        }
    }
}
