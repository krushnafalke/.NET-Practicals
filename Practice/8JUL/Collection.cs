using System.Collections.Generic;


class Collections
{
    
    static void Main()
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


        List<Stud> st = new List<Stud>
        {
            new Stud{id = 1, sname= "abc"},
            new Stud{id = 2, sname= "xyz"},
            new Stud{id = 3, sname= "pyq"},
            new Stud{id = 4, sname= "fqp"},
        };
        List<Teacher> th = new List<Teacher>
        {
            new Teacher{tid = 101, Tname= "Poonam"},
            new Teacher{tid = 102, Tname= "janhvi"},
            
        };

        foreach(var stu in st)
        {
            Console.WriteLine($"Students : {stu.sname}");
        }
        foreach(var thu in th)
        {
            Console.WriteLine($"Teacher : {thu.Tname}");
        }
    }
    }
