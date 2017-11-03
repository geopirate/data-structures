using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an NxN matrix write a method to rotate the image by 90 degrees.");
            Console.WriteLine("Can you do this in-place ?                            You're welcome.");
            // change the n value to change the size of the matrix
            // Amy asked for a 50x50 but it doesn't print well.....
            int n = 9;
            // creates a matrix using an iterator starting at 11 of size n x n as requested
            Rotate rotator = new Rotate(n);

            Console.WriteLine("\nStarter: ");
            rotator.Print();

            Console.WriteLine("\nRotated: ");
            rotator.Rotator();
            rotator.Print();

            Console.Read();
        }
    }
}
