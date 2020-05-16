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
        /// Different ways to initialize arrays
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
        /// Different ways to initialize tuples
        /// </summary>
        public static void InitializeTuples()
        {
            //1. Using the Tuple constructor
            var tupleOne = new Tuple<int, string> ( 1, "One" );

            //2. Using the static method Create
            var tupleTwo = Tuple.Create(1, "One");

        }


    }

}
