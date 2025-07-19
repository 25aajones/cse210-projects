using System;
using System.Linq;

public class MainMenu
{
    private SpacedRepetitionScheduler _scheduler;
    private FlashcardStorage _storage;
    private UserProfile _user;
    private UserManager _userManager;

    public MainMenu(SpacedRepetitionScheduler scheduler, FlashcardStorage storage, UserProfile user, UserManager userManager)
    {
        _scheduler = scheduler;
        _storage = storage;
        _user = user;
        _userManager = userManager;
    }

    public void Show()
    {
        _scheduler.ScheduleReview(); // Ensure reviews are scheduled once at startup

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"== Flashcard App - Logged in as: {_user.Name} ==\n");
            Console.WriteLine("1. Study Flashcards");
            Console.WriteLine("2. Add Flashcard");
            Console.WriteLine("3. View Stats");
            Console.WriteLine("4. Logout");
            Console.WriteLine("5. View Flashcards");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StudySession session = new StudySession(_scheduler);
                    session.BeginSession(_user);
                    _user.IncrementSessions();
                    _storage.SaveUserFlashcards(_user.Flashcards);
                    break;

                case "2":
                    AddFlashcard();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine(_user.GetStats());
                    Console.WriteLine("\nPress Enter to return.");
                    Console.ReadLine();
                    break;

                case "4":
                    return; // Logout

                case "5":
                    ViewFlashcards();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void AddFlashcard()
    {
        Console.Clear();
        Console.WriteLine("== Add New Flashcard ==");

        Console.Write("Chinese Character: ");
        string chinese = Console.ReadLine()?.Trim();

        Console.Write("Pinyin: ");
        string pinyin = Console.ReadLine()?.Trim();

        Console.Write("English Meaning: ");
        string english = Console.ReadLine()?.Trim();

        // Check for duplicates
        bool exists = _user.Flashcards.Any(fc =>
            fc.Chinese == chinese &&
            fc.Pinyin == pinyin &&
            fc.English == english);

        if (exists)
        {
            Console.WriteLine("This flashcard already exists. Press Enter to return.");
            Console.ReadLine();
            return;
        }

        var card = new Flashcard
        {
            Chinese = chinese,
            Pinyin = pinyin,
            English = english
        };

        _user.Flashcards.Add(card); 
        _scheduler.ScheduleReview();
        _storage.SaveUserFlashcards(_user.Flashcards);

        Console.WriteLine("Flashcard added! Press Enter to continue.");
        Console.ReadLine();
    }

    private void ViewFlashcards()
    {
        Console.Clear();
        Console.WriteLine("== Your Flashcards ==\n");

        if (_user.Flashcards.Count == 0)
        {
            Console.WriteLine("You have no flashcards yet.");
        }
        else
        {
            int index = 1;
            foreach (var card in _user.Flashcards)
            {
                Console.WriteLine($"#{index++}");
                Console.WriteLine($"  Character: {card.Chinese}");
                Console.WriteLine($"  Pinyin   : {card.Pinyin}");
                Console.WriteLine($"  Meaning  : {card.English}\n");
            }
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}
