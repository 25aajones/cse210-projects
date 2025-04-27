using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Part 1: Ask grade percentage & if-elif-else for letter grade w/ print statements
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        //Part 3: Add letter variable and change that instead of print statements
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string plus_or_minus = "";
        if (gradePercentage >= 93 || gradePercentage <= 59) {
            plus_or_minus = "";
        }
        else if (gradePercentage%10 >=7) {
            plus_or_minus = "+";
        }
        else if (gradePercentage%10 < 3) {
            plus_or_minus = "-";
        }
        else {
            plus_or_minus = "";
        }

        Console.WriteLine($"Your grade is {letter}{plus_or_minus}");
        
        //Part 2 Passed or not
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class");
        }
        else
        {
            Console.WriteLine("You did not pass the class. You can do it next time");
        }
    }
}