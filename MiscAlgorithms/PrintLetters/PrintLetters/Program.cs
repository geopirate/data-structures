using System;

namespace PrintLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n = 3;
            PrintLetters MyLetters = new PrintLetters(n);
            MyLetters.Traversal();

            Console.Read();
        }
    }
}
