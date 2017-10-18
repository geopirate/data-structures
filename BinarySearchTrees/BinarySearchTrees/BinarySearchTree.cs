﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTrees
{
    public class BinarySearchTree
    {
        // value of the root leaf (node?)
        public Node Root;

        // initializes the tree with a root node
        public BinarySearchTree(int initialRoot) => Root = new Node(initialRoot);

        public void BSTAdd(Node current, int data)
        {
            // left is less
            if (data < current.Data)
            {
                if (current.Left == null)
                {
                    current.Left = new Node(data);
                    return;
                }
                else
                {
                    BSTAdd(current.Left, data);
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
                    BSTAdd(current.Right, data);
                    return;
                }
            }
        }

        public int FindMin(Node Curr)
        {
            if (Curr.Left != null)
                return FindMin(Curr.Left);
            else
                return Curr.Data;
        }

        public int FindMax(Node Curr)
        {
            if (Curr.Right != null)
                return FindMin(Curr.Right);
            else
                return Curr.Data;
        }


        public void BreadthOrder(Node Current)
        {
            Queue<Node> tree = new Queue<Node>();

            if (Current == null) { return; }

            tree.Enqueue(Current);

            while (tree.Count > 0)
            {
                Node Counter = tree.Dequeue();
                if (Counter.Left != null)
                {
                    tree.Enqueue(Counter.Left);
                }
                if (Counter.Right != null)
                {
                    tree.Enqueue(Counter.Right);
                }
                Console.Write($"{Counter.Data} ");
            }
        }
        public void PreOrder(Node Current)
        {
            if (Current != null)
            {
                Console.Write($"{Current.Data} ");
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
                Console.Write($"{Current.Data} ");
            }
        }
        public void InOrder(Node Current)
        {
            if (Current != null)
            {
                InOrder(Current.Left);
                Console.Write($"{Current.Data} ");
                InOrder(Current.Right);
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
