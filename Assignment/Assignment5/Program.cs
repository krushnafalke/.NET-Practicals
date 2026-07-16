using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>();
        List<Product> products = new List<Product>();
        List<Cart> cart = new List<Cart>();

     

        Console.WriteLine("----- Customer Registration -----");

        Console.Write("Enter Customer ID : ");
        int cid = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name : ");
        string cname = Console.ReadLine();

        Console.Write("Enter Email : ");
        string email = Console.ReadLine();

        Console.Write("Enter Password : ");
        string password = Console.ReadLine();

        customers.Add(new Customer(cid, cname, email, password));

        Console.WriteLine("\nRegistration Successful");


        int attempts = 3;
        bool login = false;

        while (attempts > 0)
        {
            Console.WriteLine("\n----- Login -----");

            Console.Write("Enter Email : ");
            string lemail = Console.ReadLine();

            Console.Write("Enter Password : ");
            string lpass = Console.ReadLine();

            foreach (Customer c in customers)
            {
                if (c.Email == lemail && c.Password == lpass)
                {
                    Console.WriteLine("\nWelcome " + c.Name);
                    login = true;
                    break;
                }
            }

            if (login)
                break;

            attempts--;

            if (attempts > 0)
                Console.WriteLine("Invalid Credentials. Attempts Left : " + attempts);
        }

        if (!login)
        {
            Console.WriteLine("Account Locked");
            return;
        }



        Console.Write("\nHow many products do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("\nEnter Product " + i);

            Console.Write("Product ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name : ");
            string name = Console.ReadLine();

            Console.Write("Price : ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock : ");
            int stock = Convert.ToInt32(Console.ReadLine());

            products.Add(new Product(id, name, price, stock));
        }


        Console.WriteLine("\n----- Product List -----");

        foreach (Product p in products)
        {
            Console.WriteLine(p.Product_Id + "  " +
                              p.Product_Name + "  " +
                              p.Price + "  " +
                              p.Stock);
        }



        Console.Write("\nEnter Product Name to Search : ");
        string search = Console.ReadLine();

        bool found = false;

        foreach (Product p in products)
        {
            if (p.Product_Name.Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine("Product ID : " + p.Product_Id);
                Console.WriteLine("Product Name : " + p.Product_Name);
                Console.WriteLine("Price : " + p.Price);
                Console.WriteLine("Stock : " + p.Stock);
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Product Not Found");


        int choice;

        do
        {
            Console.Write("\nEnter Product ID : ");
            int pid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Quantity : ");
            int qty = Convert.ToInt32(Console.ReadLine());

            bool available = false;

            foreach (Product p in products)
            {
                if (p.Product_Id == pid)
                {
                    if (qty <= p.Stock)
                    {
                        cart.Add(new Cart(p.Product_Name, qty, p.Price));
                        p.Stock -= qty;
                        Console.WriteLine("Added To Cart");
                    }
                    else
                    {
                        Console.WriteLine("Stock Not Available");
                    }

                    available = true;
                    break;
                }
            }

            if (!available)
                Console.WriteLine("Invalid Product ID");

            Console.Write("Do you want to add another product? ");
            Console.WriteLine("\n1. Yes");
            Console.WriteLine("2. No");
            
            choice = Convert.ToInt32(Console.ReadLine());

        } while (choice == 1);



        double total = 0;

        Console.WriteLine("\n----- Cart -----");

        foreach (Cart c in cart)
        {
            Console.WriteLine(c.Product_Name + " x" + c.Quantity);
            total += c.Price * c.Quantity;
        }


        double discount = 0;

        if (total >= 1000 && total <= 4999)
            discount = total * 0.10;
        else if (total >= 5000 && total <= 9999)
            discount = total * 0.20;
        else if (total >= 10000)
            discount = total * 0.30;

        double finalAmount = total - discount;

        Console.WriteLine("\nTotal Amount : " + total);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("Final Amount : " + finalAmount);



        Console.WriteLine("\nChoose Payment Method");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash On Delivery");

        Console.Write("Enter Choice : ");
        int payment = Convert.ToInt32(Console.ReadLine());

        switch (payment)
        {
            case 1:
                Console.WriteLine("Payment Successful using UPI");
                break;

            case 2:
                Console.WriteLine("Payment Successful using Credit Card");
                break;

            case 3:
                Console.WriteLine("Payment Successful using Debit Card");
                break;

            case 4:
                Console.WriteLine("Payment Successful using Cash On Delivery");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}