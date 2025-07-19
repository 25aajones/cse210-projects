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

    public virtual void MarkCorrect()
    {
        // You could add logic like updating review time or score
        Console.WriteLine("Marked as correct.");
    }

    public virtual void MarkIncorrect()
    {
        // You could add logic like rescheduling review sooner
        Console.WriteLine("Marked as incorrect.");
    }
}
