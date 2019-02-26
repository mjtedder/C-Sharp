using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting a string variable
            string aMessage = "Hello World!";
            // Reassigning the variable
            aMessage = "World!";
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hello " + aMessage);
            Console.WriteLine("------------------------------------------");

            // STRING INTERPOLATION
            Console.WriteLine($"The current time is {DateTime.Now}");

            // Assigning string variable favorite bands
            string bands1 = "Umphrey's McGee";
            string bands2 = "Tedeschi Trucks";
            Console.WriteLine($"\nMy favorite bands are {bands1} and {bands2}");

            // Using .length to count the number of letters in a string
            Console.WriteLine($"\nThe band {bands1} has {bands1.Length} letters");
            Console.WriteLine("--------------------------------------------------\n");
            // STRING METHODS
            string greeting = "                        Good evening!             ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"\n[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"\n[{trimmedGreeting}]");
        }
    }
}
