using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public int[] Sort(int[] arr, int beginning, int end)
        {
            int pivot = Partition(arr, beginning, end);


            return arr;
        }
        private int Partition(int [] arr, int pointer, int end )
        {
            // makes a new array so we retain the original

            int lower = pointer -1;
            int pivot = arr[end];
            int thisLength = end - pointer;

            while (pointer < thisLength)
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
            return lower+1;
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
