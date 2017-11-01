using System;

namespace MiscAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            AssociativeArray newAA = new AssociativeArray();

            newAA.Add("Monkey");
            newAA.Add("Rabbit");
            Console.WriteLine($"{newAA.Search("Monkey")}");
            Console.WriteLine($"{newAA.Delete("Rabbit")}");



            Console.Read();
        }
    }
}
