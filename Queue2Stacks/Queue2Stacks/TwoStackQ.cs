using System;
using System.Collections.Generic;
using System.Text;

namespace Queue2Stacks
{
    class TwoStackQ
    {
        public Stack One = new Stack();
        public Stack Two = new Stack();

        public void Queue(object newData)
        {
            One.Push(newData);
        }
        public void Dequeue()
        {
            if (Two.Head == null || Two.Head.Next == null)
            {
                while (One.Head.Next != null)
                {
                    Two.Push(One.Pop(true));
                }
                if(Two.Head == null)
                {
                    Console.WriteLine("All empty!");
                    return;
                }
            }
            Two.Pop();
        }

        public void Print()
        {
            Console.Write("\nFirst Stack: ");
            One.Print();
            Console.Write("    Second Stack: ");
            Two.Print();
        }
    }
}
