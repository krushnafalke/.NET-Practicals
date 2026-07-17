using System;

class Vehicle
{
    public int Vehicle_Id;
    public string Vehicle_Name;
    public string Vehicle_Type;
    public string Brand;
    public double Price;
    public double Manufacturing_Year;

    public Vehicle(int id, string name, string type, string brand, double price, double year)
    {
        Vehicle_Id = id;
        Vehicle_Name = name;
        Vehicle_Type = type;
        Brand = brand;
        Price = price;
        Manufacturing_Year = year;

    }

    public void Display()
    {
        Console.WriteLine("Vehicle ID : " + Vehicle_Id);
        Console.WriteLine("Vehicle Name : " + Vehicle_Name );
        Console.WriteLine("Vehicle Type : " + Vehicle_Type );
        Console.WriteLine("Brand : " + Brand);
        Console.WriteLine("Price : " + Price);
        Console.WriteLine("Manufacturing Year : " + Manufacturing_Year );
        Console.WriteLine("-------------------");
    }
}