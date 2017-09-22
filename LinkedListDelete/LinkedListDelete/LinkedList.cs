using System;

namespace LinkedListDelete
{
    class LinkedList
    {
        public Node head;
        public int count;
        public int middle;

        public LinkedList()
        {
            head = new Node(null);
        }

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
                Node current = head.Next;
                Console.WriteLine(current.Data);
                while (current.Next != null)
                {
                    current = current.Next;
                    Console.WriteLine(current.Data);
                }
            }
        }

        public void DeleteData(Object z)
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Data == z)
                    {
                        current.Next = current.Next.Next;
                        count--;
                        Console.WriteLine(z + " is deleted.");
                    }
                    current = current.Next;
                }
            }
        }

    }
}
