using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> emp = new List<Employee>()
        {
            new PermanentEmployee
            {
                EmpId = 101,
                EmpName = "Krushna",
                EmpDep = "IT"
            },

            new ContractEmployee
            {
                EmpId = 102,
                EmpName = "Arpita",
                EmpDep = "HR"
            },

            new PermanentEmployee
            {
                EmpId = 103,
                EmpName = "Dhanashri",
                EmpDep = "Marketing"
            },

            new ContractEmployee
            {
                EmpId = 104,
                EmpName = "Payal",
                EmpDep = "Finance"
            }
        };

        foreach(Employee e in emp)
        {
            e.SetLeaveBalance();
        }

        Console.WriteLine("Employee Details");
        foreach(Employee e in emp)
        {
            e.DisplayDetails();
        }

        List<LeaveRequest> leaverequest = new List<LeaveRequest>()
        {
            new LeaveRequest
            {
                LeaveId = 1,
                EmpId = 101,
                NumberOfDays = 3,
                Reason = "Medical Checkup"
            },

            new LeaveRequest
            {
                LeaveId = 2,
                EmpId = 101,
                NumberOfDays = 3,
                Reason = "Vacation"
            },

            new LeaveRequest
            {
                LeaveId = 1,
                EmpId = 101,
                NumberOfDays = 3,
                Reason = "Personal Work"
            }
        };

        Console.WriteLine("\nLeave Requests");

        foreach(LeaveRequest leave in leaverequest)
        {
            leave.DisplayLeave();
        }

        Console.WriteLine("\nPermanent Employee");
        foreach(Employee e in emp)
        {
            if (e is PermanentEmployee)
            {
                e.DisplayDetails ();
            }
        }

        Console.WriteLine("\nEmployee with ID 103");

        Employee found = emp.Find(e => e.EmpId == 103);

        if (found != null)
        {
            found.DisplayDetails();
        } 

        Console.WriteLine($"Total Employees : {emp.Count}");

        // Task 8
        Console.WriteLine($"Total Leave Requests : {leaverequest.Count}");
    }
}