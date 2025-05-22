public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    //Setters
    // public void SetTop(int top)
    // {
    //     _top = top;
    // }

    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }

    //Getters
    // public int GetTop()
    // {
    //     return _top;
    // }

    // public int GetBottom()
    // {
    //     return _bottom;
    // }

    public string GetFractionString()
    {
        string fString = $"{_top}/{_bottom}";
        return fString;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}