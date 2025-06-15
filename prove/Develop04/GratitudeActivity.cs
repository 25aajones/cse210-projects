using System;
using System.Collections.Generic;

class GratitudeActivity : BaseActivity
{
    private List<string> _gratitudeEntries = new List<string>();

    public GratitudeActivity(string name, string description)
        : base(name, description)
    {
        _duration = 30; // hardcoded duration in seconds
    }

    protected override void OnStart()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.WriteLine("\nTake a moment to list the things you're grateful for.");
        Console.WriteLine($"You will have {_duration} seconds.");
        CountdownOnly(3);
        Console.WriteLine("Start listing (press Enter after each):");
        StartTimer(); 
    }

    protected override void OnRun()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            _gratitudeEntries.Add(input);
        }
    }

    protected override void OnEnd()
    {
        Console.WriteLine($"\nYou listed {_gratitudeEntries.Count} things you're grateful for.");
    }
}
