using System;
using System.Collections.Generic;
using System.Text;

namespace TowerOfHanoi
{
    class Tower
    {
        Stack<Disk> Left = new Stack<Disk>();
        Stack<Disk> Middle = new Stack<Disk>();
        Stack<Disk> Right = new Stack<Disk>();
        int N;

        public Tower(int n)
        {
            N = n;
            for(int i=1; i<=n; i++)
            {
                Right.Push(new Disk(i));   
            }
            for (int i = 1; i <= n; i++)
            {
                Left.Push(Right.Pop());

            }
        }

        public void Shift()
        {
            if (N % 2 == 0)
            {
                ShiftEven();
            }
            else
            {
                ShiftOdd();
            }
        }

        private void ShiftOdd()
        {
            Right.Push(Left.Pop());

            while (Left.Count != 0 || Middle.Count != 0)
            {
                Print();

                if (Left.Count != 0 && Right.Count != 0 && Middle.Count == 0)
                {
                    Middle.Push(Left.Pop());
                }
                else if (Left.Peek().value > Middle.Peek().value && Right.Count == 0) {
                    Right.Push(Left.Pop());
                }
            }
            Console.WriteLine("Final Form\n");
            Right.Push(Left.Pop());
        }

        private void ShiftEven()
        {

        }

        public void Print()
        {
            Console.Write("\n\nL :");
            foreach (Disk x in Left)
            {
                Console.Write($" {x.value}");
            }

            Console.Write("\nM :");
            foreach (Disk x in Middle)
            {
                Console.Write($" {x.value}");
            }
            Console.Write("\nR :");
            foreach (Disk x in Right)
            {
                Console.Write($" {x.value}");
            }

        }

    }

    class Disk
    {
        public int value;

        public Disk(int newValue)
        {
            value = newValue;
        }
    }
}
