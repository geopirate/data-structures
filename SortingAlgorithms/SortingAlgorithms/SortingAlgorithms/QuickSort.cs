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
            int lower = -1;
            int pointer = 0;

            while (pointer < thisArray.Length - 1)
            {
                if( thisArray[pointer] < pivot)
                {
                    lower++;
                    if (thisArray[lower] > thisArray[pointer])
                    {
                        int temp = thisArray[lower];
                        thisArray[lower] = thisArray[pointer];
                        thisArray[pointer] = temp;
                    }

                }
                pointer++;
                Console.WriteLine("\nIn Progress Array: ");
                Print(thisArray);
            }
            thisArray[thisArray.Length - 1] = thisArray[lower + 1];
            thisArray[lower + 1] = pivot;
            //Print(thisArray);

            //if ()

            //Console.WriteLine(pivot);
            return thisArray;
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
