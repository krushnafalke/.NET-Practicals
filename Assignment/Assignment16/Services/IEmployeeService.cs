using Assignment16.Models;

namespace Assignment16.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        Employee? GetById(int id);

        bool Add(Employee employee);

        bool Update(int id, Employee employee);

        bool Delete(int id);

        List<Employee> SearchByName(string name);

        List<Employee> SearchByDepartment(string department);

        Employee? SearchByEmail(string email);

        List<Employee> SearchByStatus(string status);

        List<Employee> GetEmployeesByDepartment(string department);

        bool HasEmployees(string department);
    }
}