public class Flashcard
{
    public int Id { get; set; } 
    public string Chinese { get; set; }
    public string Pinyin { get; set; }
    public string English { get; set; }

    public virtual void ShowFront()
    {
        Console.WriteLine($"Word: {Chinese}  |  Pinyin: {Pinyin}");
    }

    public virtual void ShowBack()
    {
        Console.WriteLine($"English: {English}");
    }
}
