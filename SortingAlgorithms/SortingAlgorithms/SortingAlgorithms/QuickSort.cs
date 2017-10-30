using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public int[] Sort(int [] arr, int pointer, int pivot )
        {
            // makes a new array so we retain the original

            int lower = -1;

            while (pointer < arr.Length - 1)
            {
                if( arr[pointer] < pivot)
                {
                    lower++;
                    if (arr[lower] > arr[pointer])
                    {
                        int temp = arr[lower];
                        arr[lower] = arr[pointer];
                        arr[pointer] = temp;
                    }

                }
                pointer++;
                Console.WriteLine("\nIn Progress Array: ");
                Print(arr);
            }
            arr[arr.Length - 1] = arr[lower + 1];
            arr[lower + 1] = pivot;
            //Print(thisArray);

            //if ()

            //Console.WriteLine(pivot);
            return arr;
        }
        private int Partition(int pivot)
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
