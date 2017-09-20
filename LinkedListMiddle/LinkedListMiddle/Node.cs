using System;

namespace LinkedListMiddle
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
