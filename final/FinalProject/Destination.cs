public class Destination
{
    public string Name { get; }
    public string Description { get; }
    public string Location { get; }

    public Destination(string name, string description, string location)
    {
        Name = name;
        Description = description;
        Location = location;
    }
}