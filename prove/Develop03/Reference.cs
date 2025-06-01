public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = -1; // indicates no range
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (endVerse == -1)
            return $"{book} {chapter}:{verse}";
        else
            return $"{book} {chapter}:{verse}-{endVerse}";
    }
}
