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
            // create the number of disks we need and put them in a stack
            for(int i=1; i<=n; i++)
            {
                Right.Push(new Disk(i));   
            }
            // push them to another stack to reverse the order
            for (int i = 1; i <= n; i++)
            {
                Left.Push(Right.Pop());
            }
        }

        public void Shift()
        {
            // for even numbers we start in the middle
            if (N % 2 == 0)
            {
                ShiftEven();
            }
            // for odd numbers we start on the right
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
                    if (Left.Peek().value > Right.Peek().value)
                        Middle.Push(Left.Pop());
                    else
                        Right.Push(Left.Pop());
                else if (Right.Count == 0 && Left.Peek().value > Middle.Peek().value)
                    Right.Push(Left.Pop());
                else if (Left.Count == 0 && Middle.Peek().value < Right.Peek().value)
                    Left.Push(Middle.Pop());
                else if (Left.Peek().value > Middle.Peek().value && Left.Peek().value > Right.Peek().value)
                    if (Right.Peek().value > Middle.Peek().value)
                        Right.Push(Middle.Pop());
                    else
                        Middle.Push(Right.Pop());
                else if (Middle.Peek().value < Right.Peek().value)
                    Right.Push(Middle.Pop());
                else if (Left.Peek().value < Right.Peek().value)
                    Right.Push(Left.Pop());
                else
                    Console.WriteLine("Error ???");
            }
            Console.Write("\n\nFinal Form");
            Print();
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
