using System;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        string userChoice = "";

        while (userChoice != "5")
        {
            DisplayMenu();
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry entry = new Entry();
                entry.CreateEntry();
                newJournal.entries.Add(entry);
            }
            else if (userChoice == "2")
            {
                newJournal.Display();
            }
            else if (userChoice == "3")
            {
                Console.Write("Enter filename to load: ");
                string file = Console.ReadLine();
                newJournal.ReadFromFile(file);
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter filename to save: ");
                string file = Console.ReadLine();
                newJournal.SaveToFile(file);
            }
            else if (userChoice != "5")
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load journal from file");
        Console.WriteLine("4. Save journal to file");
        Console.WriteLine("5. Quit");
        Console.Write("Select an option: ");
    }
}
