using System;
using System.Collections.Generic;

public class SpacedRepetitionScheduler
{
    public List<Flashcard> Flashcards { get; set; }
    public Dictionary<int, DateTime> NextReview { get; set; }

    public SpacedRepetitionScheduler(List<Flashcard> flashcards)
    {
        Flashcards = flashcards;
        NextReview = new Dictionary<int, DateTime>();
        ScheduleReview();
    }

    public void ScheduleReview()
    {
        foreach (var card in Flashcards)
        {
            if (!NextReview.ContainsKey(card.Id))
                NextReview[card.Id] = DateTime.Now;
        }
    }

    public List<Flashcard> GetDueCards()
    {
        List<Flashcard> due = new List<Flashcard>();
        DateTime now = DateTime.Now;

        foreach (var card in Flashcards)
        {
            if (NextReview.ContainsKey(card.Id) && NextReview[card.Id] <= now)
                due.Add(card);
        }

        return due;
    }

    public void MarkCorrect(Flashcard card)
    {
        if (NextReview.ContainsKey(card.Id))
            NextReview[card.Id] = DateTime.Now.AddDays(3);
    }

    public void MarkIncorrect(Flashcard card)
    {
        if (NextReview.ContainsKey(card.Id))
            NextReview[card.Id] = DateTime.Now.AddDays(1);
    }
}
