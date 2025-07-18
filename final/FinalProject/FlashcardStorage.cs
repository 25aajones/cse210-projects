using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FinalProject
{
    public static class FlashcardStorage
    {
        private const string BuiltInFile = "data/built_in_flashcards.json";
        private const string UserFile = "data/user_flashcards.json";

        public static List<Flashcard> LoadAllFlashcards()
        {
            var allCards = new List<Flashcard>();

            allCards.AddRange(LoadFlashcardsFromFile(BuiltInFile));
            allCards.AddRange(LoadFlashcardsFromFile(UserFile));

            return allCards;
        }

        private static List<Flashcard> LoadFlashcardsFromFile(string filePath)
        {
            var flashcards = new List<Flashcard>();

            if (!File.Exists(filePath))
                return flashcards;

            string json = File.ReadAllText(filePath);
            var rawCards = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);

            foreach (var data in rawCards)
            {
                string type = data["Type"].ToString();
                int id = Convert.ToInt32(data["Id"]);
                string chinese = data["Chinese"].ToString();
                string pinyin = data["Pinyin"].ToString();
                string english = data["English"].ToString();
                int hsk = Convert.ToInt32(data["HSKLevel"]);

                if (type == "Character")
                {
                    string radical = data["Radical"].ToString();
                    int strokes = Convert.ToInt32(data["StrokeCount"]);
                    flashcards.Add(new CharacterFlashcard(id, chinese, pinyin, english, hsk, radical, strokes));
                }
                else if (type == "Word")
                {
                    string example = data["Example"].ToString();
                    string pos = data["PartOfSpeech"].ToString();
                    flashcards.Add(new WordFlashcard(id, chinese, pinyin, english, hsk, example, pos));
                }
            }

            return flashcards;
        }
    }
}
