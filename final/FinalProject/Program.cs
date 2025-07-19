using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        FlashcardStorage storage = new FlashcardStorage();
        UserManager userManager = new UserManager();

        
        while (true)
        {
            UserProfile user = userManager.LoginOrCreateUser();
            SpacedRepetitionScheduler scheduler = new SpacedRepetitionScheduler(user.Flashcards);
            MainMenu menu = new MainMenu(scheduler, storage, user, userManager);
            menu.Show();
        }
    }
}
