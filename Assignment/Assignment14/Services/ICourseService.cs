using Assignment14.Models;

namespace Assignment14.Services
{
    public interface ICourseService
    {
        List<Course> GetCourses();

        Course GetCourseById(int id);

        void AddCourse(Course course);

        void UpdateDuration(int id, int duration);

        void DeleteCourse(int id);
    }
}