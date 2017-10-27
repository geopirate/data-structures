using System;
using System.Collections;
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
            // makes a new array so we retain the original
            int[] thisArray = arr;
            // gets the number of digits so we can determine how many rounds to queue
            int digits = FindLength(thisArray);
            // this number helps us get the target digit
            int p = 1;
            // for each digit we do a round of enque and dequeue
            for (int i=0; i<digits; i++)
            {
                // sends the array to put in an array of queues and then dequeues all of them into another array
                thisArray = Dequeue(Enqueue(thisArray, p));
                // this number increases each time to target the appropriate digit
                p = p*10;
            }
            // returns the sorted array after we are done.
            return thisArray;
        }
        // separates the elements into an array of 10 queues according to the target digit
        // it accepts the array we are sorting from and the p value used to target the correct digit
        private Queue<int>[] Enqueue(int[] arrrayToBreak, int p)
        {
            // this initializes an empty array of 10 queues to store our different elements
            Queue<int>[] buckets = new Queue<int>[10];
            for (int i = 0; i < buckets.Length; i++)
                buckets[i] = new Queue<int>();
            // for every integer in the supplied array, adde it to the appropriate queue
            foreach(int currentNumber in arrrayToBreak)
            {
                // dividing by 1/10/100 then getting the mod value returns the digit from the ones/tens/hundreds places respectively
                int targetedDigit = currentNumber/p % 10;
                // add the number to the queue that corresponds to the targeted digit
                buckets[targetedDigit].Enqueue(currentNumber);
            }
            return buckets;
        }
        // takes an array of queues and puts them into a new array
        private int[] Dequeue(Queue<int>[] buckets)
        {
            // new array is the length of the original array
            int[] z = new int[arr.Length];
            // this keeps track of our place in our new array as we switch buckets
            int zIndex = 0;
            // empty each bucket into our new array
            foreach (Queue<int> thisBucket in buckets)
            {
                // this loops through the buckets that have stuff until they are empty
                while (thisBucket.Count != 0)
                {
                    // dequeues the bucket into our new array
                    z[zIndex] = thisBucket.Dequeue();
                    // increments the counter for the new array
                    zIndex++;
                }
            }
            // return the new array containing all of the empty buckets
            return z;
        }
        // converts the integer to a string then counts the length of that string to get the number of digits
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
