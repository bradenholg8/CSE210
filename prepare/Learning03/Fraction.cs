using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int num)
    {
        numerator = num;
        denominator = 1;
    }

    public Fraction(int num, int denom)
    {
        numerator = num;
        denominator = denom;
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int num)
    {
        numerator = num;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int denom)
    {
        if (denom != 0)
            denominator = denom;
        else
            Console.WriteLine("Denominator cannot be zero.");
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
