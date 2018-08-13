using System;

namespace CSharp.Lesson002 {
    class ArrayOperations {

        static void Main(string[] args) {
            int[] numbers = { 1, 2, 3 };
            bool[][] myBools = new bool[2][];
            double[,] myDoubles = new double[2, 2];
            string[] myStrings = new string[3];

            myBools[0] = new bool[2];
            myBools[1] = new bool[1];

            // Print the elements of the numbers array
            Console.WriteLine("numbers[0]: {0}, numbers[1]: {1}, numbers[2]: {2}", numbers[0], numbers[1], numbers[2]);

            // Set values to myBools then print
            myBools[0][0] = true;
            myBools[0][1] = false;
            myBools[1][0] = true;
            Console.WriteLine("myBools[0][0]: {0}, myBools[0[1]: {1}, myBools[1][0]: {2}", myBools[0][0], myBools[0][1], myBools[1][0]);

            // Set values to the myDoubles array and print to screem
            myDoubles[0, 0] = 3.147;
            myDoubles[0, 1] = 7.157;
            myDoubles[1, 1] = 2.117;
            myDoubles[1, 0] = 56.00138917;
            Console.WriteLine("myDoubles[0, 0]: {0}, myDoubles[0, 1]: {1}, myDoubles[1, 1]: {2}, myDoubles[1, 0]: {3}",
                myDoubles[0, 0], myDoubles[0, 1], myDoubles[1, 1], myDoubles[1, 0]);

            // Set and print valies to the string array!
            myStrings[0] = "Joe";
            myStrings[1] = "Matt";
            myStrings[2] = "Robert";
            Console.WriteLine("myStrings[0]: {0}, myStrings[1]: {1}, myStrings[2]: {2}", myStrings[0], myStrings[1], myStrings[2]);

            Console.ReadLine();
        }
    }
}