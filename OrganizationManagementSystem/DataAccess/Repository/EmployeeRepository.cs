using Microsoft.EntityFrameworkCore;
using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public int GetCurrentRoleId(int employeeId)
        {
            using (var context = new OrganizationDbContext())
            {
                return context.Employee
                              .Where(e => e.EmployeeId == employeeId)
                              .Select(e => e.RoleId)
                              .FirstOrDefault();
            }
        }

        //selecting the employees who are under the manager
        public List<string> GetEmployeesUnderManager(int managerId)
        {
            using (var context = new OrganizationDbContext())
            {
                return context.Employee
                              .Where(e => e.ManagerId == managerId)
                              .Select(e => e.Name)
                              .ToList();
            }
        }

        //loading the data from the database to display in the datagrid view
        public List<EmployeeGridModel> LoadEmployeeData()
        {
            using (var db = new OrganizationDbContext())
            {
                return (from e in db.Employee
                     join d in db.Department on e.DepartmentId equals d.DepartmentId
                     join r in db.Role on e.RoleId equals r.RoleId
                     join m in db.Employee on e.ManagerId equals m.EmployeeId into mgr
                     from m in mgr.DefaultIfEmpty()
                     select new EmployeeGridModel
                     {
                         EmployeeId = e.EmployeeId,
                         Name = e.Name,
                         RoleName = r.RoleName,
                         Department = d.DepartmentName,
                         Manager = m != null ? m.Name : "-",
                         ManagerId = e.ManagerId
                     }).ToList();
            }
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
                    .OrderBy(e => e.EmployeeId)
                    .Skip((pageNumber - 1) * pageSize)
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
        //Reads rolename,dep and mana from db
        public List<string> GetRole()
        {
            using var db = new OrganizationDbContext();
            return db.Role.Select(r => r.RoleName).ToList();
        }

        public List<string> GetDepartment()
        {
            using var db = new OrganizationDbContext();
            return db.Department.Select(d => d.DepartmentName).ToList();
                }

        public List<string> GetManagers()
        {
            using var db = new OrganizationDbContext();

            var list = db.Employee
                         .Select(e => e.Name)
                         .ToList();

            list.Insert(0, "-"); 
            return list;
        }
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
