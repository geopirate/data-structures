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

        // insert

        // delete
        public void DeleteData(Object z)
        {
            Node current = head;

            while (current.Next != null)
            {
                
                if (current.Next.Data == z)
                {
                    if (current.Next.Next == null)
                    {
                        current.Next = current.Next.Next;
                    }

                    else if (current.Next.Next == null)
                    {
                        current.Next = current.Next.Next;
                    }
                    else
                    {
                        
                    }
                    
                    current.Next.Next.Previous = current;
                    //Console.WriteLine(z + " is deleted.");
                    return;
                }
                current = current.Next;
            }
        }
        /*
        public void PrintMiddle()
        {
            /*int listIndex = 1;
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Node current = head;
                while (listIndex < middle)
                {
                    current = current.Next;
                    listIndex++;
                }
                Console.WriteLine(current.Data);
            }
        }

        // find the data of the node x from the end
        public void PrintRandom(int x)
        {
            int listIndex = 0;
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Node current = head;
                Node random = head;
                while (current.Next != null)
                {
                    current = current.Next;
                    listIndex++;
                    if (listIndex > x)
                    {
                        random = random.Next;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"The node {random.Data} is {x} from the end");
            }
        }

        public void FindData(Object z)
        {
            int listIndex = 0;
            int foundIndex;
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    if (current.Data == z)
                    {
                        foundIndex = listIndex;
                    }
                    current = current.Next;

                    listIndex++;
                }
                Console.WriteLine(z + " is at node " + listIndex + ".");
            }
        }*/

    }
}
