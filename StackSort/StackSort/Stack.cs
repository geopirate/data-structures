using System;

namespace StackSort
{
    class Stack
    {
        Node Head;
        Node Tail;

        public Stack()
        {
            Head = null;
            Tail = null;
        }

        public Node Pop()
        {
            Node current = Head;

            if (current == null)
            { // empty stack
                return null;
            } // one left in stack
            else if (current.Next == null)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = current.Next;
                current.Next = null;
            }
            return current;
        }

        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            Node Current = Head;
            // if stack is empty
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            } // if stack only has one item
            else if (Head.Next == null)
            { // if new is smaller
                if (newData < Head.Data)
                {
                    Head = newNode;
                    newNode.Next = Current;
                    Current.Previous = newNode;
                    return;
                } // if new is bigger
                else
                {
                    Tail = newNode;
                    newNode.Previous = Current;
                    Current.Next = newNode;
                    return;
                }
            }
            // we have at least 2 nodes, so we sort
            // if new is the smallest make it the new head
            if(newData <= Head.Data)
            {
                Head.Previous = newNode;
                newNode.Next = Head;
                Head = newNode;
                return;
            }// if new is the biggest make it the new tail
            if (newData >= Tail.Data)
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
                return;
            }// otherwise find where to insert it
            while (Current != Tail)
            {
                if(newData < Current.Data)
                {
                    newNode.Next = Current;
                    newNode.Previous = Current.Previous;
                    Current.Previous.Next = newNode;
                    Current.Previous = newNode;
                    return;
                }
               Current = Current.Next;
            }
        }
        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Node current = Head;
                while (current != null)
                {
                    Console.Write($"{ current.Data} => ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
/* The sorting works, but the initial head and tail nodes which are initialized with a zero value are unnecessary. 
 * The head and tail should be initialized to null and set when a value is pushed into the stack. 
 * Currently, the head and the tail are disconnected. 
 */