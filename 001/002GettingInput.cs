using System;

namespace CSharp._001
{
    class GettingInput
    {
        // This program will use the @params from the CLI arguments!
        static void Main(string[] args)
        {
            // From the Debug menu, i specified args[0] as Johnny & args[1] as Diamond for the arguments.
            Console.WriteLine("Hello, {0} {1}", args[0], args[1]);
            Console.WriteLine("Welcome to the C# Station Tutorial!");
            Console.ReadLine();
        }
    }
}
