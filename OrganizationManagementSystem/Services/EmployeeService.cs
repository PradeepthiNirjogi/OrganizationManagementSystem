using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.DataAccess.Repository;
using OrganizationManagementSystem.Models;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace OrganizationManagementSystem.Services
{
    public class EmployeeService
    {
        // ================= FILTER =================
        private readonly EmployeeRepository repo=new EmployeeRepository();
        public EmployeeService()
        {
            
        }
        public List<EmployeeGridModel> FilterRecord(
            int roleId,
            int deptId,
            string name,
            int managerId,
            int pageNumber,
            int pageSize)
        {
            using (var context = new OrganizationDbContext())
            {
                return context.Employee
                    .Where(e =>
                        (roleId == 0 || e.RoleId == roleId) &&
                        (deptId == 0 || e.DepartmentId == deptId) &&
                        (string.IsNullOrWhiteSpace(name) || e.Name.Contains(name)) &&
                        (managerId == 0 || e.ManagerId == managerId)
                    )
                    .OrderBy(e=>e.EmployeeId)
                    .Skip((pageNumber-1)*pageSize)
                    .Take(pageSize)
                    .Select(e => new EmployeeGridModel
                    {
                        EmployeeId = e.EmployeeId,
                        Name = e.Name,
                        RoleName = e.Role.RoleName,
                        Department = e.Department.DepartmentName,
                        Manager = e.Manager != null ? e.Manager.Name : "-",
                        ManagerId = e.ManagerId
                    })
                    .ToList();
            }
        }

        // ================= DELETE =================
        public void DeleteEmployee(int employeeId)
        {
            using (var context = new OrganizationDbContext())
            {
                var employee = context.Employee
                                      .FirstOrDefault(e => e.EmployeeId == employeeId);

                if (employee == null)
                    return;

                context.Employee.Remove(employee);
                Log.Information("Employee deleted from database. EmployeeId {EmployeeId}", employeeId);
                context.SaveChanges();
            }
        }
        public void SaveEmployee(
            int id,
            string name,
            string role,
            string department,
            string manager)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(department))
            {
                throw new Exception("Name, Role and Department are mandatory.");
            }

            int roleId = repo.GetRoleId(role);
            int deptId = repo.GetDepartmentId(department);

            int? managerId = role == "Manager"
                ? null
                : repo.GetManagerId(manager);

            if (role != "Manager" && managerId == null)
            {
                throw new Exception("Employee must report to a Manager.");
            }

            repo.UpdateEmployee(id, name, roleId, deptId, managerId);
        }

    }
}