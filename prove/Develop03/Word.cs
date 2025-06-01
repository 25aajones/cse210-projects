public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Unhide()
    {
        isHidden = false;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string DisplayText()
    {
        return isHidden ? new string('_', text.Length) : text;
    }
}
