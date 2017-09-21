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
                toAdd.next = head;
                head = toAdd;
            }
            else
            {
                Node current = head;

                //Console.WriteLine(current.data);
                while (current.next != null)
                {
                    current = current.next;
                    //Console.WriteLine(current.data);
                }
                current.next = toAdd;
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
                Console.WriteLine(current.data);
                while (current.next != null)
                {
                    current = current.next;
                    Console.WriteLine(current.data);
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
                    current = current.next;
                    listIndex++;
                }
                Console.WriteLine(current.data);
            }
        }

        public void PrintRandom(int x)
        {
            int listIndex = 0;/*
            if (x == -1 || x > count)
            {
                Console.WriteLine("Did not find the integer");
            }*/
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Node current = head;
                Node random = head;
                while (current.next != null)
                {
                    current = current.next;
                    //Console.Write("Current is " + current.data);
                    //Console.WriteLine(" random is " + random.data);

                    listIndex++;
                    if(listIndex > x)
                    {
                        random = random.next;
                    }
                }
                Console.Write(random.data);
            }
        }

        public int FindData(Object z)
        {
            int listIndex = 0;
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                Console.WriteLine(current.data);
                while (current.next != null)
                {
                    current = current.next;
                    if(current.data == z)
                    {
                        return listIndex;
                    }
                    Console.WriteLine(current.data + " is the node at " + z + " from the end.");
                    listIndex++;
                }
            }
            return -1;
        }

    }
}
