using System;

class Array
{
    static void Main()
    {
        int[] sales = { 25000, 30000, 28000, 35000, 27000, 32000 };

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        Console.WriteLine("Monthly Sales:");

        foreach (int s in sales)
        {
            Console.WriteLine(s);
            total += s;

            if (s > highest)
                highest = s;

            if (s < lowest)
                lowest = s;
        }

        double average = (double)total / sales.Length;

        Console.WriteLine("\nTotal Sales: ₹" + total);
        Console.WriteLine("Average Sales: ₹" + average);
        Console.WriteLine("Highest Sales: ₹" + highest);
        Console.WriteLine("Lowest Sales: ₹" + lowest);
    }
}