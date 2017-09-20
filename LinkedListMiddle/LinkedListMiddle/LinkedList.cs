using System;

namespace LinkedListMiddle
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
            if (count % 2 == 1) {
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
                while(listIndex < middle)
                {
                    current = current.next;
                    listIndex++;
                }
                Console.WriteLine(current.data);
            }
        }

    }
}