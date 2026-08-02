using _29JUL.Models;

namespace _29JUL.Services
{
    public interface IEmployeeService
    {
        List<Employee> getEmployees();
        Employee? getEmployee(int deptid);
        Employee? getEmployeeName(string Name);
        Employee addEmployee(Employee employee);
    }
}