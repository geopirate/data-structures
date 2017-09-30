using System;

namespace StackQueue
{
    class Stack : LinkedList
    {
        // add
        public void Push(object thisData)
        {
            Node toPush = new Node(thisData)
            {
                Next = head
            };
            head = toPush;
        }
        // delete
        public void Pop()
        {
            Node current = head;

            if ( current.Next == null)
            {
                Console.WriteLine("Sorry the Queue is empty!");
            }
            else if (current.Next.Next == null)
            {
                current.Next = null;
            }
            else
            {
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }
    }
}
