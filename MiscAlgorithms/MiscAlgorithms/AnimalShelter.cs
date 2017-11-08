using System;
using System.Collections.Generic;
using System.Text;

namespace MiscAlgorithms
{
    class AnimalShelter
    {
        int TotalArrivals = 1;
        Queue<Animal> Cat = new Queue<Animal>();
        Queue<Animal> Dog = new Queue<Animal>();

        public void Load(string type)
        {
            if (type == "cat")
                Cat.Enqueue(new Animal(type, TotalArrivals));
            else
                Dog.Enqueue(new Animal(type, TotalArrivals));
            TotalArrivals++;
            Print();
        }

        public Animal Adopt(string input)
        {
            if(input == "cat")
                return Cat.Dequeue();
            if (input == "dog")
                return Dog.Dequeue();
            else
                if (Cat.Peek().Arrival < Dog.Peek().Arrival)
                    return Cat.Dequeue();
                else
                    return Dog.Dequeue();
        }

        public void Print()
        {
            Console.Write("\nCats : ");
            foreach ( Animal x in Cat)
            {
                Console.Write($"{x.Arrival}-{x.Type} ");
            }
            Console.Write("\nDogs : ");
            foreach (Animal x in Dog)
            {
                Console.Write($"{x.Arrival}-{x.Type} ");
            }
            Console.WriteLine();
        }
    }

    class Animal
    {
        public string Type;
        public int Arrival;

        public Animal(string type, int arrival)
        {
            Type = type;
            Arrival = arrival;
        }
    }
}
