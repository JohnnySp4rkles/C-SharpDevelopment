using System;

namespace CSharp.Lesson003 {
    class IfSelection {
        static void Main(string[] args) {
            string myString;
            int myInt;

            Console.Write("Enter a number: ");
            myString = Console.ReadLine();
            myInt = Int32.Parse(myString);

            // Single Decision and Action with braces
            if(myInt > 0) {
                Console.WriteLine("Your number {0} is greater than 0", myInt);
            }

            // Single Decision and action without braces
            if (myInt < 0) Console.WriteLine("Your number {0} is less than 0", myInt);

            // Either/Or desision
            if(myInt != 0) {
                Console.WriteLine("Your number {0} is not equal to 0", myInt);
            } else {
                Console.WriteLine("Your number {0} is equal to 0", myInt);
            }

            // Multiple Case Decision
            if (myInt < 0 || myInt == 0) {
                Console.WriteLine("Your number {0} is less than or equal to zero.", myInt);
            } else if (myInt > 0 && myInt <= 10) {
                Console.WriteLine("Your number {0} is in the range from 1 to 10.", myInt);
            } else if (myInt > 10 && myInt <= 20) {
                Console.WriteLine("Your number {0} is in the range from 11 to 20.", myInt);
            } else if (myInt > 20 && myInt <= 30) {
                Console.WriteLine("Your number {0} is in the range from 21 to 30.", myInt);
            } else {
                Console.WriteLine("Your number {0} is greater than 30.", myInt);
            }

            Console.ReadLine();
        }
    }
}
