using System;
using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    class BinaryTree
    {
        // value of the root leaf (node?)
        public Node Root;

        // initializes the tree with a root node
        public BinaryTree() => Root = null;

        public void BreadthOrder(Node Current)
        {
            Queue<Node> tree = new Queue<Node>();

            if(Current == null) { return; }

            tree.Enqueue(Current);

            while (tree.Count > 0)
            {
                if (Current.Left != null)
                {
                    tree.Enqueue(Current.Left);
                }
                if (Current.Right != null)
                {
                    tree.Enqueue(Current.Right);
                }
                Console.Write($"{Current.Value} ");
            }
        }

        public void PreOrder(Node Current)
        {
            if (Current != null)
            {
                Console.Write($"{Current.Value} ");
                PreOrder(Current.Left);
                PreOrder(Current.Right);
            }
        }
        public void PostOrder(Node Current)
        {
            if (Current != null)
            {
                PostOrder(Current.Left);
                PostOrder(Current.Right);
                Console.Write($"{Current.Value} ");
            }
        }
        public void InOrder(Node Current)
        {
            if (Current != null)
            {
                InOrder(Current.Left);
                Console.Write($"{Current.Value} ");
                InOrder(Current.Right);
            }
        }
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
