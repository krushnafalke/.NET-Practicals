using Assignment16.Models;

namespace Assignment16.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee> (
            // new Employee
            // {
                
            //     EmployeeId= 101,
            //     FirstName= "Rahul",
            //     LastName= "Sharma",
            //     Email= "rahul@gmail.com",
            //     Mobile= "9876543210",
            //     // DateOfBirth= 2000-05-10,
            //     Gender= "Male",
            //     Salary= 50000,
            //     // DateOfJoining= 20250701,
            //     Department= "IT",
            //     Designation= "Software Engineer",
            //     Status= "Active"
                
            // }
        );

        private readonly IDepartmentService departmentService;

        public EmployeeService(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee? GetById(int id)
        {
            return employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public bool Add(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                return false;

            if (string.IsNullOrWhiteSpace(employee.LastName))
                return false;

            if (string.IsNullOrWhiteSpace(employee.Email))
                return false;

            if (string.IsNullOrWhiteSpace(employee.Department))
                return false;

            if (employee.DateOfJoining == DateTime.MinValue)
                return false;

            if (employees.Any(x => x.EmployeeId == employee.EmployeeId))
                return false;

            if (employees.Any(x =>
                x.Email.Equals(employee.Email,
                StringComparison.OrdinalIgnoreCase)))
                return false;

            if (!departmentService.Exists(employee.Department))
                return false;

            if (!departmentService.IsActive(employee.Department))
                return false;

            employees.Add(employee);

            return true;
        }

        public bool Update(int id, Employee employee)
        {
            Employee? emp = GetById(id);

            if (emp == null)
                return false;

            if (!departmentService.IsActive(employee.Department))
                return false;

            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Email = employee.Email;
            emp.Mobile = employee.Mobile;
            emp.DateOfBirth = employee.DateOfBirth;
            emp.Gender = employee.Gender;
            emp.Salary = employee.Salary;
            emp.DateOfJoining = employee.DateOfJoining;
            emp.Department = employee.Department;
            emp.Designation = employee.Designation;
            emp.Status = employee.Status;

            return true;
        }

        public bool Delete(int id)
        {
            Employee? emp = GetById(id);

            if (emp == null)
                return false;

            employees.Remove(emp);

            return true;
        }

        public List<Employee> SearchByName(string name)
        {
            return employees.Where(x =>
                (x.FirstName + " " + x.LastName)
                .Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Employee> SearchByDepartment(string department)
        {
            return employees.Where(x =>
                x.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public Employee? SearchByEmail(string email)
        {
            return employees.FirstOrDefault(x =>
                x.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public List<Employee> SearchByStatus(string status)
        {
            return employees.Where(x =>
                x.Status.Equals(status, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            return SearchByDepartment(department);
        }

        public bool HasEmployees(string department)
        {
            return employees.Any(x =>
                x.Department.Equals(department, StringComparison.OrdinalIgnoreCase));
        }
    }
}