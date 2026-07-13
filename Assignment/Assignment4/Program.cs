using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();

        while (true)
        {
            Console.WriteLine("Welcome to Student Management");
            Console.WriteLine("1. Register Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Add Course");
            Console.WriteLine("5. View Course");
            Console.WriteLine("6. Register Course");
            Console.WriteLine("7. View Student Details ");
            Console.WriteLine("8. Exit");

            Console.WriteLine("Enter Choice From 1 to 8 : ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Student Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;

                        foreach (Student s in students)
                        {
                            if (s.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Student ID already exists.");
                            break;
                        }

                        Console.Write("Enter Name : ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Department : ");
                        string dept = Console.ReadLine();

                        Console.WriteLine("1.Regular");
                        Console.WriteLine("2.Scholarship");
                        Console.WriteLine("3.Part Time");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Student student;

                        if (type == 1)
                            student = new RegularStudent(id, name, dept);

                        else if (type == 2)
                            student = new ScholarshipStudent(id, name, dept);

                        else
                            student = new PartTimeStudent(id, name, dept);

                        students.Add(student);

                        Console.WriteLine("Student Added Successfully");
                        break;

                    case 2:

                        foreach (Student s in students)
                        {
                            s.Display();
                        }

                        break;

                    case 3:

                        Console.Write("Enter Student Id : ");
                        int sid = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Student s in students)
                        {
                            if (s.Id == sid)
                            {
                                s.Display();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student Not Found");
                        }

                        break;

                    case 4:

                        Console.Write("Course Id : ");
                        int cid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Course Name : ");
                        string cname = Console.ReadLine();

                        Console.Write("Credits : ");
                        int credits = Convert.ToInt32(Console.ReadLine());

                        Course course = new Course(cid, cname, credits);

                        courses.Add(course);

                        Console.WriteLine("Course Added");
                        break;

                    case 5:

                        foreach (Course c in courses)
                        {
                            c.Display();
                        }

                        break;

                    case 6:

                        Console.Write("Student Id : ");
                        int stid = Convert.ToInt32(Console.ReadLine());

                        Student stu = null;

                        foreach (Student s in students)
                        {
                            if (s.Id == stid)
                            {
                                stu = s;
                                break;
                            }
                        }

                        if (stu == null)
                        {
                            Console.WriteLine("Student Not Found");
                            break;
                        }

                        Console.Write("Course Id : ");
                        int coid = Convert.ToInt32(Console.ReadLine());

                        Course cou = null;

                        foreach (Course c in courses)
                        {
                            if (c.CourseId == coid)
                            {
                                cou = c;
                                break;
                            }
                        }

                        if (cou == null)
                        {
                            Console.WriteLine("Course Not Found");
                            break;
                        }

                        if (stu.Courses.Count >= 5)
                        {
                            Console.WriteLine("Maximum 5 courses allowed.");
                            break;
                        }

                        bool duplicate = false;

                        foreach (Course c in stu.Courses)
                        {
                            if (c.CourseId == cou.CourseId)
                            {
                                duplicate = true;
                                break;
                            }
                        }

                        if (duplicate)
                        {
                            Console.WriteLine("Course already registered.");
                        }
                        else
                        {
                            stu.Courses.Add(cou);
                            Console.WriteLine("Course Registered Successfully");
                        }

                        break;

                    case 7:

                        Console.Write("Student Id : ");

                        int stdid = Convert.ToInt32(Console.ReadLine());

                        foreach (Student s in students)
                        {
                            if (s.Id == stdid)
                            {
                                s.Display();
                            }
                        }

                        break;

                    case 8:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

