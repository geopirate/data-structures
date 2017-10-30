using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // InsertionSort mySorter = new InsertionSort(new int[]{ 7, 11, 3, 42, 9, 12 });
            // MergeSort mySorter = new MergeSort(new int[]{ 7, 11, 3, 42, 9, 12, 2, 5, 15 });
            // RadixSort mySorter = new RadixSort(new int[] {411, 7, 11, 3, 42, 9, 12, 2, 5, 15, 155, 334  });
            QuickSort mySorter = new QuickSort();
            int[] quickArray = new int[] { 28, 40, 16, 13, 41, 5, 39, 11, 22 };
            Console.WriteLine("\nUnsorted Array: ");
            mySorter.Print(quickArray);
            Console.WriteLine("\nsorted Array: ");
            mySorter.Print(mySorter.Sort(quickArray, 0, quickArray.Length - 1));

            Console.Read();
        }
    }
}
