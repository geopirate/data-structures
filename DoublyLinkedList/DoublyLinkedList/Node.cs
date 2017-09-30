using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class Node
    {
        public Node Next;
        public Node Previous;
        public Object Data;

        public Node(Object thisData)
        {
            Data = thisData;
            Next = null;
            Previous = null;
        }
    }
}
