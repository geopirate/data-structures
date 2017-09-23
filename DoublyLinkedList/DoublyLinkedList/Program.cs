using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newlist = new LinkedList();

            newlist.Append("first");
            newlist.Append("second");
            newlist.Append("third");
            newlist.Append("fourth");
            newlist.Append("fifth");
            newlist.Append("sixth");
            newlist.Append("seventh");
            newlist.Append("eighth");
            newlist.Append("ninth");

            newlist.PrintList();
            Console.WriteLine();

            newlist.DeleteData("eighth");

            Console.WriteLine();
            newlist.PrintList();

            Console.Read();
        }
    }
}
