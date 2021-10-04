using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    public class Refactor2_Generic_Class<T> where T : IComparable
    {
        private T first, second, third;
        public Refactor2_Generic_Class(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public void findMaximum()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("The Greatest is : " + first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("The Greatest  is : " + second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("The Greatest  is : " + third);
            }
            else
                Console.WriteLine("All are equal");
        }
    }
}
