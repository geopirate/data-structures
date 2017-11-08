using System;

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

            Console.Write($"\nAdopted {shelter.Adopt("cat").Type}.");
            shelter.Print();
            Console.WriteLine($"\nAdopted {shelter.Adopt("dog").Type}.");
            shelter.Print();
            Console.WriteLine($"\nAdopted {shelter.Adopt("monkey").Type}.");
            shelter.Print();
            Console.WriteLine($"\nAdopted {shelter.Adopt("turtle").Type}.");
            shelter.Print();
            Console.WriteLine($"\nAdopted {shelter.Adopt("fish").Type}.");
            shelter.Print();




            Console.Read();
        }
    }
}
