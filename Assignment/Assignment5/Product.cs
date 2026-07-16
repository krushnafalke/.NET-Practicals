using System;


class Product
{
    public int Product_Id;
    public string Product_Name;
    public double Price;
    public int Stock;

    public Product(int id, string name, double price, int stock)
    {
        Product_Id = id;
        Product_Name = name;
        Price = price;
        Stock = stock;
    }
}