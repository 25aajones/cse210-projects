using System;
using System.Collections.Generic;
using System.Threading;

abstract class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void RunActivity()
    {
        DisplayGreeting();
        StartTimer();
        OnStart();

        while (!HasTimeExpired())
            OnRun();

        OnEnd();
        DisplayEnding();
    }

    private void DisplayGreeting()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            Console.Write("Please enter a valid positive number: ");
        Console.WriteLine("\nGet ready...");
        Spinner(3);
    }

    private void DisplayEnding()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You’ve completed the {_name} for {_duration} seconds.");
        Spinner(3);
    }

    protected void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    protected bool HasTimeExpired() => DateTime.Now >= _endTime;

    protected void Spinner(int seconds)
    {
        string[] frames = { "/", "-", "\\", "|" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{frames[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r   \r");
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
    }


    protected void CountdownOnly(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rYou may begin in: {i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r                         \r");
    }


    protected void CountdownInlineOverwrite(string message, int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string output = $"{message}{i}";
            Console.Write($"\r{output.PadRight(Console.WindowWidth)}");
            Thread.Sleep(1000);
        }
        Console.Write($"\r{message.PadRight(Console.WindowWidth)}");
        Console.WriteLine();
    }

    protected T PickRandom<T>(List<T> list)
    {
        var rnd = new Random();
        return list[rnd.Next(list.Count)];
    }

    protected abstract void OnStart();
    protected abstract void OnRun();
    protected abstract void OnEnd();
}
