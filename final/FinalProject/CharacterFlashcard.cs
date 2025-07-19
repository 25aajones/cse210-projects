public class CharacterFlashcard : Flashcard
{
    public string Radical { get; set; }
    public int StrokeCount { get; set; }

    public override void ShowBack()
    {
        base.ShowBack();
        Console.WriteLine($"Radical: {Radical} | Strokes: {StrokeCount}");
    }

    public void ShowRadicalInfo()
    {
        Console.WriteLine($"Radical: {Radical}");
        Console.WriteLine($"Stroke Count: {StrokeCount}");
    }
}
