using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrganizationManagementSystem.Helpers
{
    public static class DropdownHelper
    {
        public static void LoadRoles(ComboBox comboBox)
        {
            using (var db = new OrganizationDbContext())
            {
                var roles = db.Role.ToList();
                roles.Insert(0, new Role
                {
                    RoleId = 0,
                    RoleName = "-- Select Role --"
                });

                comboBox.DataSource = roles;
                comboBox.DisplayMember = "RoleName";
                comboBox.ValueMember = "RoleId";
                comboBox.SelectedIndex = 0;
            }
        }

        public static void LoadDepartments(ComboBox comboBox)
        {
            using (var db = new OrganizationDbContext())
            {
                var departments = db.Department.ToList();
                departments.Insert(0, new Department
                {
                    DepartmentId = 0,
                    DepartmentName = "-- Select Department --"
                });

                comboBox.DataSource = departments;
                comboBox.DisplayMember = "DepartmentName";
                comboBox.ValueMember = "DepartmentId";
                comboBox.SelectedIndex = 0;
            }
        }

        // Load Departments
        //        //cmbDepartment.DataSource = db.Department.ToList();
        //        //cmbDepartment.DisplayMember = "DepartmentName";
        //        //cmbDepartment.ValueMember = "DepartmentId";

        public static void LoadManagers(ComboBox comboBox)
        {
            using (var db = new OrganizationDbContext())
            {
                var managers = db.Employee
                                 .Where(x => x.RoleId == 1)
                                 .ToList();

                managers.Insert(0, new Employee
                {
                    EmployeeId = 0,
                    Name = "-- Select Manager --"
                });

                comboBox.DataSource = managers;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "EmployeeId";
                comboBox.SelectedIndex = 0;
            }
        }
    }
}