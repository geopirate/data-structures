using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Palindrome Checker\n\n");
            DoubleList newlist = new DoubleList();
            newlist.Converter("tacocat");
            newlist.PrintList();
            newlist.CheckText(newlist.Check());

            DoubleList newlist2 = new DoubleList();
            newlist2.Converter("monkey");
            newlist2.PrintList();
            newlist2.CheckText(newlist2.Check());

            Console.Write("Please enter a string to check: ");
            DoubleList newlist3 = new DoubleList();
            newlist3.Converter(Console.ReadLine());
            newlist3.PrintList();
            newlist3.CheckText(newlist3.Check());

            Console.Read();
        }
    }
}
