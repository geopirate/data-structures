using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    class LinkedList
    {
        public Node head = new Node(null);

        public Node FindTail()
        {
            Node current = head;

            while (current.Next != null)
            {
                current = current.Next;
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
                while (current.Next != null)
                {
                    current = current.Next;
                    Console.Write($"{current.Data} => ");
                }
            }
        }

        
    }
}
