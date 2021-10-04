using System;

namespace Day13_Assignment
{
    class Program
    {
         static void Main(string[] args)
         {
                Console.WriteLine("Finding Maximum Number");


            //*****UC1--Maximium Integer Number******
            int check1 = UC1_Maximum_Int_Num_Check.MaximumIntNumber(60, 50, 40);
            Console.WriteLine("Maximum Number:" + check1);


            //*****UC2--Maximum Floating Point Number******
            float check2 = UC2_Maximum_Float__Num_Check.MaxFloatNumber(23.45f, 45.6f, 38.65f);
            Console.WriteLine("Maximum Number:" + check2);


            //*****UC3--Maximum String******
            string check3 = UC3_Maximum_String_Num_Check.MaximumStringNumber("67", "56", "38");
            Console.WriteLine("Maximum Number:" + check3);


            //*****Refactor1 * ******
            Refactor_Generic_Method checkMax = new Refactor_Generic_Method();
            checkMax.findMaximum<int>(25, 63, 14);
            checkMax.findMaximum<float>(4.2f, 5.6f, 69.4f);
            checkMax.findMaximum<char>('a', 'b', 'c');


            ////*****Refactor2*******
            Refactor2_Generic_Class<int> maxInt = new Refactor2_Generic_Class<int>(25, 46, 16);
            maxInt.findMaximum();
            Refactor2_Generic_Class<float> maxFloat = new Refactor2_Generic_Class<float>(7.5f, 8.0f, 2.6f);
            maxFloat.findMaximum();
            Refactor2_Generic_Class<string> maxStr = new Refactor2_Generic_Class<string>("not", "the", "problem");
            maxStr.findMaximum();


            #region UC4_MaxValue

            //By using Array taking more than 3 parameters

            int[] intArray1 = { 937, 68, 431, 529, 736 };
            UC4_Sorting<int> checkInt1 = new UC4_Sorting<int>(intArray1);
            int i = checkInt1.MaxValue(intArray1);
            Console.WriteLine(i);

            float[] floatArray1 = { 5.6f, 67.54f, 32.2f, 57.89f, 12.2f };
            UC4_Sorting<float> checkFloat1 = new UC4_Sorting<float>(floatArray1);
            float f = checkFloat1.MaxValue(floatArray1);
            Console.WriteLine(f);

            string[] stringArray1 = { "325", "836", "238", "759", "479" };
            UC4_Sorting<string> checkString1 = new UC4_Sorting<string>(stringArray1);
            string s = checkString1.MaxValue(stringArray1);
            Console.WriteLine(s);

            #endregion


            #region UC5_Extending_Method

            int[] intArray = { 937, 68, 2826, 529, 736 };
            UC5_Extending_Method<int> checkInt2 = new UC5_Extending_Method<int>(intArray);
            checkInt2.PrintMaxValue();

            float[] floatArray = { 5.6f, 67.54f, 32.2f, 57.89f, 12.2f };
            UC5_Extending_Method<float> checkFloat2 = new UC5_Extending_Method<float>(floatArray);
            checkFloat2.PrintMaxValue();

            string[] stringArray = { "325", "536", "238", "75", "479" };
            UC5_Extending_Method<string> checkString2 = new UC5_Extending_Method<string>(stringArray);
            checkString2.PrintMaxValue();

            #endregion
         }
    }
}


