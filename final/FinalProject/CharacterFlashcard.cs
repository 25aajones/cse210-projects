using System;

namespace FinalProject
{
    public class CharacterFlashcard : Flashcard
    {
        public string Radical { get; set; }
        public int StrokeCount { get; set; }

        public CharacterFlashcard(int id, string chinese, string pinyin, string english, int hskLevel, string radical, int strokeCount)
            : base(id, chinese, pinyin, english, hskLevel)
        {
            Radical = radical;
            StrokeCount = strokeCount;
        }

        public override void ShowFront()
        {
            Console.WriteLine($"[Character] {Chinese} ({Pinyin})");
        }

        public override void ShowBack()
        {
            Console.WriteLine($"English: {English}, HSK Level: {HSKLevel}");
            Console.WriteLine($"Radical: {Radical}, Strokes: {StrokeCount}");
        }

        public void ShowRadicalInfo()
        {
            Console.WriteLine($"Radical: {Radical}, Stroke Count: {StrokeCount}");
        }
    }
}
