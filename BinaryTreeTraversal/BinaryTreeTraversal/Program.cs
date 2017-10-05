using System;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // this creates the root node in the constructor
            BinaryTree myTree = new BinaryTree();

            // adds all of the nodes statically
            myTree.Root = new Node(4);
            myTree.Root.Left = new Node(2);
            myTree.Root.Right = new Node(6);
            myTree.Root.Left.Left = new Node(1);
            myTree.Root.Left.Right = new Node(3);
            myTree.Root.Right.Left = new Node(5);
            myTree.Root.Right.Right = new Node(7);

            // new traversal code
            Console.WriteLine("This traverses a binary tree Pre Order.");
            myTree.PreOrder(myTree.Root);
            Console.WriteLine("\nThis traverses a binary tree Post Order.");
            myTree.PostOrder(myTree.Root);
            Console.WriteLine("\nThis traverses a binary tree In Order.");
            myTree.InOrder(myTree.Root);

            Console.Read();
        }
    }
}
