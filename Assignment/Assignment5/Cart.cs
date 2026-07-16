using System;

class Cart
{
    public string Product_Name;
    public int Quantity;
    public double Price;

    public Cart(string name, int qty, double price)
    {
        Product_Name = name;
        Quantity = qty;
        Price = price;
    }
}