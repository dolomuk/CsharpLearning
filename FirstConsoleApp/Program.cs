using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your first C# Console Application!");
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            
            Console.Write("Enter your age: ");

            int age = int.TryParse(Console.ReadLine(), out int parsedAge) ? parsedAge : -1;
            
            if(age == -1)
            {
                Console.WriteLine("Invalid age input. Please enter a valid number.");
                return;
            }

            Console.WriteLine($"Hello, {name}! You are {age} years old. Let's start learning C# together.");
        }
    }
}