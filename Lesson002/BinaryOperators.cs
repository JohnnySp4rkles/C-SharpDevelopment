using System;

namespace CSharp.Lesson002 {
    class BinaryOperators {

        static void Main(string[] args) {
            int x = 7, y = 5;

            Console.WriteLine("x + y: {0}", x + y); // x+y: 12
            Console.WriteLine("x - y: {0}", x - y); // x-y: 2
            Console.WriteLine("x * y: {0}", x * y); // x*y: 35
            Console.WriteLine("x / y: {0}", x / y); // x/y: 1
            Console.WriteLine("x / y: {0}", (float)x / (float)y); // x/y: 1.4
            Console.WriteLine("x % y: {0}", x % y); // x%y: 2
            Console.WriteLine("(x % y) + x: {0}", (x % y) + x); // (x%y) + x: 9
            Console.ReadLine();
        }
    }
}