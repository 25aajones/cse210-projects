public class WordFlashcard : Flashcard
{
    public override void ShowFront()
    {
        Console.WriteLine($"Character: {Chinese}");
        Console.WriteLine($"Pinyin   : {Pinyin}");
    }

    public override void ShowBack()
    {
        Console.WriteLine($"Meaning  : {English}");
    }
}
