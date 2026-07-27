using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _27JUL.Models;

namespace _27JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){ Id = 101, Name = "Krushna", LastName = "Falke", Dept="CSE", PhoneNum = 89754618},
            new Employee(){ Id = 102, Name = "Dhanashri", LastName = "J", Dept="CSE", PhoneNum = 893524},
            new Employee(){ Id = 103, Name = "Arpita", LastName = "M", Dept="CSE", PhoneNum = 696375},
            new Employee(){ Id = 104, Name = "Payal", LastName = "D", Dept="IT", PhoneNum =7236968},
            new Employee(){ Id = 105, Name = "Shravni", LastName = "S", Dept="ELPO", PhoneNum = 837538}
        };

        [HttpGet]

        public IActionResult GetEmployee()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult getEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]

        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateEmployees(int id, Employee employee)
        {
            var employee1 = employees.FirstOrDefault(x => x.Id == id);
            if(employee1 == null)
            {
                return NotFound();
            }
            employee1.LastName = employee.LastName;
            return Ok(employee1);
        }

        [HttpGet("Dept/{dept}")]

        public IActionResult getEmployeeByDept(string dept)
        {
            var result = employees.Where(s => s.Dept.Equals(dept, StringComparison.OrdinalIgnoreCase )).ToList();

            if (!result.Any())
            {
                return NotFound("Not employee found under this dept");
            }
            return Ok(result);
        }

    }
}