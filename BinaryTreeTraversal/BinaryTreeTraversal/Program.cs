using System;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This traverses a binary tree.");
            // this creates the root node in the constructor
            BinaryTree myTree = new BinaryTree();

            // adds all of the nodes statically
            myTree.Root.Left = new Node(1);
            myTree.Root.Right = new Node(2);
            myTree.Root.Left.Left = new Node(3);
            myTree.Root.Left.Right = new Node(4);
            myTree.Root.Right.Left = new Node(5);
            myTree.Root.Right.Right = new Node(6);

            // new traversal code
            myTree.GetChildren(myTree.Root);

            Console.Read();
        }
    }
}
