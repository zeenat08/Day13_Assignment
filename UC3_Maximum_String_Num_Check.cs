using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC3_Maximum_String_Num_Check
    {
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
               firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
               firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
               secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
               secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
               thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
               thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("FirstNumber, SecondNumber and ThirdNumber are same or Maybe 2 Numbers are same");
        }
    }
}


        

    