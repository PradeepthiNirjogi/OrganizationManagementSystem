using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Models;
using OrganizationManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrganizationManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        private readonly EmployeeService employeeService = new EmployeeService();

        // ================= FORM LOAD =================
        public MainForm()
        {
            InitializeComponent();
            LoadEmployee();

            employeeFilterControl1.SearchClicked += EmployeeFilter_Search;
            employeeFilterControl1.ClearClicked += EmployeeFilter_Clear;
        }

        // ================= LOAD =================
        private void LoadEmployee()
        {
            using (var db = new OrganizationDbContext())
            {
                var data =
                    from e in db.Employee
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
                    };

                dgvEmployees.DataSource = data.ToList();
            }
        }

        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().ShowDialog();
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvEmployees.ReadOnly = false;
            dgvEmployees.Columns["EmployeeId"].ReadOnly = true;
            EnableDropdownColumns();
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new OrganizationDbContext())
            {
                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    if (row.IsNewRow) continue;
                    //Read data from grid
                    int id = Convert.ToInt32(row.Cells["EmployeeId"].Value);
                    string name = row.Cells["Name"].Value?.ToString();
                    string role = row.Cells["RoleName"].Value?.ToString();
                    string dept = row.Cells["Department"].Value?.ToString();
                    string manager = row.Cells["Manager"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(name) ||
                        string.IsNullOrWhiteSpace(role) ||
                        string.IsNullOrWhiteSpace(dept))
                    {
                        MessageBox.Show("Name, Role and Department are mandatory.");
                        return;
                    }

                    int roleId = GetRoleId(role, db);
                    int deptId = GetDepartmentId(dept, db);
                    int? managerId = role == "Manager"
                        ? null
                        : GetManagerId(manager, db);

                    if (role != "Manager" && managerId == null)
                    {
                        MessageBox.Show("Employee must report to a Manager.");
                        return;
                    }

                    employeeService.UpdateEmployee(id, name, roleId, deptId, managerId);
                }
            }

            dgvEmployees.ReadOnly = true;
            MessageBox.Show("Changes saved");
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            int employeeId =
                Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

            employeeService.DeleteEmployee(employeeId);

            MessageBox.Show("Employee deleted successfully");
        }

        // ================= FILTER =================
        private void btnFilter_Click(object sender, EventArgs e)
        {
            employeeFilterControl1.Visible = true;
            employeeFilterControl1.EnableFilterFields();
            employeeFilterControl1.LoadFilterDropdowns();
        }

        private void EmployeeFilter_Search(object sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            int roleId = employeeFilterControl1.RoleId;
            int deptId = employeeFilterControl1.DepartmentId;
            int managerId = employeeFilterControl1.ManagerId;

            string name = string.IsNullOrWhiteSpace(employeeFilterControl1.EmployeeName)
                ? null
                : employeeFilterControl1.EmployeeName;

            dgvEmployees.DataSource =
                employeeService.FilterRecord(roleId, deptId, name, managerId, currentPage, pagesize);
        }

        // ================= CLEAR FILTER =================
        private void EmployeeFilter_Clear(object sender, EventArgs e)
        {
            employeeFilterControl1.ClearFields();
            LoadEmployee();
            currentPage = 1;
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        // ================= HELPER METHODS =================
        private void EnableDropdownColumns()
        {
            dgvEmployees.Columns.Remove("RoleName");
            dgvEmployees.Columns.Insert(2, new DataGridViewComboBoxColumn
            {
                Name = "RoleName",
                DataPropertyName = "RoleName",
                DataSource = GetRole()
            });

            dgvEmployees.Columns.Remove("Department");
            dgvEmployees.Columns.Insert(3, new DataGridViewComboBoxColumn
            {
                Name = "Department",
                DataPropertyName = "Department",
                DataSource = GetDepartment()
            });

            dgvEmployees.Columns.Remove("Manager");
            dgvEmployees.Columns.Insert(4, new DataGridViewComboBoxColumn
            {
                Name = "Manager",
                DataPropertyName = "Manager",
                DataSource = GetManagers()
            });
        }
        //Reads rolename,dep and mana from db
        private List<string> GetRole()
        {
            using var db = new OrganizationDbContext();
            return db.Role.Select(r => r.RoleName).ToList();
        }

        private List<string> GetDepartment()
        {
            using var db = new OrganizationDbContext();
            return db.Department.Select(d => d.DepartmentName).ToList();
        }

        private List<string> GetManagers()
        {
            using var db = new OrganizationDbContext();
            var list = db.Employee
                .Where(e => e.RoleId == 1)
                .Select(e => e.Name)
                .ToList();
            list.Insert(0, "-");
            return list;
        }

        private int GetRoleId(string role, OrganizationDbContext db)
        {
            return db.Role
                .Where(r => r.RoleName == role)
                .Select(r => r.RoleId)
                .FirstOrDefault();
        }

        private int GetDepartmentId(string dept, OrganizationDbContext db)
        {
            return db.Department
                .Where(d => d.DepartmentName == dept)
                .Select(d => d.DepartmentId)
                .FirstOrDefault();
        }

        private int? GetManagerId(string manager, OrganizationDbContext db)
        {
            if (string.IsNullOrWhiteSpace(manager) || manager == "-")
                return null;

            return db.Employee
                .Where(e => e.Name == manager)
                .Select(e => e.EmployeeId)
                .FirstOrDefault();
        }

        private int currentPage = 1;
        private int pagesize = 10;

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            ApplyFilter();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ApplyFilter();
            }

        }
    }
}
