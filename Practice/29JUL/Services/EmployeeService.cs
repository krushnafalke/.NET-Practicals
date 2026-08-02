using _29JUL.Models;
namespace _29JUL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id = 101, Name="Krushna", PhoneN = 3761857667, Email = "krushna@gmail.com", DeptId = 20},
            new Employee{Id = 102, Name="Dhanashri", PhoneN = 3375665383, Email = "dhanashri@gmail.com", DeptId = 21},
            new Employee{Id = 103, Name="Arpita", PhoneN = 3761852965, Email = "arpita@gmail.com", DeptId = 10},
            new Employee{Id = 104, Name="Payal", PhoneN = 9867557667, Email = "payal@gmail.com", DeptId = 15},
            new Employee{Id = 105, Name="Shravni", PhoneN = 9761857667, Email = "shravni@gmail.com", DeptId = 20}
        };
        public List<Employee> getEmployees()
        {
            return employees;
        }
        public Employee? getEmployee(int deptid)
        {
            return employees.FirstOrDefault(e => e.DeptId == e.DeptId);
        }

        public Employee? getEmployeeName(string Name)
        {
            return employees.FirstOrDefault(e => e.Name == e.Name);
        }

        public Employee addEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
            
        }
    }
}