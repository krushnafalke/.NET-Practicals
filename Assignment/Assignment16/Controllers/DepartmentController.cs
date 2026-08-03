using Assignment16.Models;
using Assignment16.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment16.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService departmentService;
        private readonly IEmployeeService employeeService;

        public DepartmentController(
            IDepartmentService departmentService,
            IEmployeeService employeeService)
        {
            this.departmentService = departmentService;
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetDepartments()
        {
            return Ok(departmentService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            Department? department = departmentService.GetById(id);

            if (department == null)
                return NotFound("Department Not Found");

            return Ok(department);
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!departmentService.Add(department))
                return BadRequest("Department Name or Code already exists.");

            return Ok("Department Created Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDepartment(int id, Department department)
        {
            if (!departmentService.Update(id, department))
                return NotFound("Department Not Found");

            return Ok("Department Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            Department? department = departmentService.GetById(id);

            if (department == null)
                return NotFound("Department Not Found");

            if (employeeService.HasEmployees(department.DepartmentName))
                return BadRequest("Cannot delete department because employees are assigned.");

            departmentService.Delete(id);

            return Ok("Department Deleted Successfully");
        }
    }
}