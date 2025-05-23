public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor: No parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor: Top only
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor: Top and Bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top
    public int GetTop()
    {
        return _top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return string representation like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value like 0.75
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
