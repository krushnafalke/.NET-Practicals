using _30JUL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _30JUL.Models;

namespace _30JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_service.GetStudents());
        }
        [HttpGet("{id}")]

        public IActionResult GetStudents(int id)
        {
            var student = _service.GetStudentById(id);
            if(student == null)
              return NotFound("student with id not found");

            return Ok(student);
        }
        
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
           _service.AddStudent(student);
           return Ok("Student Added");
        }


    }

}