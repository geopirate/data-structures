using System;

namespace LinkedListDelete
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList newlist = new LinkedList();

            newlist.Add("first");
            newlist.Add("second");
            newlist.Add("third");
            newlist.Add("fourth");
            newlist.Add("fifth");
            newlist.Add("sixth");
            newlist.Add("seventh");
            newlist.Add("eighth");
            newlist.Add("ninth");
            newlist.PrintList();
            Console.WriteLine();

            // change the arguement to delete a different node
            newlist.DeleteData("fifth");

            Console.WriteLine();
            newlist.PrintList();

            Console.Read();
        }
    }
}
