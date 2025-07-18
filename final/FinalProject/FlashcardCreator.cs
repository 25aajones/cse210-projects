using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FinalProject
{
    public static class FlashcardCreator
    {
        private const string UserFile = "data/user_flashcards.json";

        public static void AddNewFlashcard()
        {
            Console.WriteLine("Choose flashcard type to add:");
            Console.WriteLine("1. Character Flashcard");
            Console.WriteLine("2. Word Flashcard");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                CreateCharacterFlashcard();
            else if (choice == "2")
                CreateWordFlashcard();
            else
                Console.WriteLine("Invalid choice.");
        }

        private static void CreateCharacterFlashcard()
        {
            var card = new Dictionary<string, object>();
            card["Type"] = "Character";
            card["Id"] = GenerateId();
            Console.Write("Chinese character: ");
            card["Chinese"] = Console.ReadLine();
            Console.Write("Pinyin: ");
            card["Pinyin"] = Console.ReadLine();
            Console.Write("English meaning: ");
            card["English"] = Console.ReadLine();
            Console.Write("HSK level: ");
            card["HSKLevel"] = int.Parse(Console.ReadLine());
            Console.Write("Radical: ");
            card["Radical"] = Console.ReadLine();
            Console.Write("Stroke count: ");
            card["StrokeCount"] = int.Parse(Console.ReadLine());

            AppendToFile(card);
            Console.WriteLine("Character flashcard added successfully.");
        }

        private static void CreateWordFlashcard()
        {
            var card = new Dictionary<string, object>();
            card["Type"] = "Word";
            card["Id"] = GenerateId();
            Console.Write("Chinese word: ");
            card["Chinese"] = Console.ReadLine();
            Console.Write("Pinyin: ");
            card["Pinyin"] = Console.ReadLine();
            Console.Write("English meaning: ");
            card["English"] = Console.ReadLine();
            Console.Write("HSK level: ");
            card["HSKLevel"] = int.Parse(Console.ReadLine());
            Console.Write("Example sentence: ");
            card["Example"] = Console.ReadLine();
            Console.Write("Part of speech: ");
            card["PartOfSpeech"] = Console.ReadLine();

            AppendToFile(card);
            Console.WriteLine("Word flashcard added successfully.");
        }

        private static int GenerateId()
        {
            if (!File.Exists(UserFile)) return 1000;
            var json = File.ReadAllText(UserFile);
            var list = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json) ?? new List<Dictionary<string, object>>();
            return list.Count + 1000;
        }

        private static void AppendToFile(Dictionary<string, object> newCard)
        {
            List<Dictionary<string, object>> list;

            if (File.Exists(UserFile))
            {
                string json = File.ReadAllText(UserFile);
                list = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json) ?? new List<Dictionary<string, object>>();
            }
            else
            {
                list = new List<Dictionary<string, object>>();
            }

            list.Add(newCard);
            string updatedJson = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
            Directory.CreateDirectory("data");
            File.WriteAllText(UserFile, updatedJson);
        }
    }
}
