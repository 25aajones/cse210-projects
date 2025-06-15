using System;
using System.Collections.Generic;

class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>()
    {
        new FlaggedString("Think of a time when you stood up for someone else."),
        new FlaggedString("Think of a time when you did something really difficult."),
        new FlaggedString("Think of a time when you helped someone in need."),
        new FlaggedString("Think of a time when you did something truly selfless.")
    };

    private List<FlaggedString> _questions = new List<FlaggedString>()
    {
        new FlaggedString("Why was this experience meaningful to you?"),
        new FlaggedString("Have you ever done anything like this before?"),
        new FlaggedString("How did you get started?"),
        new FlaggedString("How did you feel when it was complete?"),
        new FlaggedString("What made this time different than other times?"),
        new FlaggedString("What is your favorite thing about this experience?"),
        new FlaggedString("What could you learn from this experience?"),
        new FlaggedString("What did you learn about yourself?"),
        new FlaggedString("How can you keep this experience in mind?")
    };

    private string _chosenPrompt;

    public ReflectionActivity(string name, string description)
        : base(name, description) { }

    protected override void OnStart()
    {
        Console.WriteLine("\nConsider the following prompt:");
        _chosenPrompt = PickRandom(_prompts).GetPrompt();
        Console.WriteLine($"\n--- {_chosenPrompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.Write("> ");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountdownOnly(3);
    }

    protected override void OnRun()
    {
        string question = PickRandom(_questions).GetPrompt();
        Console.WriteLine($"> {question}");
        Spinner(5);
    }

    protected override void OnEnd() { }
}
