using System;

namespace LinkedListFindRandom
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

            // change this to change the number found
            int z = 3;
            newlist.PrintRandom(z);
            Console.WriteLine();

            // change the arguement to search for different data (stretch goal)
            newlist.FindData("eighth");

            Console.Read();
        }
    }
}
