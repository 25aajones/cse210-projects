using System;

public class FlashcardCreator
{
    public static Flashcard CreateFlashcard()
    {
        Console.Write("Enter HSK Level (1–9): ");
        int hskLevel = int.Parse(Console.ReadLine());

        Console.Write("Enter Chinese word/character: ");
        string chinese = Console.ReadLine();

        Console.Write("Enter pinyin: ");
        string pinyin = Console.ReadLine();

        Console.Write("Enter English meaning: ");
        string english = Console.ReadLine();

        Console.Write("Is this a character flashcard? (y/n): ");
        string type = Console.ReadLine().Trim().ToLower();

        if (type == "y")
        {
            Console.Write("Enter radical: ");
            string radical = Console.ReadLine();

            Console.Write("Enter stroke count: ");
            int strokeCount = int.Parse(Console.ReadLine());

            return new CharacterFlashcard
            {
                Chinese = chinese,
                Pinyin = pinyin,
                English = english,
            };
        }
        else
        {
            Console.Write("Enter example sentence: ");
            string example = Console.ReadLine();

            return new WordFlashcard
            {
                Chinese = chinese,
                Pinyin = pinyin,
                English = english,
            };
        }
    }
}
