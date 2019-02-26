using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("ADD");
            Console.WriteLine(c + "\n");
            c = a - b;
            Console.WriteLine("SUBTRACT");
            Console.WriteLine(c + "\n");
            c = a * b;
            Console.WriteLine("MULTIPLY");
            Console.WriteLine(c + "\n");
            c = a / b;
            Console.WriteLine("DIVIDE");
            Console.WriteLine(c + "\n");
        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();
        }
    }
}
