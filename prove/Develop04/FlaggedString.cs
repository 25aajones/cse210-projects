class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt)
    {
        _prompt = prompt;
        _hasBeenUsed = false;
    }

    public string GetPrompt() => _prompt;

    public bool HasBeenUsed
    {
        get => _hasBeenUsed;
        set => _hasBeenUsed = value;
    }
}
