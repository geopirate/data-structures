using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = new Node(null);
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                Console.WriteLine(current.Data);
                while (current.Next != null)
                {
                    current = current.Next;
                    Console.WriteLine(current.Data);
                }
            }
        }

        // add to end
        public void Append(string newData)
        {
            Node toAdd = new Node(newData);
            Node current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = toAdd;
            toAdd.Previous = current;
        }

        // delete
        public void DeleteData(Object z)
        {
            Node current = head;

            while (current.Next != null)
            {
                
                if (current.Next.Data == z)
                {
                    // deletes the last node
                    if (current.Next.Next == null)
                    {
                        current.Next.Previous = null;
                        current.Next = null;
                    } // deletes anything else
                    else
                    {
                        current.Next.Next.Previous = current;
                        current.Next = current.Next.Next;
                    }
                    //Console.WriteLine(z + " is deleted.");
                    return;
                }
                current = current.Next;
            }
        }
    }
}
