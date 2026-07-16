using System;

class StationeryItem : Product, IBill
{
    private int itemId;
    private string itemName;
    private string category;
    private string brand;
    private double price;
    private int quantity;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }

        set
        {
            if (value <= 0)
                throw new InvalidPriceException();

            price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }

        set
        {
            if (value <= 0)
                throw new InvalidQuantityException();

            quantity = value;
        }
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine(ItemId);
        Console.WriteLine(ItemName);
        Console.WriteLine(Category);
        Console.WriteLine(Brand);
        Console.WriteLine(Price);
        Console.WriteLine(Quantity);
    }

    public void UpdateQuantity(int qty)
    {
        Quantity = qty;
    }

    public override double CalculateDiscount(double amount)
    {
        return amount;
    }

    public virtual void GenerateBill(int qty)
    {
        double amount = Price * qty;

        double discount = CalculateDiscount(amount);

        double gst = (amount - discount) * 0.18;

        double total = amount - discount + gst;

        Console.WriteLine("---------------------------");
        Console.WriteLine("Item      : " + ItemName);
        Console.WriteLine("Price     : " + Price);
        Console.WriteLine("Quantity  : " + qty);
        Console.WriteLine("Discount  : " + discount);
        Console.WriteLine("GST       : " + gst);
        Console.WriteLine("Total     : " + total);
        Console.WriteLine("---------------------------");
    }
}