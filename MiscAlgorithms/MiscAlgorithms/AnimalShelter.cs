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
            Console.Write($"\nYou selected {input} and adopted ");
            if (input == "cat")
            {
                Console.Write($"{Cat.Peek().Type} {Cat.Peek().Arrival}.");
                return Cat.Dequeue();
            }

            if (input == "dog")
            {
                Console.Write($"{Dog.Peek().Type} {Dog.Peek().Arrival}.");
                return Dog.Dequeue();
            }
            else
            {
                if (Cat.Peek().Arrival < Dog.Peek().Arrival)
                {
                    Console.Write($"{Cat.Peek().Type} {Cat.Peek().Arrival}.");
                    return Cat.Dequeue();
                }
                else
                {
                    Console.Write($"{Dog.Peek().Type} {Dog.Peek().Arrival}.");
                    return Dog.Dequeue();
                }
            }
        }

        public void Print()
        {
            Console.Write("\nCats : ");
            foreach ( Animal x in Cat)
            {
                Console.Write($"{x.Type} {x.Arrival} ");
            }
            Console.Write("\nDogs : ");
            foreach (Animal x in Dog)
            {
                Console.Write($"{x.Type} {x.Arrival} ");
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
