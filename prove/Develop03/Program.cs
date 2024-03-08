using System;

class Program
{
    static void Main(string[] args)
    {
        string referenceString = "John 3:16";
        string[] scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.".Split(' ');

        Scripture scripture = new Scripture(referenceString, scriptureText);

        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideWords();
            Console.Clear();
        }
        Console.WriteLine("End of program.");
    }
}
