using System.Collections.Generic;

public class UserProfile
{
    public string Name { get; set; }
    public string Username => Name; 

    public int SessionsCompleted { get; set; }
    public int DailyGoal { get; set; } = 10; 
    public int Progress => SessionsCompleted; 

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
