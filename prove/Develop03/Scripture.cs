using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string reference;
    private string[] text;
    private bool[] hiddenWords;

    public Scripture(string reference, string[] text)
    {
        this.reference = reference;
        this.text = text;
        hiddenWords = new bool[text.Length];
    }

    public void Display()
    {
        Console.WriteLine(reference);
        for (int i = 0; i < text.Length; i++)
        {
            if (hiddenWords[i])
                Console.Write("_ ");
            else
                Console.Write(text[i] + " ");
        }
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
    }

    public void HideWords()
    {
        Random rand = new Random();
        int wordsToHide = rand.Next(1, text.Length / 3);

        List<int> indices = Enumerable.Range(0, text.Length).ToList();
        indices = indices.OrderBy(x => rand.Next()).ToList();

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = indices[i];
            hiddenWords[index] = true;
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWords.All(x => x);
    }
}
