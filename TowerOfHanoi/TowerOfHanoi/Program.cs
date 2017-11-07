using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tower hanoi = new Tower(3);
            hanoi.Print();
            hanoi.Shift();

            Console.Read();
        }
    }
}
