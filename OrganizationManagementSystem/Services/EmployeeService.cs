using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrganizationManagementSystem.Services
{
    public class EmployeeService
    {
        // ================= FILTER =================
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
                context.SaveChanges();
            }
        }

        // ================= UPDATE =================
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
    }
}