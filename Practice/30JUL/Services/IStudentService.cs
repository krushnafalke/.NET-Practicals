using _30JUL.Models;

namespace _30JUL.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student? GetStudentById(int id);
        void AddStudent(Student student);
    }
}