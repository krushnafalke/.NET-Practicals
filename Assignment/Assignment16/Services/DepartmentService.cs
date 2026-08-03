using Assignment16.Models;

namespace Assignment16.Services
{
    public class DepartmentService : IDepartmentService
    {
        private static List<Department> departments = new();

        public List<Department> GetAll()
        {
            return departments;
        }

        public Department? GetById(int id)
        {
            return departments.FirstOrDefault(x => x.Id == id);
        }

        public bool Exists(string name)
        {
            return departments.Any(x =>
                x.DepartmentName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public bool IsActive(string name)
        {
            Department? dept = departments.FirstOrDefault(x =>
                x.DepartmentName.Equals(name, StringComparison.OrdinalIgnoreCase));

            return dept != null && dept.Status == "Active";
        }

        public bool Add(Department department)
        {
            if (string.IsNullOrWhiteSpace(department.DepartmentName))
                return false;

            if (department.DepartmentName.Length > 50)
                return false;

            if (department.Status != "Active" &&
                department.Status != "Inactive")
                return false;

            if (Exists(department.DepartmentName))
                return false;

            if (departments.Any(x =>
                x.DepartmentCode.Equals(department.DepartmentCode,
                StringComparison.OrdinalIgnoreCase)))
                return false;

            departments.Add(department);

            return true;
        }

        public bool Update(int id, Department department)
        {
            Department? dept = GetById(id);

            if (dept == null)
                return false;

            dept.DepartmentName = department.DepartmentName;
            dept.DepartmentCode = department.DepartmentCode;
            dept.Status = department.Status;

            return true;
        }

        public bool Delete(int id)
        {
            Department? dept = GetById(id);

            if (dept == null)
                return false;

            departments.Remove(dept);

            return true;
        }
    }
}