using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class SpacedRepetitionScheduler
    {
        private Dictionary<int, DateTime> reviewSchedule = new Dictionary<int, DateTime>();

        public void ScheduleNextReview(Flashcard card, bool remembered)
        {
            int daysUntilNextReview = remembered ? 3 : 1;

            if (reviewSchedule.ContainsKey(card.Id))
            {
                reviewSchedule[card.Id] = DateTime.Now.AddDays(daysUntilNextReview);
            }
            else
            {
                reviewSchedule.Add(card.Id, DateTime.Now.AddDays(daysUntilNextReview));
            }
        }

        public bool IsDueForReview(Flashcard card)
        {
            if (!reviewSchedule.ContainsKey(card.Id))
                return true; // Never reviewed, so it is due

            return DateTime.Now >= reviewSchedule[card.Id];
        }

        public List<Flashcard> FilterDueCards(List<Flashcard> allCards)
        {
            List<Flashcard> dueCards = new List<Flashcard>();
            foreach (var card in allCards)
            {
                if (IsDueForReview(card))
                {
                    dueCards.Add(card);
                }
            }
            return dueCards;
        }
    }
}
