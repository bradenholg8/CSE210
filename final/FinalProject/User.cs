public class User
{
    public string Name { get; }
    public List<Trip> SavedTrips { get; }

    public User(string name)
    {
        Name = name;
        SavedTrips = new List<Trip>();
    }
}