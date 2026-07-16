using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
   {
        List<StationeryItem> items = new List<StationeryItem>();

        int attempts = 3;
        bool login = false;

        while (attempts > 0)
        {
            Console.Write("Enter Username : ");
            string username = Console.ReadLine();

            Console.Write("Enter Password : ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "admin123")
            {
                login = true;
                break;
            }

            attempts--;

            Console.WriteLine("Invalid Login");

            if (attempts > 0)
                Console.WriteLine("Attempts Left : " + attempts);
        }

        if (!login)
        {
            throw new LoginFailedException();
        }

        Menu(items);
   }

   static void Menu(List<StationeryItem> items)
   {
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Stationery Store Management System");
        Console.WriteLine("------------------------------------");

        Console.WriteLine("1. Add Stationery Item");
        Console.WriteLine("2. Display All Items");
        Console.WriteLine("3. Search Item");
        Console.WriteLine("4. Update Item");
        Console.WriteLine("5. Delete Item");
        Console.WriteLine("6. Purchase Item");
        Console.WriteLine("7. View Low Stock");
        Console.WriteLine("8. Sort Items");
        Console.WriteLine("9. Exit");

        Console.Write("Enter Choice : ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                AddItem(items);
                break;

            case 2:
                DisplayItems(items);
                break;

            case 3:
                SearchItem(items);
                break;

            case 4:
                UpdateItem(items);
                break;

            case 5:
                DeleteItem(items);
                break;

            case 6:
                PurchaseItem(items);
                break;

            case 7:
                LowStock(items);
                break;

            case 8:
                SortItems(items);
                break;

            case 9:
                Console.WriteLine("Thank You");
                Console.WriteLine("Visit Again");
                return;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
     }
   }

   static void AddItem(List<StationeryItem> items)
   {
        StationeryItem s = new StationeryItem();

        Console.Write("Enter Item ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (StationeryItem item in items)
        {
            if (item.ItemId == id)
                throw new DuplicateItemException();
        }

        s.ItemId = id;

        Console.Write("Enter Name : ");
        s.ItemName = Console.ReadLine();

        Console.Write("Enter Category : ");
        s.Category = Console.ReadLine();

        Console.Write("Enter Brand : ");
        s.Brand = Console.ReadLine();

        Console.Write("Enter Price : ");
        s.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity : ");
        s.Quantity = Convert.ToInt32(Console.ReadLine());

        items.Add(s);

        Console.WriteLine("Item Added Successfully");
    }

    static void DisplayItems(List<StationeryItem> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No Items Found");
            return;
        }

        foreach (StationeryItem item in items)
        {
            item.DisplayDetails();
            Console.WriteLine("-------------------------");
        }
    }

    static void SearchItem(List<StationeryItem> items)
    {
        Console.WriteLine("1.Search By ID");
        Console.WriteLine("2.Search By Name");

        int ch = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        if (ch == 1)
        {
            Console.Write("Enter ID : ");

            int id = Convert.ToInt32(Console.ReadLine());

            foreach (StationeryItem item in items)
            {
                if (item.ItemId == id)
                {
                    item.DisplayDetails();
                    found = true;
                    break;
                }
            }
        }

        else
        {
            Console.Write("Enter Name : ");

            string name = Console.ReadLine();

            foreach (StationeryItem item in items)
            {
                if (item.ItemName.Equals(name,
                    StringComparison.OrdinalIgnoreCase))
                {
                    item.DisplayDetails();
                    found = true;
                    break;
                }
            }
        }

        if (!found)
            throw new ItemNotFoundException();
    }

    static void UpdateItem(List<StationeryItem> items)
    {
        Console.Write("Enter Item ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (StationeryItem item in items)
        {
            if (item.ItemId == id)
            {
                Console.Write("Enter New Brand : ");
                item.Brand = Console.ReadLine();

                Console.Write("Enter New Price : ");
                item.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter New Quantity : ");
                item.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Item Updated Successfully");

                found = true;
                break;
            }
        }

        if (!found)
            throw new ItemNotFoundException();
    }

    static void DeleteItem(List<StationeryItem> items)
    {
        Console.Write("Enter Item ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        StationeryItem deleteItem = null;

        foreach (StationeryItem item in items)
        {
            if (item.ItemId == id)
            {
                deleteItem = item;
                break;
            }
        }

        if (deleteItem == null)
            throw new ItemNotFoundException();

        Console.Write("Delete ? (Y/N) : ");
        char ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'Y' || ch == 'y')
        {
            items.Remove(deleteItem);
            Console.WriteLine("Item Deleted Successfully");
        }
    }

    static void PurchaseItem(List<StationeryItem> items)
    {
        Console.Write("Enter Item ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Quantity : ");
        int qty = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (StationeryItem item in items)
        {
            if (item.ItemId == id)
            {
                found = true;

                if (qty > item.Quantity)
                    throw new InsufficientStockException();

                item.Quantity -= qty;

                item.GenerateBill(qty);

                break;
            }
        }

        if (!found)
            throw new ItemNotFoundException();
    }

    

    static void LowStock(List<StationeryItem> items)
    {
        bool found = false;

        foreach (StationeryItem item in items)
        {
            if (item.Quantity < 5)
            {
                item.DisplayDetails();
                Console.WriteLine("--------------------");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No Low Stock Items");
    }

    static void SortItems(List<StationeryItem> items)
    {
        Console.WriteLine("1. Price");
        Console.WriteLine("2. Name");
        Console.WriteLine("3. Quantity");

        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:

                items = items.OrderBy(x => x.Price).ToList();

                break;

            case 2:

                items = items.OrderBy(x => x.ItemName).ToList();

                break;

            case 3:

                items = items.OrderByDescending(x => x.Quantity).ToList();

                break;

            default:

                Console.WriteLine("Invalid Choice");

                return;
        }

        foreach (StationeryItem item in items)
        {
            item.DisplayDetails();
            Console.WriteLine("--------------------");
        }
    }
}
