using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStart
{
    class Program
    {
        static void Main(string[] args)
        {
            DemonstrateStringJoin();
            DemonstrateStringInterpolation();
            DemonstrateRefVsOut();
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
            Console.WriteLine();
        }

        public static void DemonstrateStringInterpolation()
        {
            Console.WriteLine("Demonstrating String Interpolation:");
            int i = 10, j = 20;
            //String interpolation provides a more readable and convenient syntax to create formatted strings
            Console.WriteLine($"Adding {i} with {j} gives {i+j}");
            Console.WriteLine();
        }

        public static void DemonstrateRefVsOut()
        {
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
            Console.WriteLine();
        }

        public static void TestRefAndOut(ref int i, out int j)
        {
            j = i;
            i = 0;
        }

    }
}
