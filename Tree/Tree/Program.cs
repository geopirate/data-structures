using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This creates a binary tree.");
            // this creates the root node in the constructor
            Tree myTree = new Tree();

            // this is the alternative solution to the problem
            /*  Leaf one = new Leaf(1);
             * Leaf three = new Leaf(3);
             * myTree.Root.Left = one;
             * one.Left = three; */

            // adds a left child on the first level
            myTree.Root.Left = new Leaf(1);
            // adds a right child on the first level
            myTree.Root.Right = new Leaf(2);
            // adds a left and a right child to 1 on the second level
            myTree.Root.Left.Left = new Leaf(3);
            myTree.Root.Left.Right = new Leaf(4);
            // adds a left and a right child to 2 on the second level
            myTree.Root.Right.Left = new Leaf(5);
            myTree.Root.Right.Right = new Leaf(6);

            Console.Read();
        }
    }
}
