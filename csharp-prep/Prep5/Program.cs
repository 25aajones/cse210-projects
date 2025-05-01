using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }
        static int SquaredNumber(int num) {
            int square = num * num;
            return square;
        }
        static void DisplayResult(string name, int square) {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}