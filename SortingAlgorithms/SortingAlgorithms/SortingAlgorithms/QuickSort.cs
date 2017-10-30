using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class QuickSort
    {
        // both methods take an array, the begging and ending indexes of what we are sorting
        // the sort method sets up the recursion of the Partition method that does the actual work
        public int[] Sort(int[] arr, int beginning, int end)
        {
            // if the beginning is more than the end, the recurion ends
            if (beginning < end)
            {
                // calls the Partition method that quick sorts the arrays and returns the new pivot, which has the values below to the left and values above to the right
                int pivot = Partition(arr, beginning, end);
                // recursive call to this sort method on the left side of the pivot
                Sort(arr, beginning, pivot - 1);
                // recursive call to this sort method on the right side of the pivot
                Sort(arr, pivot + 1, end);
            }
            // returns the sorted array after this is all done
            return arr;
        }
        // the Partition method goes through the array and puts the values less than the pivot at the front of the selected portion of the array
        private int Partition(int [] arr, int pointer, int end )
        {
            // the lower variable tracks the point in the array where we know the values are less than the pivot
            int lower = pointer -1;
            // the pivot variable is the last one in the array which we are choosing as our pivot
            int pivot = arr[end];

            // the pointer continues until it gets to the end of the array where the pivot value is
            while (pointer < end)
            {
                // if the value at the pointer is less than the pivot we want to try to swap
                // values that are the same we skip
                if( arr[pointer] < pivot)
                {
                    // since we found a value that is less, we increase the size of the known smaller values
                    lower++;
                    // if the value at lower is more we need to actually swap
                    // if it isn't more, we can just keep going
                    if (arr[lower] > arr[pointer])
                    {
                        // puts the last value of our lower array in a temp variable
                        int temp = arr[lower];
                        // puts the new smaller variable we found in our lower array
                        arr[lower] = arr[pointer];
                        // puts the value from temp at the pointer to replace the new lower value we found
                        arr[pointer] = temp;
                    }
                }
                // move the pointer on to the next number, regardless of what we found
                pointer++;
            }
            // we reached the end of our search, so we swap the pivot from the end of our search to the end of our lower values
            arr[end] = arr[lower + 1];
            arr[lower + 1] = pivot;
            // return the new pivot of our array after this pass of quick sorting
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
