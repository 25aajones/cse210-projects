public class CharacterFlashcard : Flashcard
{
    public string Radical { get; set; }
    public int StrokeCount { get; set; }

    public CharacterFlashcard(string chinese, string pinyin, string english, int level, string radical, int strokes)
        : base(chinese, pinyin, english, level)
    {
        Radical = radical;
        StrokeCount = strokes;
    }

    public override void ShowBack()
    {
        base.ShowBack();
        Console.WriteLine($"Radical: {Radical}, Strokes: {StrokeCount}");
    }
}
