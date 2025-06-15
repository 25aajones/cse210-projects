using System;

class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Breathing Activity");
        Console.WriteLine(" 2. Reflection Activity");
        Console.WriteLine(" 3. Listing Activity");
        Console.WriteLine(" 4. Gratitude Activity");
        Console.WriteLine(" 5. Quit");
        Console.Write("Select a choice from the menu: ");
        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        return 0;
    }
}
