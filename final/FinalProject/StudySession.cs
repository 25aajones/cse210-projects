using System;
using System.Collections.Generic;

public class StudySession
{
    private SpacedRepetitionScheduler _scheduler;

    public StudySession(SpacedRepetitionScheduler scheduler)
    {
        _scheduler = scheduler;
    }

    public void BeginSession(UserProfile user)
    {
        Console.Clear();
        Console.WriteLine("== Study Session Started ==\n");

        List<Flashcard> dueCards = new List<Flashcard>(_scheduler.GetDueCards());

        // Remove duplicates if somehow present
        HashSet<int> seenIds = new HashSet<int>();
        List<Flashcard> uniqueDueCards = new List<Flashcard>();

        foreach (var card in dueCards)
        {
            if (!seenIds.Contains(card.Id))
            {
                seenIds.Add(card.Id);
                uniqueDueCards.Add(card);
            }
        }

        if (uniqueDueCards.Count == 0)
        {
            Console.WriteLine("No flashcards due for review. Press Enter to return.");
            Console.ReadLine();
            return;
        }

        int reviewed = 0;
        int total = uniqueDueCards.Count;

        for (int i = 0; i < total; i++)
        {
            var card = uniqueDueCards[i];

            Console.Clear();
            Console.WriteLine($"== Card {i + 1} of {total} ==");

            card.ShowFront();
            Console.WriteLine("Try to think of what it means...");
            Console.Write("Press Enter to see the answer or type 'q' to quit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "q")
                break;

            card.ShowBack();
            Console.Write("Did you get it right? (y/n): ");
            string result = Console.ReadLine().Trim().ToLower();

            if (result == "y")
                _scheduler.MarkCorrect(card);
            else
                _scheduler.MarkIncorrect(card);

            reviewed++;
        }

        Console.WriteLine($"\nSession complete! You reviewed {reviewed} out of {total} flashcards.");
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}
