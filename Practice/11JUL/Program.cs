using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        Generic<int> n = new Generic<int>();
        n.Print(100);

        Generic<string> n1 = new Generic<string>();
        n1.Print("krushna");

        Generic<double> n2 = new Generic<double>();
        n2.Print(100.50);

        string empName = "krushna";
        Console.WriteLine(empName.ProperCase());
        string empName1 = "Arpita";
        Console.WriteLine(empName1.ProperCase());


        List<Employee> employees = new List<Employee>();
        List<Manager> managers = new List<Manager>();

        while (true)
        {
            Console.WriteLine("Hello. Welcome to Emp System ");
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. Add Manager ");
            Console.WriteLine("3. View Employee ");
            Console.WriteLine("4. View Manager");
            Console.WriteLine("5. Search Employee by Id ");
            Console.WriteLine("6. Exit ");

            Console.Write("Enter choice 1-6 ");

            try
            {
               int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       Console.Write("Enter id :");
                       int id = Convert.ToInt32(Console.ReadLine()); 
                       bool exists = false;
                       foreach(Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if (exists)
                        {
                            Console.WriteLine("Employee id already exists");
                            break;
                        }
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter salary:");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Employee employee = new Employee(id,name,salary);

                        employees.Add(employee);

                        Console.WriteLine("Employee Added Succesfully ");
                        break; 

                    case 2:
                        Console.Write("Enter Manager ID: ");
                        int mid = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Enter name: ");
                        string mname = Console.ReadLine();
                        Console.Write("Enter salary:");
                        double msalary = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter dept: ");
                        string mdept = Console.ReadLine();
                        Manager manager = new Manager(mid,mname,msalary,mdept);
                        managers.Add(manager);
                        Console.WriteLine("Manager Added Successfully");
                        break;




                    case 3:
                        if(employees.Count == 0)
                        {
                            Console.WriteLine("No Employee in system");
                        }
                        else
                        {
                            foreach(Employee emp in employees)
                            {
                               emp.Display(); 
                            }
                        }
                        break;

                    case 4:
                        if(managers.Count == 0)
                        {
                            Console.WriteLine("No manager in system");
                        }
                        else
                        {
                            foreach(Manager mng in managers)
                            {
                               mng.Display(); 
                            }
                        }
                        break;

                    case 5:
                        Console.Write("Enter Employee Id: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        foreach(Employee emp in employees)
                        {
                            if(emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;

                    case 6:
                        return;

                    default:
                    Console.WriteLine("Invalid choice");
                    break;
                } 
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter number only");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


