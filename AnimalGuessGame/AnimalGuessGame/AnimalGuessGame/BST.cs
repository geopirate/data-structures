using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGuessGame
{
    class BST
    {
        // value of the root leaf (node?)
        public Node Root;

        // initializes the tree using an string for the root node
        public BST(string initialRoot) => Root = new Node(initialRoot);

        // initializes the tree using an array
        public BST(string[] initialArray)
        {
            Root = ArrayToBST(initialArray, 0, initialArray.Length - 1);
        }
        // this is the prompt to ask the questions
        public void AskQuestion(Node Curr)
        {
            // if both sides are null we are at the bottom of the tree, so we want to ask if this is the correct animal in a helper method
            if (Curr.Left == null && Curr.Right == null)
                MakeGuess(Curr);
            // otherwise we are in the middle and need to keep recursively asking questions
            else
            { 
                // if they answer yes go to the left node and ask the question there
                Console.Write($"\n{Curr.Data} ");
                if (GetInput())
                    AskQuestion(Curr.Left);
                // otherwise it's a no so we go to the right
                else
                    AskQuestion(Curr.Right);
            }
        }
        // this method asks if the animal at the leaf is correct and adds a new node if incorrect
        private void MakeGuess(Node node)
        {
            Console.WriteLine($"Were you thinking of {node.Data}?");
            if (GetInput())
            {
                // if they answer yes, we send a message
                Console.WriteLine("Hurray! I have read your mind!");
                KeepPlaying();
                return;
            }
            // We didn't guess the correct animal so we need a new animal and question
            else
            {
                Console.WriteLine($"What was the animal you were thinking of?");
                // if required this would be kicked out into another helper function for input validation
                string newAnimal = Console.ReadLine();
                Console.WriteLine($"Please enter a question that would help find that animal instead of {node.Data}.");
                string newQuestion = Console.ReadLine();

                node.Left = new Node(node.Data);
                node.Right = new Node(newAnimal);
                node.Data = newQuestion;

                KeepPlaying();
                return;
            }
        }
        // asks if the player wants to play again
        private void KeepPlaying()
        {
            // we ask if they want to play again if yes start again from the root node asking questions
            Console.WriteLine("Would you like to play again?");
            if (GetInput())
                AskQuestion(Root);
            // if no return so we can end the program
            else
                return;
        }
        // gets a yes or no answer and returns a true for yes
        private bool GetInput()
        {
            Console.Write("Please enter y or yes for yes, anything else is no.");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
                return true;
            else
                return false;
        }
        // takes an array of strings and turns it into our starter tree
        public Node ArrayToBST(string[] array, int start, int end)

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
                Console.WriteLine($"{Counter.Data} ");
            }
        }
    }
    // the node class in our binary search tree
    public class Node
    {
        public string Data;
        public Node Left;
        public Node Right;

        public Node(string newData)
        {
            Data = newData;
            Left = null;
            Right = null;
        }
    }
}