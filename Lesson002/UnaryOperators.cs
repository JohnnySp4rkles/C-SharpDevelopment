using System;

namespace CSharp.Lesson002 {
    class UnaryOperators {

        static void Main(string[] args) {
            int unary = 0;

            Console.WriteLine("Unary: {0}", unary); // 0
            Console.WriteLine("preIncrement: {0}", ++unary); // 1
            Console.WriteLine("preDecrement: {0}", --unary); // 0
            Console.WriteLine("postDecrement: {0}", unary--); // 0
            Console.WriteLine("postIncrement: {0}", unary++); // -1
            Console.WriteLine("sByte: {0}", (sbyte)(~unary)); // -1

            Console.ReadLine();
        }
    }
}