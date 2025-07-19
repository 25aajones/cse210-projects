using System.Collections.Generic;

public class UserProfile
{
    public string Name { get; set; }
    public string Username => Name; // For compatibility with MainMenu.cs

    public int SessionsCompleted { get; set; }
    public int DailyGoal { get; set; } = 10; // Default value
    public int Progress => SessionsCompleted; // Reuse existing logic

    public List<Flashcard> Flashcards { get; set; }

    public UserProfile()
    {
        Flashcards = new List<Flashcard>();
        SessionsCompleted = 0;
    }

    public void IncrementSessions()
    {
        SessionsCompleted++;
    }

    public string GetStats()
    {
        return $"Name: {Name}\nSessions Completed: {SessionsCompleted}\nFlashcards: {Flashcards.Count}";
    }
}
