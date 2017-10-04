using System;

namespace BinaryTreeTraversal
{
    class BinaryTree
    {
        // value of the root leaf (node?)
        public Node Root;

        // initializes the tree with a root node
        public BinaryTree() => Root = new Node(null);

        public void GetChildren(Node Current)
        {
            Console.Write($"{Current.Value} ");
            if (Current.Left != null) { GetChildren(Current.Left); }
            if (Current.Right != null) { GetChildren(Current.Right); }
            return;
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
    public class Node
    {
        public object Value;
        public Node Left;
        public Node Right;

        public Node(object leafValue)
        {
            Value = leafValue;
            Left = null;
            Right = null;
        }
    }
}
