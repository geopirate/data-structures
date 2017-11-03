using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rotate rotator = new Rotate(5);

            Console.WriteLine("Starter: ");
            rotator.Print();
            Console.WriteLine("\nRotated: ");
            rotator.Rotator();
            rotator.Print();


            Console.Read();
        }
    }
}
