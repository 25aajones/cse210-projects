using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Flashcard> flashcards = new();

        Console.WriteLine("How many flashcards would you like to create?");
        if (int.TryParse(Console.ReadLine(), out int count))
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nFlashcard #{i + 1}:");
                Console.Write("Type (1 = Character, 2 = Word): ");
                string type = Console.ReadLine();

                Console.Write("Chinese: ");
                string chinese = Console.ReadLine();

                Console.Write("Pinyin: ");
                string pinyin = Console.ReadLine();

                Console.Write("English: ");
                string english = Console.ReadLine();

                Console.Write("HSK Level: ");
                int hsk = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    Console.Write("Radical: ");
                    string radical = Console.ReadLine();

                    Console.Write("Stroke Count: ");
                    int strokes = int.Parse(Console.ReadLine());

                    flashcards.Add(new CharacterFlashcard(chinese, pinyin, english, hsk, radical, strokes));
                }
                else
                {
                    Console.Write("Example Sentence: ");
                    string example = Console.ReadLine();

                    Console.Write("Part of Speech: ");
                    string pos = Console.ReadLine();

                    flashcards.Add(new WordFlashcard(chinese, pinyin, english, hsk, example, pos));
                }
            }

            Console.WriteLine("\n--- Study Session ---\n");
            foreach (var card in flashcards)
            {
                card.ShowFront();
                Console.WriteLine("Press Enter to see the back...");
                Console.ReadLine();
                card.ShowBack();
                Console.WriteLine("\n----------------------\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid number. Exiting.");
        }
    }
}
