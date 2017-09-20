using System;

namespace LinkedListMiddle
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

            Console.WriteLine("Middle is " + newlist.middle + " of " + newlist.count);


            Console.WriteLine();
            newlist.PrintMiddle();
            Console.WriteLine();



            Console.Read();
        }
    }
}
