using System;
using System.Collections.Generic;

class Course
{
    public int CourseId;
    public string CourseName;
    public int Credits;

    public Course(int id, string name, int credits)
    {
        CourseId = id;
        CourseName = name;
        Credits = credits;
    }

    public void Display()
    {
        Console.WriteLine(CourseId + " " + CourseName + " Credits : " + Credits);
    }
}