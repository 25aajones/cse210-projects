using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class StudySession
    {
        private List<Flashcard> flashcards;
        private UserProfile user;

        public StudySession(List<Flashcard> flashcards, UserProfile user)
        {
            this.flashcards = flashcards;
            this.user = user;
        }

        public void Start()
        {
            Console.WriteLine($"Starting study session for {user.Username}...\n");

            foreach (Flashcard card in flashcards)
            {
                Console.Clear();
                card.ShowFront();
                Console.WriteLine("\nPress Enter to flip the card...");
                Console.ReadLine();

                card.ShowBack();
                Console.WriteLine("\nDid you remember it? (y/n): ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "y")
                {
                    user.IncrementProgress(1);
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }

            Console.WriteLine($"\nSession complete! Progress: {user.Progress}/{user.DailyGoal} reviewed today.");
        }
    }
}
