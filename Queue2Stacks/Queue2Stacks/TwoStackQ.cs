using System;

namespace Queue2Stacks
{
    class TwoStackQ
    { // Two is the front of the Queue and 1 is the back
        public Stack One = new Stack();
        public Stack Two = new Stack();

        public void Queue(object newData)
        {
            Console.Write("\nEnqueue");
            One.Push(newData);
        }
        public void Dequeue()
        {
            if (Two.Head == null || Two.Head.Next == null)
            {
                while (One.Head != null)
                {
                    Two.Push(One.Pop(true));
                }
                if(Two.Head == null)
                {
                    Console.WriteLine("All empty!");
                    return;
                }
            }
            Console.Write("\nDequeue");
            Two.Pop();
        }
        // printing is harder than solving the actual problem!
        public void Print()
        {
            Console.Write("\nQueue : ");
            PrintTail();
            PrintHead();
        }
        // one
        public void PrintTail()
        {
            if (One.Head == null)
            {
                return;
            }
            Node curr1 = One.Head;
            Console.Write($"{curr1.Data} => ");
            while (curr1.Next != null)
            {
                curr1 = curr1.Next;
                Console.Write($"{curr1.Data} => ");
            }
        }
        // two
        public void PrintHead()
        {
            if (Two.Head == null)
            {
                return;
            }
            Node curr2 = Two.Head;
            Console.Write($"{curr2.Data} => ");
            while (curr2.Next != null)
            {
                curr2 = curr2.Next;
                Console.Write($"{curr2.Data} => ");
            }
        }
    }
}
