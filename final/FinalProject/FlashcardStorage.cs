using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class FlashcardStorage
{
    private readonly string builtInPath = "data/built_in_flashcards.json";
    private readonly string userFlashcardsPath = "data/user_flashcards.json";

    public List<Flashcard> LoadBuiltInFlashcards()
    {
        if (!File.Exists(builtInPath))
            return new List<Flashcard>();

        string json = File.ReadAllText(builtInPath);
        return JsonConvert.DeserializeObject<List<Flashcard>>(json, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });
    }

    public List<Flashcard> LoadUserFlashcards()
    {
        if (!File.Exists(userFlashcardsPath))
            return new List<Flashcard>();

        string json = File.ReadAllText(userFlashcardsPath);
        return JsonConvert.DeserializeObject<List<Flashcard>>(json, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });
    }

    public void SaveUserFlashcards(List<Flashcard> flashcards)
    {
        string json = JsonConvert.SerializeObject(flashcards, Formatting.Indented, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });

        File.WriteAllText(userFlashcardsPath, json);
    }
    public List<Flashcard> LoadAllFlashcards()
    {
        var all = new List<Flashcard>();
        all.AddRange(LoadBuiltInFlashcards());
        all.AddRange(LoadUserFlashcards());
        return all;
    }
}
