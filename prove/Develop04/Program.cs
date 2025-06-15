using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        int choice;
        do
        {
            choice = menu.DisplayMenu();
            BaseActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(
                        "Breathing Activity",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                    );
                    break;
                case 2:
                    activity = new ReflectionActivity(
                        "Reflection Activity",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                    );
                    break;
                case 3:
                    activity = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                    );
                    break;
                case 4:
                    activity = new GratitudeActivity(
                        "Gratitude Activity",
                        "This activity invites you to reflect and record something you're grateful for."
                    );
                    break;
                case 5:
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Try again.");
                    break;
            }

            if (activity != null)
                activity.RunActivity();

        } while (choice != 5);
    }
}
