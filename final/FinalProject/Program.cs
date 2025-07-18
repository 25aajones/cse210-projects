using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Chinese Flashcard App!");

            var userManager = new UserManager();
            userManager.LoadAllUsers();

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            var user = userManager.Login(username);
            if (user == null)
            {
                Console.Write("New user detected. Set your daily goal: ");
                int dailyGoal = int.Parse(Console.ReadLine());
                bool registered = userManager.Register(username, dailyGoal);
                if (!registered)
                {
                    Console.WriteLine("Registration failed. Username may already exist.");
                    return;
                }
                user = userManager.Login(username);
            }

            MainMenu.Show(user);
        }
    }
}
