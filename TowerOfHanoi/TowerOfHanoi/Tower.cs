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
            if
        }

        private void ShiftEven()
        {

        }

    }

    class Disk
    {
        int value;

        public Disk(int newValue)
        {
            value = newValue;
        }
    }
}
