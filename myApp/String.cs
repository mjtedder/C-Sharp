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

            // TrimStart
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"\n[{trimmedGreeting}]");

            // TrimEnd
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"\n[{trimmedGreeting}]\n");

            // Replace method
            string statement = "I hate music!";
            Console.WriteLine(statement);
            statement = statement.Replace("hate", "love");
            Console.WriteLine(statement);
            Console.WriteLine("---------------------------------------\n");
            // toUpper and toLower method
            Console.WriteLine(statement.ToUpper());
            Console.WriteLine(statement.ToLower());
            Console.WriteLine("---------------------------------------\n");

            // Contains, StartsWith, EndsWith methods
            string songLyrics = "I had offered up what once was mine.";
            Console.WriteLine(songLyrics.Contains("offered"));
            Console.WriteLine(songLyrics.Contains("oh"));
            Console.WriteLine("Let's try this with the StartsWith method!");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine(songLyrics.StartsWith("I"));
            Console.WriteLine(songLyrics.EndsWith("mine"));
            Console.WriteLine("\n---------------END STRINGS DEMO---------------------");
        }
    }
}
