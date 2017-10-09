using System;

namespace StackQueue
{
    class LinkedList
    {
        public Node head = new Node(null);

        public LinkedList()
        {
            head = null;
        }

        public Node Delete()
        {
            Node current = head;

            if (current == null)
            { // empty stack
                return new Node("Nothing left!");
            } // one left in stack
            else if (current.Next == null)
            {
                head = null;
            }
            else
            {
                head = current.Next;
                current.Next = null;
            }
            return current;
        }

        public void PrintList()
        {
            if( head == null)
            {
                Console.WriteLine("This is empty!");
            }
            else
            {
                Node current = head;
                while (current != null)
                {
                    
                    Console.Write($"{current.Data} => ");
                    current = current.Next;
                }
            }
        } 
    }
}
