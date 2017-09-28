using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char b = 'b';
            if (a == b)
            {
                Console.WriteLine("Hello World!");
            }


            DoubleList newlist = new DoubleList();
            newlist.Converter("tacocat");
            
            newlist.PrintList();
            if (newlist.Check())
            {
                Console.WriteLine($" is a palindrome.\n");
            }
            else
            {
                Console.WriteLine($" is not a palindrome.\n");
            }

            DoubleList newlist2 = new DoubleList();
            newlist2.Converter("monkeyb");
            
            newlist2.PrintList();
            if (newlist2.Check())
            {
                Console.WriteLine($" is a palindrome.\n");
            }
            else
            {
                Console.WriteLine($" is not a palindrome.\n");
            }

            Console.Read();
        }
    }
}
