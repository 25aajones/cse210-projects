using System;

namespace FinalProject
{
    public abstract class Flashcard
    {
        public int Id { get; set; }
        public string Chinese { get; set; }
        public string Pinyin { get; set; }
        public string English { get; set; }
        public int HSKLevel { get; set; }

        public Flashcard(int id, string chinese, string pinyin, string english, int hskLevel)
        {
            Id = id;
            Chinese = chinese;
            Pinyin = pinyin;
            English = english;
            HSKLevel = hskLevel;
        }

        public abstract void ShowFront();
        public abstract void ShowBack();
    }
}
