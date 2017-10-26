using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class RadixSort
    {
        public int[] arr;

        public RadixSort(int[] newArray)
        {
            arr = newArray;
        }

        public int[] Sort()
        {
            int[] thisArray = arr;
            int digits = FindLength(thisArray);
     
            for(int i=0; i<digits; i++)
            {
                int p = 10;


            }
            Enqueue(thisArray);
            Dequeue();

            return thisArray;
        }

        private int[] Enqueue(int[] w)
        {
            int v = w.Length / 2;
            int[] newArray1 = new int[v];
            int[] newArray2 = new int[w.Length - v];

            for (int i = 0; i < v; i++)
                newArray1[i] = w[i];
            Console.WriteLine("\nUnsorted Array1: ");
            Print(newArray1);

            int u = 0;
            for (int i = v; i < w.Length; i++)
            {
                newArray2[u] = w[i];
                u++;
            }
            Console.WriteLine("\nUnsorted Array2: ");
            Print(newArray2);

            return w;
        }

        private int[] Dequeue(int[][] x)
        {
            int[] z = new int[arr.Length];
            return z;
        }

        private int FindLength(int [] counter) {
            int z = 0;
            foreach (int x in counter)
            {
                if (x.ToString().Length > z)
                    z = x.ToString().Length;
            }
            return z;
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
