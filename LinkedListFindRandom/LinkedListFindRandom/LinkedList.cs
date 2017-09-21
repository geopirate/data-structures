using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListFindRandom
{
    class LinkedList
    {
        public Node head;
        public int count;
        public int middle;

        public void Add(string newData)
        {
            Node toAdd = new Node(newData);

            if (head == null)
            {
                toAdd.Next = head;
                head = toAdd;
            }
            else
            {
                Node current = head;

                //Console.WriteLine(current.data);
                while (current.Next != null)
                {
                    current = current.Next;
                    //Console.WriteLine(current.data);
                }
                current.Next = toAdd;
            }
            count++;
            if (count % 2 == 1)
            {
                middle++;
            };

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

        public void PrintMiddle()
        {
            int listIndex = 1;
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
                Console.WriteLine($"The node {random.Data} is {x} from the end" );
            }
        }

        public void FindData(Object z)
        {
            int listIndex= 0;
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
                    if(current.Data == z)
                    { 
                        foundIndex = listIndex;
                    }
                    current = current.Next;
                    
                    listIndex++;
                }
                Console.WriteLine(z + " is at node " + listIndex + ".");
            }
        }

    }
}
