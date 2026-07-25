using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _25Jul.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.FileProviders;

namespace _25Jul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student
            {
                id=1,
                name = "krushna",
                age = 20,
                department = "CSE"
            },
            new Student
            {
                id=2,
                name = "Payal",
                age = 21,
                department = "IT"
            },
            new Student
            {
                id=3,
                name = "Shravani",
                age = 21,
                department = "ELPO"
            }
        };
        
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);  //200
        }

        [HttpGet("{id}")]

        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s =>s.id==id);
            if(student == null)
             return NotFound();

            return Ok(student);
        }

        [HttpPost]

        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return CreatedAtAction(nameof(GetStudent),
            new {id = student.id},student);
        }

        [HttpPut]

        public IActionResult UpdateStudent(int id, Student updateStudent)
        {
            var student = students.FirstOrDefault(s =>s.id==id);
            if(student == null)
             return NotFound();

            student.age = updateStudent.age;

            return NoContent(); 
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s =>s.id==id);
            if(student == null)
             return NotFound();

            students.Remove(student);

            return NoContent(); 
        }
    }
}