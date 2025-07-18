using System;

namespace FinalProject
{
    public class WordFlashcard : Flashcard
    {
        public string Example { get; set; }
        public string PartOfSpeech { get; set; }

        public WordFlashcard(int id, string chinese, string pinyin, string english, int hskLevel, string example, string partOfSpeech)
            : base(id, chinese, pinyin, english, hskLevel)
        {
            Example = example;
            PartOfSpeech = partOfSpeech;
        }

        public override void ShowFront()
        {
            Console.WriteLine($"[Word] {Chinese} ({Pinyin})");
        }

        public override void ShowBack()
        {
            Console.WriteLine($"English: {English}, HSK Level: {HSKLevel}");
            Console.WriteLine($"Part of Speech: {PartOfSpeech}");
            Console.WriteLine($"Example: {Example}");
        }

        public void ShowExampleSentence()
        {
            Console.WriteLine($"Example Sentence: {Example}");
        }
    }
}
