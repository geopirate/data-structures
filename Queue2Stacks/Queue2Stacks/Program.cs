﻿using System;

namespace Queue2Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Queue of 2 stacks!");

            TwoStackQ TS = new TwoStackQ();
            
            TS.Print();
            TS.Queue("first");
            TS.Print();
            TS.Queue("second");
            TS.Print();
            TS.Queue("third");
            //TS.Queue("fourth");
            //TS.Queue("fifth");
            //TS.Queue("sixth");
            //TS.Queue("seventh");
            //TS.Queue("eighth");
            TS.Print();
            TS.Dequeue();
            TS.Print();
            TS.Dequeue();
            TS.Print();
            TS.Dequeue();
            TS.Print();

            Console.Read();
        }
    }
}
