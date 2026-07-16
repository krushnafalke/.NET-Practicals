using System;

class Pen : StationeryItem
{
    public string InkColor;
    public string PenType;

    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine(InkColor);
        Console.WriteLine(PenType);
    }

    public override double CalculateDiscount(double amount)
    {
        return amount * 0.05;
    }
}