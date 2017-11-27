using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zero code
            Console.WriteLine("If an element in an MxN matrix is 0, its entire row and column are set to 0.");
            // change the M or N value to change the size of the matrix
            int M = 5;
            int N = 6;
            // creates a matrix using an iterator starting at 11 of size M x N as requested
            Zero zero = new Zero(M, N);

            Console.WriteLine("\nStarter: ");
            zero.Print();

            // Rotate code
            //Console.WriteLine("Given an NxN matrix write a method to rotate the image by 90 degrees.");
            //Console.WriteLine("Can you do this in-place ?                            You're welcome.");
            //// change the n value to change the size of the matrix
            //// Amy asked for a 50x50 but it doesn't print well.....
            //int n = 9;
            //// creates a matrix using an iterator starting at 11 of size n x n as requested
            //Rotate rotator = new Rotate(n);

            //Console.WriteLine("\nStarter: ");
            //rotator.Print();

            //Console.WriteLine("\nRotated: ");
            //rotator.Rotator();
            //rotator.Print();

            Console.Read();
        }
    }
}
