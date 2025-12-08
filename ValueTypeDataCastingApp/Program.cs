using System;

namespace ValueTypeDataCastingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Value Type Data Casting Application!");

            Console.Write("Enter Operator (+, -, *, /): ");
            string? operatorInput = Console.ReadLine();

            Console.Write("Enter first number: ");
            double firstNumber = double.TryParse(Console.ReadLine(), out double parsedNum1) ? parsedNum1 : double.NaN;

            Console.Write("Enter second number: ");
            double secondNumber = double.TryParse(Console.ReadLine(), out double parsedNum2) ? parsedNum2 : double.NaN;

            if(double.IsNaN(firstNumber) || double.IsNaN(secondNumber))
            {
                Console.WriteLine("Invalid number input. Please enter valid numbers.");
                return;
            }

            switch(operatorInput)
            {
                case "+":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case  "*":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case "/":
                    if(secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    break;                    
                    default:
                Console.WriteLine("Invalid operator intput. Please enter one of +, -, *, /.");
                    break;                    
            }
        }
    }
}
