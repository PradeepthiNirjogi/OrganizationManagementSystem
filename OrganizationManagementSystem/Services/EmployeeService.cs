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
            return repo.FilterRecord(roleId, deptId, name, managerId, pageNumber, pageSize);
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
        public async Task SaveEmployee(
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

            int? newmanagerId = role == "Manager"
                ? null
                : repo.GetManagerId(manager);

            //if (role != "Manager" && managerId == null)
            //{
            //    throw new Exception("Employee must report to a Manager.");
            //}
            // to get the roleid of a manager;
            int managerroleId = repo.GetRoleId("Manager");
            //to get the role id of a current roleid before changing
            //int currentRoleId = repo.GetCurrentRoleId(id);
            //if (currentRoleId ==  managerroleId && roleId != managerroleId)
            //{
            //    throw new Exception("manager can't be a employee");
            //}
            //if (roleId ==managerroleId)
            //{
            //    manager = null;
            //    Log.Information("when the roles like developer or other becomes managers the manager id need to be null");

            //}
            //if (roleId != managerroleId)
            //{
            //    if (!string.IsNullOrWhiteSpace(manager) && manager != "-")
            //    {
            //        if (string.Equals(name?.Trim(), manager?.Trim(), StringComparison.OrdinalIgnoreCase))
            //        {
            //            Log.Information("Employee name and manager name should be different. Employee: {Name}", name);
            //            throw new Exception("Employee name should not be the same as Manager name");
            //        }
            //        newmanagerId = repo.GetManagerId(manager);
            //    }
            //}
            // replace your current checks with something like:
            //int managerroleId = repo.GetRoleId("Manager");
            int currentRoleId = repo.GetCurrentRoleId(id);

            if (currentRoleId == managerroleId && roleId != managerroleId)
                throw new Exception("manager can't be a employee");

            // If new role is Manager, ensure no manager was selected
            if (roleId == managerroleId)
            {
                if (!string.IsNullOrWhiteSpace(manager) && manager != "-")
                {
                    Log.Information("Attempt to assign a manager to a Manager");
                    throw new Exception("Manager can't be assigned to manager");
                }
                newmanagerId = null;
                Log.Information("Role changed to Manager; clearing manager assignment");
            }
            else
            {
                // For non-managers ensure manager is not the same person
                if (!string.IsNullOrWhiteSpace(manager) && manager != "-")
                {
                    if (string.Equals(name?.Trim(), manager?.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        Log.Information("Employee name and manager name should be different. Employee: {Name}", name);
                        throw new Exception("Employee name should not be the same as Manager name");
                    }
                    newmanagerId = repo.GetManagerId(manager);
                }
                else
                {
                    newmanagerId = null;
                }
            }
            //if (role == manager)
            //{
            //    throw new Exception("Manager can't be a developer");
            //}

            repo.UpdateEmployee(id, name, roleId, deptId, newmanagerId);
        }

         
    // ================= EMAIL VALIDATION =================
    public bool IsEmailExists(string email)
    {
        using (var context = new OrganizationDbContext())
        {
            return context.Employee
                .Any(e => e.Email.ToLower() == email.ToLower());
        }
}

// ================= ADD =================
 public void AddEmployee(Employee model)
{
    if (model == null)
        throw new Exception("Employee data is missing");

    if (IsEmailExists(model.Email))
        throw new Exception("Email already exists");

    if (model.ManagerId != null && model.ManagerId == model.EmployeeId)
        throw new Exception("Employee cannot be their own manager");

    repo.Add(model);
}


public List<string> GetEmployeeDetailsUnderManager(int id)
        {
           return repo.GetEmployeesUnderManager(id);
        }

    }
}