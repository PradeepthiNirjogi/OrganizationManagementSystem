using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Models;

namespace OrganizationManagementSystem.DataAccess.Repository
{
    public class EmployeeRepository
    {

        //to update the data
        public void UpdateEmployee(
           int employeeId,
           string name,
           int roleId,
           int departmentId,
           int? managerId)
        {

            using (var context = new OrganizationDbContext())
            {
                var emp = context.Employee
                                 .FirstOrDefault(e => e.EmployeeId == employeeId);

                if (emp == null)
                    return;

                emp.Name = name;
                emp.RoleId = roleId;
                emp.DepartmentId = departmentId;
                emp.ManagerId = managerId;

                context.SaveChanges();
            }
        }
        public int GetRoleId(string role)
        {
            using (var context = new OrganizationDbContext())
            {
                return context.Role
                    .Where(r => r.RoleName == role)
                    .Select(r => r.RoleId)
                    .FirstOrDefault();
            }
        }

        public int GetDepartmentId(string dept)
        {
            using (var context = new OrganizationDbContext())
            {
                return context.Department
                .Where(d => d.DepartmentName == dept)
                .Select(d => d.DepartmentId)
                .FirstOrDefault();
            }
        }

        public int? GetManagerId(string manager)
        {
            if (string.IsNullOrWhiteSpace(manager) || manager == "-")
                return null;
            using (var context = new OrganizationDbContext())
            {
                return context.Employee
                    .Where(e => e.Name == manager)
                    .Select(e => e.EmployeeId)
                    .FirstOrDefault();
            }
        }

        //add
            public void Add(Employee e)
            {
                using (var context = new OrganizationDbContext())
                {
                    context.Add(e);
                    context.SaveChanges();
                }
            }
    }
}
