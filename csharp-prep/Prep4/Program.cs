using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> num = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int answerNum;
        double average;
        double count;

        do {
        Console.Write("Enter a number: ");
        string answer = Console.ReadLine();
        answerNum = int.Parse(answer);
        num.Add(answerNum);

        } while (answerNum != 0);

        num.Remove(0);
        int minPos = int.MaxValue;
        foreach (int number in num) {
            if (number > 0 && number < minPos) {
                minPos = number;
            }
        }

        count = num.Count-1;
        average = num.Sum()/count;
        Console.WriteLine($"The sum is: {num.Sum()}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {num.Max()}");
        Console.WriteLine($"The smallest positive number is: {minPos}");
        
        num.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in num) {
            Console.WriteLine(number);
        }
    }
}