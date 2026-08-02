using _29JUL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _29JUL.Models;

namespace _29JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getEmployees());
        }
        [HttpGet("{deptid}")]

        public IActionResult GetById(int deptid)
        {
            var employee = _service.getEmployee(deptid);
            if(employee == null)
              return NotFound("Employee with id not found");

            return Ok(employee);
        }
        [HttpGet("{name}")]
        public IActionResult GetByName(string Name)
        {
            var employee = _service.getEmployeeName(Name);
            if(employee == null)
              return NotFound("Employee with name not found");

            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var res = _service.addEmployee(employee);
            return Ok(res);
        }


    }
}


