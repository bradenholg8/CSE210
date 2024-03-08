public class Reference
{
    private string book;
    private int startChapter;
    private int startVerse;
    private int endChapter;
    private int endVerse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        book = parts[0];
        string[] verses = parts[1].Split(':');
        startChapter = int.Parse(verses[0]);
        if (verses[1].Contains('-'))
        {
            string[] verseRange = verses[1].Split('-');
            startVerse = int.Parse(verseRange[0]);
            endVerse = int.Parse(verseRange[1]);
        }
        else
        {
            startVerse = int.Parse(verses[1]);
            endVerse = startVerse;
        }
    }

    public string GetFormattedReference()
    {
        if (startChapter == endChapter && startVerse == endVerse)
            return $"{book} {startChapter}:{startVerse}";
        else if (startChapter == endChapter)
            return $"{book} {startChapter}:{startVerse}-{endVerse}";
        else
            return $"{book} {startChapter}:{startVerse} - {endChapter}:{endVerse}";
    }
}
