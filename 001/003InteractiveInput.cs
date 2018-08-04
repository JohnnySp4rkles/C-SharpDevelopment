using System;

namespace CSharp._001
{
    class _003InteractiveInput
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name: ");
            
            // STYLE A
            Console.WriteLine("Hello {0}", Console.ReadLine());

            Console.WriteLine("What's your second name: ");
            // STYLE B
            String sName = Console.ReadLine();
            Console.Write("Hello {0}", sName);

            Console.ReadLine();

        }
    }
}
