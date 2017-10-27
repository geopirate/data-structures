using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public int[] arr;

        public QuickSort(int[] newArray)
        {
            arr = newArray;
        }

        public int[] Sort()
        {
            // makes a new array so we retain the original
            int[] thisArray = arr;

            int pivot = thisArray[thisArray.Length-1];



            //Console.WriteLine(pivot);
            return thisArray;
        }
        private int Partition()
        {

            return pivot;
        }

        public void Print(int[] printedArray)
        {
            foreach (int x in printedArray)
            {
                Console.Write($" {x}");
            }
        }
    }
}
