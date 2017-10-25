using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort mySorter = new Sort(new int[]{ 7, 11, 3, 42, 9, 12 });

            Console.WriteLine("Unsorted Array: ");
            foreach(int x in mySorter.arr)
            {
                Console.Write($" {x}");
            }

           Console.WriteLine("\nInsertion sorted Array: ");
            foreach (int x in mySorter.InsertionSort())
            {
                Console.Write($" {x}");
            }

            Console.Read();
        }
    }
}
