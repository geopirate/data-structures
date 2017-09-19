using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newlist = new LinkedList();
            string x = "first item";
            string y = "second item";
            string z = "third item";
            newlist.Add(x);
            newlist.Add(y);
            newlist.Add(z);
            newlist.PrintList();
            Console.Read();
        }
    }
}