using System;

class Marker : StationeryItem
{
    public bool Permanent;

    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine(Permanent);
    }

    public override double CalculateDiscount(double amount)
    {
        return amount * 0.08;
    }
}