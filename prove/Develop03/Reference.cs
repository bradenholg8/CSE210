public class Reference
{
    private int startVerse;
    private int endVerse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(':');
        startVerse = int.Parse(parts[1].Split('-')[0]);
        endVerse = parts[1].Contains('-') ? int.Parse(parts[1].Split('-')[1]) : startVerse;
    }

    public string GetFormattedReference()
    {
        if (startVerse == endVerse)
            return $"{startVerse}";
        else
            return $"{startVerse}-{endVerse}";
    }
}
