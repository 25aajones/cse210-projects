using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> allScriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),

            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),

            new Scripture(new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."),

            new Scripture(new Reference("Alma", 37, 6),
                "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise.")
        };

        HashSet<int> usedIndexes = new HashSet<int>();
        bool userQuitEarly = false;

        while (usedIndexes.Count < allScriptures.Count)
        {
            Console.Clear();
            Console.WriteLine("Select a scripture to memorize:\n");

            List<int> availableIndexes = new List<int>();
            for (int i = 0; i < allScriptures.Count; i++)
            {
                if (!usedIndexes.Contains(i))
                {
                    availableIndexes.Add(i);
                    Console.WriteLine($"{availableIndexes.Count}. {allScriptures[i].GetReference()}");
                }
            }

            int choice = -1;
            while (choice < 1 || choice > availableIndexes.Count)
            {
                Console.Write("\nEnter a number (1-" + availableIndexes.Count + "): ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice) || choice < 1 || choice > availableIndexes.Count)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    choice = -1;
                }
            }

            int selectedIndex = availableIndexes[choice - 1];
            Scripture scripture = allScriptures[selectedIndex];
            usedIndexes.Add(selectedIndex);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words hidden. Memorization complete.");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words, type 'hint' to reveal one, or type 'quit':");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                    return;
                else if (input == "hint")
                    scripture.RevealOneWord();
                else
                    scripture.HideRandomWords();
            }

            if (usedIndexes.Count < allScriptures.Count)
            {
                Console.Write("\nWould you like to memorize another scripture? (y/n): ");
                string again = Console.ReadLine().Trim().ToLower();
                if (again != "y")
                {
                    userQuitEarly = true;
                    break;
                }
            }
        }

        Console.WriteLine();
        if (userQuitEarly)
        {
            Console.WriteLine("Thanks for memorizing! Come back and finish the rest when you're ready.");
        }
        else
        {
            Console.WriteLine("You have completed all available scriptures. Great job!");
        }
    }
}
