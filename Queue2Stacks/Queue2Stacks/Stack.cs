using System;
using System.Collections.Generic;
using System.Text;

namespace Queue2Stacks
{
    class Stack
    {
        public Node Head = null;

        public void Push(object data)
        {
            Node newNode = new Node(data);

            
                newNode.Next = Head;
     
            Head = newNode;
        }

        public void Pop()
        {
            Head = Head.Next;
        }

        public object Pop(bool e)
        {
            Node curr = Head;
            Head = Head.Next;
            return curr.Data;
        }

        public void Print()
        {
            if(Head == null)
            {
                return;
            }
            Node curr = Head;
            Console.Write($"{curr.Data} => ");
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write($"{curr.Data} => ");
                
            }
        }
    }
}
