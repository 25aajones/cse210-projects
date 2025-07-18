using System;
using System.Collections.Generic;

namespace FinalProject
{
    public static class MainMenu
    {
        public static void Show(UserProfile user)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome, {user.Username}!");
                Console.WriteLine("1. Study Flashcards");
                Console.WriteLine("2. Add New Flashcard");
                Console.WriteLine("3. Exit");
                Console.Write("\nChoose an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        HandleStudy(user);
                        break;
                    case "2":
                        FlashcardCreator.AddNewFlashcard();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void HandleStudy(UserProfile user)
        {
            List<Flashcard> allCards = FlashcardStorage.LoadAllFlashcards();
            var scheduler = new SpacedRepetitionScheduler();
            var breakManager = new BreakManager();

            List<Flashcard> dueCards = scheduler.FilterDueCards(allCards);

            if (dueCards.Count == 0)
            {
                Console.WriteLine("No flashcards are due for review.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            var session = new StudySession(dueCards, user);
            for (int i = 0; i < dueCards.Count; i++)
            {
                Console.Clear();
                dueCards[i].ShowFront();
                Console.WriteLine("\nPress Enter to flip...");
                Console.ReadLine();
                dueCards[i].ShowBack();

                Console.Write("\nDid you remember it? (y/n): ");
                bool remembered = Console.ReadLine()?.ToLower() == "y";

                scheduler.ScheduleNextReview(dueCards[i], remembered);
                if (remembered)
                    user.IncrementProgress(1);

                breakManager.CheckBreak(i);
            }

            user.SaveProfile();
            Console.WriteLine($"\nSession complete. You studied {user.Progress} cards today.");
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}
