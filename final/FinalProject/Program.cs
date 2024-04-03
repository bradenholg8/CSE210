using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            TravelPlannerApp app = new TravelPlannerApp("John");

            // Interactive menu
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Trip");
                Console.WriteLine("2. Display Trip Details");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        app.CreateTrip();
                        break;
                    case "2":
                        Console.Write("Enter trip index: ");
                        int tripIndex = Convert.ToInt32(Console.ReadLine());
                        app.DisplayTripDetails(tripIndex);
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}