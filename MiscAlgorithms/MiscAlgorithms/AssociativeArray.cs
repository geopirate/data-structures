using System;
using System.Collections.Generic;
using System.Text;

namespace MiscAlgorithms
{
    public class AssociativeArray
    {
        Object[] array= new object[1];

        public AssociativeArray(){}

        public AssociativeArray(Object[] newArray)
        {
            array = newArray;
        }

        public void Add(object element)
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                if( array[i] == null)
                {
                    array[i] = element;
                    return;
                }
            }
            Object[] newArray = new Object[array.Length*2];

            for(int j = 0; j < array.Length-1; j++)
                newArray[j] = array[j];

            array = newArray;
            Add(element);
        }

        public object Delete(object element)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == element)
                {
                    array[i] = null;
                    Console.Write("Deleted: ");
                    return element;
                }
            }
            Console.Write("Did not find: ");
            return element;
        }

        public object Search(object element)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == element)
                {
                    Console.Write($"At index {i} we found: ");
                    return element;
                }
            }
            Console.Write("Did not find: ");
            return element;
        }
    }
}
