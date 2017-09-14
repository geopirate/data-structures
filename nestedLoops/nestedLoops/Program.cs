using System;

namespace nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string exes = "x ";
            string ohs = "o ";

            Console.WriteLine("Hello Josie!");
            Console.WriteLine();
            // print a legend and the checkerboard pattern
            Console.WriteLine("Cat nip = x, Mint = 0");
            Console.WriteLine();
            Checkers(exes, ohs);

            Console.WriteLine();
            // print a legend and the alternating rows pattern
            Console.WriteLine("Carrots = x, Tomatos = 0");
            Console.WriteLine();
            Rows(exes, ohs);

            Console.Read();
        }

        // prints a alternating checkerboard pattern
        static void Checkers(string x, string o)
        {
            int z = 0;
            for (int i = 0; i < 5; i++)
            {
                z++;
                for (int j = 0; j < 5; j++)
                {
                    if ((j+z) % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(o);
                    }
                }
                Console.WriteLine();
            }
        }

        // prints alternating rows
        static void Rows(string x, string o)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(o);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
/*
 * Josie Cat has 2 types of plants she would like to plant; cat nip, and mint. She would like to alternate each of these plants within 5 columns and 5 rows.
 * If you have time, using the same number of colums and rows as above, create another garden for Josie Cat that has alternating rows
 * The 1st/3rd/5th row are of Carrots
 * The 2nd/4th row are of tomatos.
 */