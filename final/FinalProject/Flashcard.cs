public abstract class Flashcard
{
    public string Chinese { get; set; }
    public string Pinyin { get; set; }
    public string English { get; set; }
    public int HSKLevel { get; set; }

    public Flashcard(string chinese, string pinyin, string english, int level)
    {
        Chinese = chinese;
        Pinyin = pinyin;
        English = english;
        HSKLevel = level;
    }

    public virtual void ShowFront()
    {
        Console.WriteLine($"Word: {Chinese} ({Pinyin})");
    }

    public virtual void ShowBack()
    {
        Console.WriteLine($"Meaning: {English} - HSK Level {HSKLevel}");
    }
}
