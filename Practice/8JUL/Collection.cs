using System.Collections.Generic;


class Collections
{
    
    static void main()
    {
        List<string> names = new List<string>();

        names.Add("Krushna");
        names.Add("Arpita");
        names.Add("Dhanashri");
        names.Add("payal");
        names.Add("Shravni");

        foreach(string f in names)
        {
            Console.WriteLine(f);
        }

    }
}