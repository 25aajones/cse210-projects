public class WordFlashcard : Flashcard
{
    public string Example { get; set; }
    public string PartOfSpeech { get; set; }

    public WordFlashcard(string chinese, string pinyin, string english, int level, string example, string pos)
        : base(chinese, pinyin, english, level)
    {
        Example = example;
        PartOfSpeech = pos;
    }

    public override void ShowBack()
    {
        base.ShowBack();
        Console.WriteLine($"Example: {Example}");
        Console.WriteLine($"Part of Speech: {PartOfSpeech}");
    }
}
