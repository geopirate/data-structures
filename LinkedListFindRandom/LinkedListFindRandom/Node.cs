using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListFindRandom
{
    class Node
    {
        public Node next;
        public Object data;

        public Node(Object thisData)
        {
            data = thisData;
            next = null;
        }
    }
}
