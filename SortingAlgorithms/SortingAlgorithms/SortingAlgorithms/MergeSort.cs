using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class MergeSort
    {
        public int[] arr;

        public MergeSort(int[] newArray)
        {
            arr = newArray;
        }

        public int[] Sort()
        {
            int [] thisArray = arr;

            DivideDrop(thisArray);

            return thisArray;
        }

        private int[] DivideDrop(int[] w)
        {
            int v = w.Length / 2;
            int[] newArray1 = new int[v];
            int[] newArray2 = new int[w.Length-v];

            for(int i=0; i<v; i++)
                newArray1[i] = w[i];
            Console.WriteLine("\nUnsorted Array1: ");
            Print(newArray1);

            int u = 0;
            for(int i = v; i < w.Length; i++)
            {
                newArray2[u] = w[i];
                u++;
            }
            Console.WriteLine("\nUnsorted Array2: ");
            Print(newArray2);

            return w;
        }

        private int[] Merge(int[]x, int[] y)
        {
            int[] z = new int[x.Length + y.Length];
            int zIndex = 0;
            int i = 0;
            int k = 0;

            for (i = 0; i < x.Length; i++)
            {
                for(k=0; k<y.Length; k++)
                {
                    if(y[k] < x[i])
                    {
                        z[zIndex] = y[k];
                        zIndex++;
                    } else
                    {
                        z[zIndex] = x[i];
                        zIndex++;
                    }
                }

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
