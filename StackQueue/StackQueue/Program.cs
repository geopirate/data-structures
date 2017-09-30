using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack newStack = new Stack();

            Console.Write("The Stack      : ");
            newStack.Push("first");            
            newStack.PrintList();

            Console.Write("\nPush the Stack : ");
            newStack.Push("second");
            newStack.PrintList();

            Console.Write("\nPush the Stack : ");
            newStack.Push("third");
            newStack.PrintList();

            Console.Write("\nPop the Stack  : ");
            newStack.Pop();
            newStack.PrintList();
            
            Console.Write("\nPop the Stack  : ");
            newStack.Pop();
            newStack.PrintList();
            
            Console.Write("\nPop the Stack  : ");
            newStack.Pop();
            newStack.PrintList();

            Console.Write("\nPop the Stack  : ");
            newStack.Pop();
            newStack.PrintList();

            Queue newQueue = new Queue();

            Console.Write("\n\nThe Queue         : ");
            newQueue.Enqueue("first");
            newQueue.PrintList();

            Console.Write("\nEnqueue the Queue : ");
            newQueue.Enqueue("second");
            newQueue.PrintList();

            Console.Write("\nEnqueue the Queue : ");
            newQueue.Enqueue("third");
            newQueue.PrintList();

            Console.Write("\nDequeue the Queue : ");
            newQueue.Dequeue();
            newQueue.PrintList();

            Console.Write("\nDequeue the Queue : ");
            newQueue.Dequeue();
            newQueue.PrintList();

            Console.Write("\nDequeue the Queue : ");
            newQueue.Dequeue();
            newQueue.PrintList();

            Console.Read();
        }
    }
}
