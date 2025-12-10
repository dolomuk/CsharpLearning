using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Example 02 - GroupBy and OrderBy");

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8 , 9, 10 };

            IEnumerable<IGrouping<string, int>> groupedNumbers = number.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");

            foreach(IGrouping<string, int> group in groupedNumbers)
            {
                Console.WriteLine($"{group.Key} Numbers: {string.Join(", ", group.OrderBy(n => n))}");
            }

            //  Query Syntax to get sum of even numbers
            var sumEvenNumbers = (from gr in groupedNumbers
                                  where gr.Key == "Even"
                                  select gr.Sum()).FirstOrDefault();

            //  Method Syntax to get sum of odd numbers
            var sumOddNumbers = number.Where(n => n % 2 != 0).Sum();

            Console.WriteLine($"Sum of Even Numbers: {sumEvenNumbers}");
            Console.WriteLine($"Sum of Odd Numbers: {sumOddNumbers}");
        }
    }
}

