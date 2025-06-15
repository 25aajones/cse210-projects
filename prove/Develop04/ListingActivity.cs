using System;
using System.Collections.Generic;

class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts = new List<FlaggedString>()
    {
        new FlaggedString("Who are people that you appreciate?"),
        new FlaggedString("What are personal strengths of yours?"),
        new FlaggedString("Who are people that you have helped this week?"),
        new FlaggedString("When have you felt the Holy Ghost this month?"),
        new FlaggedString("Who are some of your personal heroes?")
    };

    private string _chosenPrompt;
    private int _entryCount = 0;

    public ListingActivity(string name, string description)
        : base(name, description) { }

    protected override void OnStart()
    {
        _chosenPrompt = PickRandom(_prompts).GetPrompt();
        Console.WriteLine($"\n--- Prompt ---\n{_chosenPrompt}\n");
        Console.WriteLine("You may begin listing after the countdown.");
        Countdown(5);
        Console.WriteLine("Start listing (one per line):");
    }

    protected override void OnRun()
    {
        Console.Write("> ");
        Console.ReadLine();
        _entryCount++;
    }

    protected override void OnEnd()
    {
        Console.WriteLine($"\nYou listed {_entryCount} items.");
    }
}
