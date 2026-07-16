using System;
class Customer
{
    public int Customer_Id;
    public string Name;
    public string Email;
    public string Password;

    public Customer(int id, string name, string email, string password)
    {
        Customer_Id = id;
        Name = name;
        Email = email;
        Password = password;
    }
}