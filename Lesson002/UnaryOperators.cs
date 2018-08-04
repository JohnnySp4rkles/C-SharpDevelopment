using System;

namespace CSharp.Lesson002 {
    class UnaryOperators {

        static void Main(string[] args) {
            int unary = 0;

            Console.WriteLine("Unary: {0}", unary);
            Console.WriteLine("preIncrement: {0}", ++unary);
            Console.WriteLine("preDecrement: {0}", --unary);
            Console.WriteLine("postDecrement: {0}", unary--);
            Console.WriteLine("postIncrement: {0}", unary++);
            Console.WriteLine("sByte: {0}", (sbyte)(~unary));

            Console.ReadLine();
        }
    }
}