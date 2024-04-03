public class Trip
{
    public Destination Destination { get; }
    public Accommodation Accommodation { get; }
    public List<Activity> Activities { get; }
    public Budget Budget { get; }

    public Trip(Destination destination, Accommodation accommodation, List<Activity> activities, Budget budget)
    {
        Destination = destination;
        Accommodation = accommodation;
        Activities = activities;
        Budget = budget;
    }
}
