using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTrees
{
    public class BinarySearchTree
    {
        // value of the root leaf (node?)
        public Node Root;

        // initializes the tree with a root node
        public BinarySearchTree() => Root = null;

        public void BSTAdd(int data)
        {
            if (Root == null)
                Root = new Node(data);

            Node current = Root;

            while (current != null)
            {
                // left is less
                if (data < current.Data)
                {
                    if(current.Left == null)
                    {
                        current.Left = new Node(data);
                        return;
                    }
                    else
                    {
                        BSTAdd(current.Left.Data);
                        return;
                    }
                }
                // right is more 
                if (data > current.Data)
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(data);
                        return;
                    }
                    else
                    {
                        BSTAdd(current.Right.Data);
                        return;
                    }
                }
            }

        }
    }
    // the node class in our binary search tree
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int newData)
        {
            Data = newData;
            Left = null;
            Right = null;
        }
    }
}
