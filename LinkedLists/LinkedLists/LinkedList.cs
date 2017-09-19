using System;

namespace LinkedLists
{
    class LinkedList
    {
        public Node head;

        public void Add(string newData)
        {
            Node toAdd = new Node
            {
                data = newData
            };
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
    }
}