using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcomeMessage();

        string userName = getUserName();
        int userNumber = getUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void displayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string getUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int getUserNumber()
    {
        int number;
        bool validInput = false;
        do
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            validInput = int.TryParse(input, out number);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!validInput);

        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
