using System;

namespace AnimalGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] {
                "cat",
                "Does it meow?",
                "dog",
                "Is it a Mammal?",
                "fish",
                "Does it swim?",
                "snake"
            };
            BST myTree = new BST(myArray);
            myTree.AskQuestion(myTree.Root);

            //Console.WriteLine("This traverses a binary tree Breadth Order.");
            //myTree.BreadthOrder(myTree.Root);

            Console.Read();
        }
    }
}
