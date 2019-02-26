using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string aMessage = "Hello World!";
            aMessage = "World!";
            Console.WriteLine("Hello " + aMessage);
            Console.WriteLine($"The current time is {DateTime.Now}");
        }
    }
}
