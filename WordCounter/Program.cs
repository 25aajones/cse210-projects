// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        WordCounter wordCounter = new WordCounter("The quick brown fox jumps over the lazy dog");
        wordCounter.DisplayWords();
    }
}


