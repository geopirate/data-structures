﻿using System;

namespace MiscAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //AssociativeArray newAA = new AssociativeArray();
            //State wash = new State("WA", "Olympia");

            //newAA.Add(new State("OR", "Salem"));
            //newAA.Add(wash);
            //newAA.Add(new State("TX", "Austin"));
            //newAA.Add(new State("NY", "Albany"));
            //newAA.SearchKey("TX");
            //newAA.Print();
            //newAA.Delete(wash);
            //newAA.Print();

            AnimalShelter shelter = new AnimalShelter();

            shelter.Load("cat");
            shelter.Load("cat");
            shelter.Load("dog");
            shelter.Load("cat");
            shelter.Load("dog");
            shelter.Load("dog");
            shelter.Load("dog");
            shelter.Load("cat");
            shelter.Load("dog");

            shelter.Adopt("cat");
            shelter.Print();
            shelter.Adopt("dog");
            shelter.Print();
            shelter.Adopt("monkey");
            shelter.Print();
            shelter.Adopt("turtle");
            shelter.Print();
            shelter.Adopt("fish");
            shelter.Print();




            Console.Read();
        }
    }
}
