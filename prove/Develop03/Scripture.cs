using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random rand = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetReference()
    {
        return reference.ToString();
    }

    public string GetText()
    {
        return $"{reference.ToString()}\n\n" + string.Join(" ", words.Select(w => w.DisplayText()));
    }

    public void HideRandomWords()
    {
        int count = 3;
        var visible = words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visible.Count > 0; i++)
        {
            int index = rand.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public void RevealOneWord()
    {
        var hidden = words.Where(w => w.IsHidden()).ToList();
        if (hidden.Count > 0)
        {
            int index = rand.Next(hidden.Count);
            hidden[index].Unhide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
