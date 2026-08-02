using _30JUL.Models;
namespace _30JUL.Services
{
    public interface StudentService : IStudentService
    {
        private static List<Student> students = new List<Student>
        {
            new Student {Id = 1, FirstName = "Krushna" , LastName = "F", PhoneN = 986754653, BatchId = 1111},
            new Student {Id = 2, FirstName = "Dhanashri" , LastName = "J", PhoneN = 345754653, BatchId = 1112},
            new Student {Id = 3, FirstName = "Arpita" , LastName = "M", PhoneN = 976754653, BatchId = 1113},
            new Student {Id = 4, FirstName = "Payal" , LastName = "D", PhoneN = 986756578, BatchId = 1114}
        };

        public List<Student> getStudents()
        {
            return students;
        }
        public Student? GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == s.Id);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

    }
}