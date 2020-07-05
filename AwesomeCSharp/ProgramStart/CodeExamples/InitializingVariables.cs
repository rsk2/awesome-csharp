using System;
using System.Collections.Generic;

namespace ConsoleApp1.CodeExamples
{
    /// <summary>
    /// The methods in the class visually show different techniques to initialize different types of variables
    /// </summary>
    public class InitializingVariables
    {
        /// <summary>
        /// Class has a private constructor since there is no need for this class to be instantiated.
        /// </summary>
        private InitializingVariables()
        {
        }
        /// <summary>
        /// Different ways to initialize arrays. Both techniques specified in the routine below 
        /// initialize an integer array with three integers
        /// </summary>
        private static void InitializeArrays()
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
        private static void InitializeTuples()
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
        private static void InitializeLists()
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

        /// <summary>
        /// The code visually shows you three different ways to initialize classes making use of the Helper 
        /// Employee class below. No real use of calling this routine from outside
        /// </summary>
        private void InitializeClasses()
        {
            /*1. Initialize at declaration using object initializer. Notice no need for ()
            after class name Employee */
            var employeeOne = new Employee { Name = "Rohan", Age = 45, Salary = 300 };

            //2. Initialize variable after declaration in the succeeding lines
            var employeeTwo = new Employee();
            employeeTwo.Name = "Mohan";
            employeeTwo.Age = 55;
            employeeTwo.Salary = 200 ;

            //3. Initialize using a contructor
            var employeeThree = new Employee("Sohan", 59, 400);
        }
    }

    #region Helpers
    /// <summary>
    /// Helper class Employee used to demonstrate InitializeClasses() routine above
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
        }
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    #endregion

}
