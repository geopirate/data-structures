using System;

namespace StackQueue
{
    class Queue : LinkedList
    {
        // add
        public void Enqueue(object thisData)
        {
            FindTail().Next = new Node(thisData);
        }

        // delete
        public void Dequeue()
        {
            if (head.Next == null)
            {
                Console.WriteLine("Sorry the Queue is empty!");
            }
            else
            {
                head.Next = head.Next.Next;
            }
        }
    }
}
