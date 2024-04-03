public class Accommodation
{
    public string Name { get; }
    public string Type { get; }
    public decimal PricePerNight { get; }
    public int Availability { get; }

    public Accommodation(string name, string type, decimal pricePerNight, int availability)
    {
        Name = name;
        Type = type;
        PricePerNight = pricePerNight;
        Availability = availability;
    }
}