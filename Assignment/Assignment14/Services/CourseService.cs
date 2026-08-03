using Assignment14.Models;

namespace Assignment14.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course
            {
                Id = 1,
                Title = "ASP.NET Core",
                Credits = 4,
                Duration = 6
            },

            new Course
            {
                Id = 2,
                Title = "Java",
                Credits = 3,
                Duration = 4
            }
        };

        public List<Course> GetCourses()
        {
            return courses;
        }

        public Course GetCourseById(int id)
        {
            return courses.FirstOrDefault(x => x.Id == id);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void UpdateDuration(int id, int duration)
        {
            Course course = courses.FirstOrDefault(x => x.Id == id);

            if (course != null)
            {
                course.Duration = duration;
            }
        }

        public void DeleteCourse(int id)
        {
            Course course = courses.FirstOrDefault(x => x.Id == id);

            if (course != null)
            {
                courses.Remove(course);
            }
        }
    }
}