public class Activity
{
    public string Name { get; }
    public string Type { get; }
    public TimeSpan Duration { get; }
    public decimal Cost { get; }

    public Activity(string name, string type, TimeSpan duration, decimal cost)
    {
        Name = name;
        Type = type;
        Duration = duration;
        Cost = cost;
    }
}