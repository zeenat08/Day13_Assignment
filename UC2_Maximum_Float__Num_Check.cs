using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC2_Maximum_Float__Num_Check
    {
        public static float MaxFloatNumber(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            throw new Exception("FirstNumber, SecondNumber and ThirdNumber are same or Maybe 2 Numbers are same");
        }
    }
}
