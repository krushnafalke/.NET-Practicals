using System;

class OOP
{
    static void Main()
    {
        Employee e = new Employee();

        e.EmpName = "Mamta";
        e.Salary = 1000;

        Console.WriteLine(e.EmpName + " " + e.Salary);



        CompiletimePoly c = new CompiletimePoly();
            c.Search(101);
            c.Search(75614274825);
            c.Search("Mamta","Boga");



        RuntimePoly r = new RuntimePoly();
            r.checkout(new UpiPayment(), 500);
            r.checkout(new CreditPayment(),35000);
            r.checkout(new NetBanking(), 21000);


        FileStorage s = new abstracteg();
        s.Upload("CV.pdf");
        s.validateFile();

    }



}
