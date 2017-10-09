using System;

namespace StackQueue
{
    class Node
    {
        public Node Next;
        public Object Data;

        public Node(Object thisData)
        {
            Data = thisData;
            Next = null;
        }
    }
}
