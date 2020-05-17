using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CodeExamples
{
    public class InitializingVariables
    {
        /// <summary>
        /// Different ways to initialize arrays. Both techniques specified in the routine below 
        /// initialize an integer array with three integers
        /// </summary>
        public static void InitializeArrays()
        {
            //1. Declare array and then add values to each index
            var arrayOne = new int[3];
            arrayOne[0] = 1;
            arrayOne[1] = 2;
            arrayOne[2] = 3;

            //2. Declare and initalize on same line
            var arrayTwo = new int[] { 1, 2, 3 };
        }

        /// <summary>
        /// Different ways to initialize tuples. Both ways specified below in this routine will
        /// intialize a tuple of two items one integer and other string
        /// </summary>
        public static void InitializeTuples()
        {
            //1. Using the Tuple constructor
            var tupleOne = new Tuple<int, string> ( 1, "One" );

            //2. Using the static method Create
            var tupleTwo = Tuple.Create(1, "One");
        }

        /// <summary>
        /// Different ways to initialize lists. All three techniques specified in this routine will
        /// intialize a list of string with three items "One", "Two" and "Three"
        /// </summary>
        public static void InitializeLists()
        {
            //1. Using the List constructor
            var listOne = new List<string> { "One", "Two", "Three" };

            //2. Using the Add method
            var listTwo = new List<string>();
            listTwo.Add("One");
            listTwo.Add("Two");
            listTwo.Add("Three");

            //3. Using Indexes
            var listThree = new List<string>();
            listThree[0] = "One";
            listThree[1] = "Two";
            listThree[2] = "Three";
        }
    }

}
