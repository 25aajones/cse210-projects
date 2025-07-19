using System;
using System.Threading;

public class BreakManager
{
    public void StartBreak(int seconds = 5)
    {
        Console.WriteLine($"\nTake a short break! Resuming in {seconds} seconds...");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rResuming in {i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\nBreak over. Let's continue!\n");
    }
}
