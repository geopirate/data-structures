using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        // value of the root leaf (node?)
        public Leaf Root;

        // initializes the tree with a root node
        public Tree()
        {
            Root = new Leaf(0);
        }
        /* started working on an add method, but this still needs some work
        public void FindLeaf(int childValue)
        {
            Leaf current = Root;

            bool searching = true;

            while (searching)
            {
                if(current.Left != null && current.Right != null)
                {
                    current = current.Left;
                }
                else if(current.Left == null)
                {
                    Add(current, childValue);
                }
                else if(current.Right == null)
                {
                    Add(current, childValue);
                }
            }
        }

        public void Add(Leaf parent, int child)
        {
            if (parent.Left == null)
            {
                parent.Left = new Leaf(child);
            }
            else if (parent.Right == null)
            {
                parent.Right = new Leaf(child);
            }
            else
            {
                return;
            }
        }*/
    }
}
