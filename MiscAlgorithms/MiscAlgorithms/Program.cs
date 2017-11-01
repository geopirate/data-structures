using System;

namespace MiscAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            AssociativeArray newAA = new AssociativeArray();
            State wash = new State("WA", "Olympia");

            newAA.Add(new State("OR", "Salem"));
            newAA.Add(wash);
            newAA.Add(new State("TX", "Austin"));
            newAA.Add(new State("NY", "Albany"));
            newAA.SearchKey("TX");

            newAA.Print();

            newAA.Delete(wash);

            newAA.Print();

            Console.Read();
        }
    }
}
