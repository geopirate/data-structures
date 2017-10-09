using System;

namespace StackSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This adds numbers to a stack and sorts them on push.");

            Stack sorter = new Stack();

            
            sorter.Push(2);
            sorter.Push(3);
            sorter.Push(4);
            sorter.Push(5);
            sorter.Push(7);
            sorter.Push(8);
            sorter.Push(9);


            sorter.Print();
            Console.WriteLine("Add a number before the first element.");
            sorter.Push(1);
            sorter.Print();
            Console.WriteLine("Add a number in the middle.");
            sorter.Push(6);
            sorter.Print();
            Console.WriteLine("Add a number after the last element.");
            sorter.Push(10);
            sorter.Print();
            
            Console.WriteLine($"Pop, {sorter.Pop().Data} no sorting required!");
            sorter.Print();

            Console.Read();
        }
    }
}
