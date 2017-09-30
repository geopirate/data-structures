using System;

namespace StackSort
{
    class Stack
    {
        Node Head;
        Node Tail;

        public Stack()
        {
            Head = new Node(0);
            Tail = new Node(0);

            Head.Next = Tail;
            Tail.Previous = Head;
        }

        public void Push(int newData)
        {
            Node newNode = new Node(newData); 
            Node current = Sort(newData);

            newNode.Next = current;
            newNode.Previous = current.Previous;
            current.Previous.Next = newNode;
            current.Previous = newNode;

        }

        public void Pop()
        {
            Head.Next.Next.Previous = Head;
            Head.Next = Head.Next.Next;
        }

        public Node Sort(int data)
        {
            Node current = Head.Next;
            if(current == null)
            {
                return Tail;
            }

            while (data > current.Data)
            {
                if(current.Data == 0)
                {
                    return Tail;
                }
                current = current.Next;
            }
            return current;
        }

        public void Print()
        {
            if (Head.Next == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = Head;
                while (current.Next.Data != 0)
                {
                    current = current.Next;
                    Console.Write($"{ current.Data} => ");
                }
                Console.WriteLine();
            }
        }
    }
}
