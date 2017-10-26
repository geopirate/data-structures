using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        public int[] arr;

        public InsertionSort(int[] newArray)
        {
            arr = newArray;
        }

        public int[] Sort()
        {
            int [] thisArray = arr;

            for(int i = 0; i < thisArray.Length-1; i++)
            {
                for (int k = i + 1; k > 0; k--)
                {
                    if(thisArray[k] < thisArray[k - 1])
                    {
                        int temp = thisArray[k - 1];
                        thisArray[k-1] = thisArray[k];
                        thisArray[k] = temp;
                    }
                }
            }
            return thisArray;
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
