using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC4_Sorting<T> where T : IComparable
    {
        public T[] value;
        public UC4_Sorting(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[sorted_values.Length - 1];
        }
    }
}

