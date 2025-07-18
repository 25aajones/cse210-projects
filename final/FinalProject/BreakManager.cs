using System;
using System.Threading;

namespace FinalProject
{
    public class BreakManager
    {
        private int cardsPerBreak;
        private int breakDurationSeconds;

        public BreakManager(int cardsPerBreak = 5, int breakDurationSeconds = 30)
        {
            this.cardsPerBreak = cardsPerBreak;
            this.breakDurationSeconds = breakDurationSeconds;
        }

        public void CheckBreak(int currentCardIndex)
        {
            if (currentCardIndex > 0 && currentCardIndex % cardsPerBreak == 0)
            {
                Console.WriteLine($"\nTake a short break! Resuming in {breakDurationSeconds} seconds...");
                Thread.Sleep(breakDurationSeconds * 1000);
                Console.Clear();
            }
        }
    }
}
