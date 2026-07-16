using System;

class Notebook : StationeryItem
{
    public int Pages;
    public string PaperType;

    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine(Pages);
        Console.WriteLine(PaperType);
    }

    public override double CalculateDiscount(double amount)
    {
        return amount * 0.10;
    }
}