using System;
using System.Collections.Generic;
using System.Text;

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
