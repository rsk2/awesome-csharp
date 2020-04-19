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
            Console.ReadLine();
        }

        public static void DemonstrateStringJoin()
        {
            Console.WriteLine("Demonstrating String.Join():");
            //String.Join provides us more readable syntax and we don't need to write a loop
            int[] intArray = new int[] { 1, 2, 3, 4, 10 };
            Console.WriteLine("Integer array: ({0})", string.Join(",", intArray));

            //Below lines show that we can use String.Join with list 
            List<float> floatList = new List<float> { 1.3f, 2.0f, 4.5f, 1.22f, 7.8f};
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
    }
}
