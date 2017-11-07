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

        public Tower(int n)
        {
            for(int i=1; i<=n; i++)
            {
                Left.Push(new Disk(i));
            }

            if(n%2 == 0)
            {
                ShiftEven();
            } else
            {
                ShiftOdd();
            }
        }

        private void ShiftOdd()
        {
            Right.Push(Left.Pop());

            while(Left.Peek() != null && Middle.Peek() != null)
            {
                if (Left.Peek() != null && Right.Peek() != null && Middle.Peek() == null)
                {
                    Middle.Push(Left.Pop());
                }
                else if (Left.Peek().value > Middle.Peek().value && Right.Peek() == null) {
                    Right.Push(Left.Pop());
                }
            }
        }

        private void ShiftEven()
        {

        }

        private void Print()
        {
            Console.WriteLine(Left.)
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
