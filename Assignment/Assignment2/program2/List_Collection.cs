using System;
using System.Collections.Generic;

class List_Collection
{
    static void Main()
    {
        List<string> books = new List<string>()
        {
            "C Programming",
            "Java",
            "Python",
            "Data Structures"
        };

        Console.WriteLine("Available Books:");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        books.Add("ASP.NET");

        books.Remove("C Programming");

        Console.WriteLine("\nUpdated Book List:");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nTotal Books: " + books.Count);
    }
}