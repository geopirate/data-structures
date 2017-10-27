using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // InsertionSort mySorter = new InsertionSort(new int[]{ 7, 11, 3, 42, 9, 12 });
            // MergeSort mySorter = new MergeSort(new int[]{ 7, 11, 3, 42, 9, 12, 2, 5, 15 });
            RadixSort mySorter = new RadixSort(new int[] {411, 7, 11, 3, 42, 9, 12, 2, 5, 15, 155, 334  });

            Console.WriteLine("\nUnsorted Array: ");
            mySorter.Print(mySorter.arr);
            Console.WriteLine("\nsorted Array: ");
            mySorter.Print(mySorter.Sort());

            Console.Read();
        }
    }
}
