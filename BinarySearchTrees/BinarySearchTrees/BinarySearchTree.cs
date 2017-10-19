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
            //if(Curr == null)
            //{
            //    Console.WriteLine("current is null?");
            //    return;
            //}


            if (Curr.Data == data)
            {
                if (Curr == Root)
                {
                    
                }
                if (Curr.Left == null && Curr.Right == null)
                {
                    Console.WriteLine($"Deleting {Curr.Data}");
                    DestroyLeft(Root, data);
                    DestroyRight(Root, data);
                    return;
                }
                else if (Curr.Left != null && Curr.Right == null)
                {
                    Curr.Data = FindMax(Curr.Left);
                    Console.WriteLine($"replacement node is {Curr.Data}");
                    DestroyRight(Curr, Curr.Data);
                }
                else
                {
                    Curr.Data = FindMin(Curr.Left);
                    Console.WriteLine($"replacement node is {Curr.Data}");
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
