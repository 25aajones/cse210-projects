using System;

class Program
{
    static void Main()
    {
        Goals goalManager = new Goals();
        int choice;
        do
        {
            Menu.Display(goalManager.GetScore());
            choice = Menu.GetChoice();
            goalManager.HandleChoice(choice);
        } while (choice != 6);
    }
}
