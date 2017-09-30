using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public class DoubleList
    {
        Node Head; 
        Node Tail;

        public DoubleList()
        {
            Head = new Node(null);
            Tail = new Node(null);
            Head.next = Tail;
            Tail.previous = Head;
        }
        
        public void Add(char thisData)
        {
            Node newNode = new Node(thisData);
            newNode.next = Tail;

            newNode.previous = Tail.previous;
            Tail.previous.next = newNode;
            Tail.previous = newNode;
            newNode.next = Tail;
        }

        public void Converter(string thing)
        {
            char[] thing2 = thing.ToCharArray();
            foreach (char n in thing2)
            {
                this.Add(n);
            }
        }

        public bool Check()
        {
            Node Forward = Head;
            Node Backwards = Tail;

            while (Forward.next != Backwards && Forward.next != Backwards.previous)
            {
                if (!Forward.next.data.Equals(Backwards.previous.data))
                {
                    return false;
                }
                Forward = Forward.next;
                Backwards = Backwards.previous;
            }
            return true;
        }

        public void CheckText(bool isa)
        {
            if (isa)
            {
                Console.WriteLine($" is a palindrome.\n");
            }
            else
            {
                Console.WriteLine($" is not a palindrome.\n");
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current.next != Tail)
            {
                current = current.next;
                Console.Write($"{ current.data} ");
            }
        }
    }
}
