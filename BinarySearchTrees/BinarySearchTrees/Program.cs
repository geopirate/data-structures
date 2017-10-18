using System;

namespace BinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree(10);

            myTree.BSTAdd(myTree.Root, 11);
            myTree.BSTAdd(myTree.Root, 13);
            myTree.BSTAdd(myTree.Root, 15);
            myTree.BSTAdd(myTree.Root, 17);
            myTree.BSTAdd(myTree.Root, 16);
            myTree.BSTAdd(myTree.Root, 9);
            myTree.BSTAdd(myTree.Root, 2);
            myTree.BSTAdd(myTree.Root, 3);
            myTree.BSTAdd(myTree.Root, 1);
            myTree.BSTAdd(myTree.Root, 5);

            /*Console.WriteLine("This traverses a binary tree Breadth Order.");
            myTree.BreadthOrder(myTree.Root);
            Console.WriteLine("\nThis traverses a binary tree Pre Order.");
            myTree.PreOrder(myTree.Root);
            Console.WriteLine("\nThis traverses a binary tree Post Order.");
            myTree.PostOrder(myTree.Root);*/
            Console.WriteLine("\nThis traverses a binary tree In Order.");
            myTree.InOrder(myTree.Root);

            Console.WriteLine($"The max is {myTree.FindMax(myTree.Root)}.");
            Console.WriteLine($"The min is {myTree.FindMin(myTree.Root)}.");

            Console.Read();
        }
    }
}
