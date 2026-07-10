using System;

class LeaveRequest
{
    public double LeaveId{ get; set;}
    public double EmpId {get; set;}
    public double NumberOfDays { get; set;}
    public string Reason { get; set;}

    public void DisplayLeave()
    {
        Console.WriteLine($"ID : {EmpId}");
        Console.WriteLine($"Leave ID : {LeaveId}");
        Console.WriteLine($"Number of Days : {NumberOfDays}");
        Console.WriteLine($"Reason : {Reason}");
    }
}