using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    class Node
    {
        public object data;
        public Node next;
        public Node previous;

        public Node(object thisData)
        {
            data = thisData;
            next = null;
            previous = null;
        }

    }
}
