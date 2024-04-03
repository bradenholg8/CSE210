using System;
using System.Collections.Generic;

public class TravelPlannerApp
{
    private List<Destination> destinations;
    private List<Accommodation> accommodations;
    private List<Activity> activities;
    private User user;

    public TravelPlannerApp(string userName)
    {
        destinations = new List<Destination>();
        accommodations = new List<Accommodation>();
        activities = new List<Activity>();
        user = new User(userName);
    }

    public void AddDestination(string name, string description, string location)
    {
        Destination destination = new Destination(name, description, location);
        destinations.Add(destination);
    }

    public void AddAccommodation(string name, string type, decimal pricePerNight, int availability)
    {
        Accommodation accommodation = new Accommodation(name, type, pricePerNight, availability);
        accommodations.Add(accommodation);
    }

    public void AddActivity(string name, string type, TimeSpan duration, decimal cost)
    {
        Activity activity = new Activity(name, type, duration, cost);
        activities.Add(activity);
    }

    public void CreateTrip()
    {
        Console.WriteLine("Welcome to the Travel Planner App!");
        Console.WriteLine("Please provide the following details:");

        // Get destination details
        Console.Write("Destination Name: ");
        string destinationName = Console.ReadLine();

        Console.Write("Destination Description: ");
        string destinationDescription = Console.ReadLine();

        Console.Write("Destination Location: ");
        string destinationLocation = Console.ReadLine();

        // Add destination
        AddDestination(destinationName, destinationDescription, destinationLocation);

        // Get accommodation details
        Console.Write("Accommodation Name: ");
        string accommodationName = Console.ReadLine();

        Console.Write("Accommodation Type: ");
        string accommodationType = Console.ReadLine();

        Console.Write("Accommodation Price Per Night: ");
        decimal accommodationPricePerNight = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Accommodation Availability: ");
        int accommodationAvailability = Convert.ToInt32(Console.ReadLine());

        // Add accommodation
        AddAccommodation(accommodationName, accommodationType, accommodationPricePerNight, accommodationAvailability);

        // Get activity details
        Console.Write("Number of Activities: ");
        int numberOfActivities = Convert.ToInt32(Console.ReadLine());

        List<string> activityNames = new List<string>();
        for (int i = 0; i < numberOfActivities; i++)
        {
            Console.Write($"Activity {i + 1} Name: ");
            activityNames.Add(Console.ReadLine());
        }

        // Create trip
        Console.Write("Total Budget: ");
        decimal totalBudget = Convert.ToDecimal(Console.ReadLine());

        CreateTrip(destinationName, accommodationName, activityNames, totalBudget);
    }

    public void CreateTrip(string destinationName, string accommodationName, List<string> activityNames, decimal totalBudget)
    {
        // Find destination by name
        Destination destination = destinations.Find(d => d.Name == destinationName);
        if (destination == null)
        {
            Console.WriteLine("Destination not found.");
            return;
        }

        // Find accommodation by name
        Accommodation accommodation = accommodations.Find(a => a.Name == accommodationName);
        if (accommodation == null)
        {
            Console.WriteLine("Accommodation not found.");
            return;
        }

        // Find activities by names
        List<Activity> selectedActivities = new List<Activity>();
        foreach (var activityName in activityNames)
        {
            Activity activity = activities.Find(a => a.Name == activityName);
            if (activity != null)
            {
                selectedActivities.Add(activity);
            }
        }

        // Create budget
        Budget budget = new Budget(totalBudget); // Adjust budget allocation as needed

        // Create trip
        Trip trip = new Trip(destination, accommodation, selectedActivities, budget);
        user.SavedTrips.Add(trip);
        Console.WriteLine("Trip created successfully.");
    }

    public void DisplayTripDetails(int tripIndex)
    {
        if (tripIndex >= 0 && tripIndex < user.SavedTrips.Count)
        {
            Trip trip = user.SavedTrips[tripIndex];
            Console.WriteLine($"Trip to {trip.Destination.Name}, {trip.Destination.Location}");
            Console.WriteLine($"Accommodation: {trip.Accommodation.Name} ({trip.Accommodation.Type}) - {trip.Accommodation.PricePerNight}$ per night");
            Console.WriteLine("Activities:");
            foreach (var activity in trip.Activities)
            {
                Console.WriteLine($"- {activity.Name}: {activity.Cost}$ ({activity.Duration.TotalHours} hours)");
            }
            Console.WriteLine($"Total Budget: {trip.Budget.TotalAmount}$");
        }
        else
        {
            Console.WriteLine("Invalid trip index.");
        }
    }
}