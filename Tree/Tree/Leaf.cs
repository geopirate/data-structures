using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Leaf
    {
        // the value inside the leaf
        public int Value;
        // the left child leaf
        public Leaf Left;
        // the right child leaf
        public Leaf Right;

        // leaf constructor that creates a leaf using a value input and sets children to null
        public Leaf (int leafValue)
        {
            Value = leafValue;
            Left = null;
            Right = null;
        }
    }
}
