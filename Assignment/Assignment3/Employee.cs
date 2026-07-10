using System;

abstract class Employee
{
    public double EmpId {get; set;}
    public string EmpName {get; set;}
    public string EmpDep {get; set;}
    public double LeaveBalance {get; set;}

    public abstract void SetLeaveBalance();

    public void DisplayDetails()
    {
        Console.WriteLine($"ID : {EmpId}");
        Console.WriteLine($"Name : {EmpName}");
        Console.WriteLine($"Department : {EmpDep}");
        Console.WriteLine($"LeaveBalance : {LeaveBalance}");
        
    }
}