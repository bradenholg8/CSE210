class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            Console.WriteLine("Enter the duration (in seconds):");
            int duration = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity(duration);
                    breathingActivity.StartActivity();
                    breathingActivity.PerformActivity();
                    breathingActivity.EndActivity();
                    break;

                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
                    reflectionActivity.StartActivity();
                    reflectionActivity.PerformActivity();
                    reflectionActivity.EndActivity();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity(duration);
                    listingActivity.StartActivity();
                    listingActivity.PerformActivity();
                    listingActivity.EndActivity();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
