﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramStart
{
    class Program
    {
        static void Main(string[] args)
        {
            DemonstrateStringJoin();
            DemonstrateStringInterpolation();
            DemonstrateRefVsOut();
            DemonstrateAnonymousFunction();
            DemonstrateHashSet();
            DemonstrateListComprehensions();
            Console.ReadLine();
        }

        public static void DemonstrateStringJoin()
        {
            Console.WriteLine("Demonstrating String.Join():");
            //String.Join provides us more readable syntax and we don't need to write a loop
            var intArray = new int[] { 1, 2, 3, 4, 10 };
            Console.WriteLine("Integer array: ({0})", string.Join(",", intArray));
            //Below lines show that we can use String.Join with list 
            var floatList = new List<float> { 1.3f, 2.0f, 4.5f, 1.22f, 7.8f};
            Console.WriteLine("List of fractions: ({0})", string.Join("|", floatList));
        }

        public static void DemonstrateStringInterpolation()
        {
            Console.WriteLine();
            Console.WriteLine("Demonstrating String Interpolation:");
            int i = 10, j = 20;
            //String interpolation provides a more readable and convenient syntax to create formatted strings
            Console.WriteLine($"Adding {i} with {j} gives {i+j}");
        }

        public static void DemonstrateRefVsOut()
        {
            Console.WriteLine();
            Console.WriteLine("Demonstrating ref vs out:");
            /* Difference between ref and out is that a variable used as out need not be initialized 
             * before usage.*/ 
            int referenceVariable = 1, outputVariable;
            Console.WriteLine($"Before operation referenceVariable= {referenceVariable}," +
                $" outputVariable has not been assigned");
            TestRefAndOut(ref referenceVariable, out outputVariable);
            Console.WriteLine($"Before operation referenceVariable = {referenceVariable}, " +
                $"outputVariable = {outputVariable}");

            /* Since out variable need not be assigned we can directly create and use it in certain routines.
             * Int32.TryParse() is a great example */
            string strNumber = "15";
            Int32.TryParse(strNumber, out int result); 
            Console.WriteLine($"String 15 converted to int {result}");
        }

        public static void DemonstrateAnonymousFunction()
        {
            Console.WriteLine();
            Console.WriteLine("Demonstrating AnonymousFunction:");
            GenerateInteger Zero = new GenerateInteger(() => 0);
            Console.WriteLine("Generate integer Zero() generates: " + Zero());
            GenerateInteger RandomInteger = new GenerateInteger(() => (new Random()).Next());
            Console.WriteLine("Generate integer RandomInteger() generates: " + RandomInteger());
            GenerateInteger CurrentMonth = new GenerateInteger(() => DateTime.Now.Month);
            Console.WriteLine("Generate integer CurrentMonth() generates: " + CurrentMonth());
        }

        //C# has inbuilt support for HashSet, HashTables and Dictionaries. 
        public static void DemonstrateHashSet()
        {
            Console.WriteLine();
            Console.WriteLine("Demonstrating HashSet:");
            int[] arrayWithDuplicates = { 1, -11, 44, 101, 1, 3, 54, 44, -2, -11 };
            Console.WriteLine($"Original Array: {String.Join(",", arrayWithDuplicates)}");
            int[] arrayWithoutDuplicates = RemoveDuplicates(arrayWithDuplicates);
            Console.WriteLine($"Array w/o duplicates (created using HashSet): {String.Join(",", arrayWithoutDuplicates)}");

        }

        #region Helpers

        delegate int GenerateInteger();
        public static void TestRefAndOut(ref int i, out int j)
        {
            j = i;
            i = 0;
        }

        static int[] RemoveDuplicates(int[] original)
        {
            if (original.Length <= 1)
                return original;
            HashSet<int> hs = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int x in original)
            {
                if (!hs.Contains(x))
                    result.Add(x);
                         
                hs.Add(x);
            }
            return result.ToArray();
        }

        #endregion

    }
}
