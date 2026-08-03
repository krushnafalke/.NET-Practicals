using Microsoft.AspNetCore.Mvc;
using Assignment14.Models;
using Assignment14.Services;

namespace Assignment14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService Services;

        public CourseController(ICourseService Services)
        {
            this.Services = Services;
        }

        
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(Services.GetCourses());
        }

       
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = Services.GetCourseById(id);

            if (course == null)
                return NotFound("Course with id not found");

            return Ok(course);
        }

        
        [HttpPost]
        public IActionResult RegisterCourse(Course course)
        {
            Services.AddCourse(course);

            return Ok("Course Registered Successfully");
        }

       
        [HttpPut("{id}")]
        public IActionResult UpdateDuration(int id, int duration)
        {
            Services.UpdateDuration(id, duration);

            return Ok("Duration Updated Successfully");
        }

        
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            Services.DeleteCourse(id);

            return Ok("Course Cancelled Successfully");
        }
    }
}