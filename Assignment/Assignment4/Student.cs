using System;
using System.Collections.Generic;

abstract class Student
{
    public int Id;
    public string Name;
    public string Department;
    public List<Course> Courses;

    public Student(int i, string n, string d)
    {
        Id = i;
        Name = n;
        Department = d;
        Courses = new List<Course>();
    }
    public abstract double CalculateFee();

    public int TotalCredits()
    {
        int total = 0;

        foreach (Course c in Courses)
        {
            total += c.Credits;
        }

        return total;
    }
    public virtual void Display()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Student ID : " + Id);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Department : " + Department);

        Console.WriteLine("Courses");

        foreach (Course c in Courses)
        {
            Console.WriteLine(c.CourseName + "  Credits : " + c.Credits);
        }

        Console.WriteLine("Total Credits : " + TotalCredits());
        Console.WriteLine("Fee : " + CalculateFee());
    }
    
}