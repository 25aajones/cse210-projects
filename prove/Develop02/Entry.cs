using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Response { get; set; }
    public string Prompt { get; set; }

    public void CreateEntry()
    {
        Prompt = GetRandomPrompt();
        Console.WriteLine(Prompt);
        Console.Write("> ");
        Response = Console.ReadLine();
        Date = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
