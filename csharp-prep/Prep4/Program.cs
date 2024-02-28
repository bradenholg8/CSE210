using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = 1; // Initializing with a non-zero value to enter the loop
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to finish): ");
            string userResponse = Console.ReadLine();

            if (!int.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            numbers.Add(userNumber);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            int sum = numbers.Sum();
            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");

            // Find the smallest positive number closest to zero
            int minPositiveClosestToZero = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > 0 && number < minPositiveClosestToZero)
                {
                    minPositiveClosestToZero = number;
                }
            }
            if (minPositiveClosestToZero == int.MaxValue)
            {
                Console.WriteLine("No positive numbers were entered.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {minPositiveClosestToZero}");
            }

            // Sort the list of numbers
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
