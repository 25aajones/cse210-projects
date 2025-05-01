using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        int numAnswer;
        int guessCount = 0;
        bool retry = true;

        while (retry == true) 
        {
        do 
        {
            Console.WriteLine("What is your guess? ");
            string answer = Console.ReadLine();
            numAnswer = int.Parse(answer);
            guessCount += 1;
        
            if (numAnswer < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (numAnswer > magicNum ) 
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine ("You guessed it!");
            }
        } while (numAnswer != magicNum);

        if (numAnswer == magicNum)
        {
            Console.WriteLine($"You guessed {guessCount} time(s)");
            Console.WriteLine("Do you want to play again? (y/n) ");
            string retryAnswer = Console.ReadLine();
            
            if (retryAnswer == "y" || retryAnswer == "yes" || retryAnswer == "Yes")
            {
                retry = true;
            }
            else if (retryAnswer == "n" || retryAnswer == "no" || retryAnswer == "No")
            {
                retry = false;
            }
        }
        }
    }
}