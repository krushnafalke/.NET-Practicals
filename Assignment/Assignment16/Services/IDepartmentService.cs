using Assignment16.Models;

namespace Assignment16.Services
{
    public interface IDepartmentService
    {
        List<Department> GetAll();

        Department? GetById(int id);

        bool Add(Department department);

        bool Update(int id, Department department);

        bool Delete(int id);

        bool Exists(string name);

        bool IsActive(string name);
    }
}