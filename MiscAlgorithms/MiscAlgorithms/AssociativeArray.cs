using System;
using System.Collections.Generic;
using System.Text;

namespace MiscAlgorithms
{
    public class AssociativeArray
    {
        State[] array= new State[1];

        public AssociativeArray(){}

        public AssociativeArray(State[] newArray)
        {
            array = newArray;
        }

        public void Add(State element)
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                if( array[i] == null)
                {
                    array[i] = element;
                    return;
                }
            }
            State[] newArray = new State[array.Length*2];

            for(int j = 0; j < array.Length-1; j++)
                newArray[j] = array[j];

            array = newArray;
            Add(element);
        }

        public State Delete(State element)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == element)
                {
                    array[i] = null;
                    Console.WriteLine($"Deleted: {element.key} : {element.value}.");
                    return element;
                }
            }
            Console.Write("Did not find: ");
            return element;
        }

        public void SearchKey(string element)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].key == element)
                {
                    Console.WriteLine($"At index {i} we found {array[i].key} : {array[i].value}.");
                    return;
                }
            }
            Console.Write($"Did not find: {element}.");
            return;
        }

        public void SearchValue(string element)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].value == element)
                {
                    Console.WriteLine($"At index {i} we found {array[i].key} : {array[i].value}.");
                    return;
                }
            }
            Console.Write($"Did not find: {element}.");
            return;
        }

        public void Print() {
            foreach(State x in array)
            {
                if(x != null)
                    Console.WriteLine($"Key: {x.key} Value: {x.value}");
            }
        }

    }

    public class State
    {
        public string key;
        public string value;

        public State(string newKey, string newValue)
        {
            key = newKey;
            value = newValue;
        }
    }
}
