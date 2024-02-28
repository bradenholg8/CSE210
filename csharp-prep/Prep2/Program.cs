using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageStr = Console.ReadLine();

        if (int.TryParse(gradePercentageStr, out int percent))
        {
            string grade = "";
            string sign = "";

            if (percent >= 90)
            {
                grade = "A";
            }
            else if (percent >= 80)
            {
                grade = "B";
            }
            else if (percent >= 70)
            {
                grade = "C";
            }
            else if (percent >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            int lastDigit = percent % 10;
            if (grade != "F")
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

            if (grade == "A" && sign == "+")
            {
                grade = "A";
                sign = "";
            }
            else if (grade == "F" && sign == "-")
            {
                grade = "F";
                sign = "";
            }

            Console.WriteLine($"Your grade is: {grade}{sign}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You did not pass.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid percentage.");
        }
    }
}
