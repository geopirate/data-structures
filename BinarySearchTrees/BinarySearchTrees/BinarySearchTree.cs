﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTrees
{
    public class BinarySearchTree
    {
        // value of the root leaf (node?)
        public Node Root;

        // initializes the tree using an int for the root node
        public BinarySearchTree(int initialRoot) => Root = new Node(initialRoot);

        // initializes the tree using an array
        public BinarySearchTree(int[] initialArray)
        {
            Root = ArrayToBST(initialArray, 0, initialArray.Length - 1);
        }

        public Node ArrayToBST(int[] array, int start, int end)

        {
            // once we get to the end this stops the recursive calls
            if (start > end) { return null; }
            // this caused a little trouble
            // using math.floor to yield more consistent results than just dividing
            int mid = (int)Math.Floor((start + end) / 2.0);
            // this makes a new node with the medium value and makes recursive calls to create it's child nodes
            Node newNode = new Node(array[mid])
            {
                Left = ArrayToBST(array, start, mid - 1),
                Right = ArrayToBST(array, mid + 1, end)
            };
            // after all of the recursive calls we return the initial node with all the nodes attached to it
            return newNode;
        }

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
            if (Curr == null)
            {
                Console.WriteLine("huh???");
                return(0);
            }
            if (Curr.Left != null)
                return FindMin(Curr.Left);
            else
                return Curr.Data;
        }

        public int FindMax(Node Curr)
        {
            if (Curr.Right != null)
                return FindMax(Curr.Right);
            else
                return Curr.Data;
        }

        public void Delete(Node Curr, int data)
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty!");
                return;
            }

            if (Curr.Data == data)
            {
                if (Curr == Root)
                {
                    Root.Data = FindMax(Root.Right);
                    DestroyRight(Root, Root.Data);
                    return;
                }
                if (Curr.Left == null && Curr.Right == null)
                {
                    DestroyLeft(Root, data);
                    DestroyRight(Root, data);
                    return;
                }
                else if (Curr.Left != null && Curr.Right == null)
                {
                    Curr.Data = FindMax(Curr.Left);
                    DestroyRight(Curr, Curr.Data);
                }
                else
                {
                    Curr.Data = FindMin(Curr.Left);
                    DestroyLeft(Curr, Curr.Data);
                }
            }
            else if (Curr.Data > data)
                Delete(Curr.Left, data);
            else if (Curr.Data < data)
                Delete(Curr.Right, data);
            else
                Console.WriteLine("Did not find that value");
        }

        public void DestroyLeft(Node L, int data)
        {
            if (L.Left.Data == data)
            {
                L.Left = null;
                return;
            }
            else
                DestroyLeft(L.Left, data);
        }

        public void DestroyRight(Node R, int data)
        {
            if (R.Right.Data == data)
            {
                R.Right = null;
                return;
            }
            else
                DestroyRight(R.Right, data);
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
