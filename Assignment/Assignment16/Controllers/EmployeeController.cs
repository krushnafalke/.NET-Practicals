using Assignment16.Models;
using Assignment16.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment16.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            Employee? emp = service.GetById(id);

            if (emp == null)
                return NotFound();

            return Ok(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!service.Add(employee))
                return BadRequest("Employee cannot be added.");

            return Ok("Employee Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            if (!service.Update(id, employee))
                return BadRequest("Employee update failed.");

            return Ok("Employee Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (!service.Delete(id))
                return NotFound();

            return Ok("Employee Deleted Successfully");
        }

        [HttpGet("SearchByName/{name}")]
        public IActionResult SearchByName(string name)
        {
            var employees = service.SearchByName(name);

            if (!employees.Any())
                return NotFound("No Employee Found");

            return Ok(employees);
        }

        [HttpGet("SearchByDepartment/{department}")]
        public IActionResult SearchByDepartment(string department)
        {
            var employees = service.SearchByDepartment(department);

            if (!employees.Any())
                return NotFound("No Employee Found");

            return Ok(employees);
        }

        [HttpGet("SearchByEmail/{email}")]
        public IActionResult SearchByEmail(string email)
        {
            var employee = service.SearchByEmail(email);

            if (employee == null)
                return NotFound("Employee Not Found");

            return Ok(employee);
        }

        [HttpGet("SearchByStatus/{status}")]
        public IActionResult SearchByStatus(string status)
        {
            var employees = service.SearchByStatus(status);

            if (!employees.Any())
                return NotFound("No Employee Found");

            return Ok(employees);
        }

        [HttpGet("Department/{department}")]
        public IActionResult GetEmployeesByDepartment(string department)
        {
            var employees = service.GetEmployeesByDepartment(department);

            if (!employees.Any())
                return NotFound("No Employees Found");

            return Ok(employees);
        }
    }
}