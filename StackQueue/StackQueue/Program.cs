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
/* Make sure your pop and dequeue methods return a value, 
 * and when you have one element left in the the stack or queue, it should pop or dequeue  the head.
 * At present the head is a node with a null value, which should not be there.
 * Also it is more efficient to have the pop and push methods add and remove from the head of the stack. 
 * When adding and removing from the tail, you increase the time complexity from O(1) to O(N).
 */
