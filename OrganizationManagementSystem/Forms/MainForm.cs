using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.DataAccess.Repository;
using OrganizationManagementSystem.Models;
using OrganizationManagementSystem.Services;
using Serilog;
using System.Reflection.PortableExecutable;

namespace OrganizationManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        private readonly EmployeeService employeeService = new EmployeeService();
        private readonly EmployeeRepository repo = new EmployeeRepository();
        private HamburgerMenuControl hamburgerMenuControl1;

        private int currentPage = 1;
        private int pagesize = 10;
        public MainForm()
        {
            InitializeComponent();
            LoadEmployee();
            employeeFilterControl1.LoadFilterDropdowns();
            employeeFilterControl1.DisableFilterFields();

            InitializeHamburgerMenu();

            employeeFilterControl1.SearchClicked += EmployeeFilter_Search;
            employeeFilterControl1.ClearClicked += EmployeeFilter_Clear;


        }

        // ================= LOAD =================
        //private void LoadEmployee()
        //{
        //    Log.Information("loading the data");
        //    var data = repo.LoadEmployeeData();
        //    dgvEmployees.DataSource = data;

        //}
        private void LoadEmployee()
        {
            Log.Information("Loading paginated employee data");

            currentPage = 1;

            dgvEmployees.DataSource = employeeService.FilterRecord(
                roleId: 0,
                deptId: 0,
                name: null,
                managerId: 0,
                pageNumber: currentPage,
                pageSize: pagesize
            );
        }


        // ================= ADD =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Log.Information("Adding new employee");
            new AddEmployeeForm().ShowDialog();

        }


        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvEmployees.ReadOnly = false;
            dgvEmployees.Columns["EmployeeId"].ReadOnly = true;
            dgvEmployees.Columns["Name"].ReadOnly = false;
            EnableDropdownColumns();
        }

        // ================= SAVE =================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            Log.Information("updation started");
            try
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
                        Log.Warning("Name,Role,Department are mandatory");
                        MessageBox.Show("Name, Role and Department are mandatory.");
                        return;
                    }
                    //int roleId = GetRoleId(role, db);
                    //int deptId = GetDepartmentId(dept, db);
                    //int? managerId = role == "Manager"
                    //    ? null
                    //    : GetManagerId(manager, db);
                    await employeeService.SaveEmployee(
                                      id,
                                      name,
                                      role,
                                      dept,
                                      manager);

                }
                dgvEmployees.ReadOnly = true;
                Log.Information("updated successfully");
                MessageBox.Show("Changes saved");
            }
            catch (Exception exc)
            {
                Log.Error("updation is unsuccefull {exc}", exc.Message);
                MessageBox.Show(exc.Message);
            }
        }
        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Log.Information("Deleting the selected employee");
            try
            {
                if (dgvEmployees.SelectedRows.Count == 0)
                {
                    Log.Warning("please select a record to delete");
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }


                string roleName = (string)dgvEmployees.SelectedRows[0].Cells["RoleName"].Value;
                string name = (string)dgvEmployees.SelectedRows[0].Cells["Name"].Value;
                int id = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value);
                List<string> empnames = employeeService.GetEmployeeDetailsUnderManager(id);

                //checking if employee is a manager first update the manager for employees who are under deleting manager
                Log.Information("if any managers has subcordinates then first need to edit the managers for subcordinates");
                if (roleName == "Manager" && empnames.Count > 0)
                {
                    if (empnames.Any())
                    {
                        string employees = string.Join(", ", empnames);
                        Log.Information($"{employees} under {empnames}");
                        MessageBox.Show(
                            $"{name} is the manager for other employees.\n\n" +
                            $"Please update the manager for these employees before deleting:\n" +
                            employees,
                            "Delete Not Allowed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }
                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);
                int employeeId =
                    Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

                if (confirm != DialogResult.Yes)
                {
                    Log.Warning("Delete cancelled by user");
                    return;
                }

                employeeService.DeleteEmployee(employeeId);
                Log.Information("Employee deleted successfully");
                MessageBox.Show("Employee deleted successfully");
            }
            catch (Exception ex)
            {
                Log.Error("unexpected error occured during deletion {ex}", ex.Message);
                MessageBox.Show("unexpected error occured during deletion {ex}\", ex.Message");
            }
        }

        // ================= FILTER =================
        private void btnFilter_Click(object sender, EventArgs e)
        {
            employeeFilterControl1.Visible = true;
            //employeeFilterControl1.EnableFilterFields();
            //employeeFilterControl1.LoadFilterDropdowns();
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
                DataSource = repo.GetRole()
            });

            dgvEmployees.Columns.Remove("Department");
            dgvEmployees.Columns.Insert(3, new DataGridViewComboBoxColumn
            {
                Name = "Department",
                DataPropertyName = "Department",
                DataSource = repo.GetDepartment()
            });

            dgvEmployees.Columns.Remove("Manager");
            dgvEmployees.Columns.Insert(4, new DataGridViewComboBoxColumn
            {
                Name = "Manager",
                DataPropertyName = "Manager",
                DataSource = repo.GetManagers()
            });
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            Log.Information("clicking on the next btn loading next page");
            currentPage++;
            Log.Information("loaded successfully");
            ApplyFilter();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Log.Information("clicking on the prev btn loading prev page");
            if (currentPage > 1)
            {
                currentPage--;
                Log.Information("loaded successfully");
                ApplyFilter();
            }
        }

        private void btnMenuFilter_Click(object sender, EventArgs e)
        {
            employeeFilterControl1.Visible =
                !employeeFilterControl1.Visible;
        }

        private void employeeFilterControl1_Load(object sender, EventArgs e)
        {

        }


        //addmenu
        private void Hamburger_AddClicked(object sender, EventArgs e)
        {

            hamburgerMenuControl1.Width = 0;
            DisableSearchMode();
            new AddEmployeeForm().ShowDialog();
            LoadEmployee();
        }

        //updatemenu
        private void Hamburger_UpdateClicked(object sender, EventArgs e)
        {
            //hamburgerMenuControl1.Visible = false;
            hamburgerMenuControl1.Width = 0;
            DisableSearchMode();
            //btnUpdate.PerformClick();
            ExecuteUpdate();
        }

        //deletemenu
        private void Hamburger_DeleteClicked(object sender, EventArgs e)
        {
            //hamburgerMenuControl1.Visible = false;
            hamburgerMenuControl1.Width = 0;
            DisableSearchMode();
            //btnDelete.PerformClick();
            ExecuteDelete();
        }

        //searchmenu
        private void Hamburger_SearchClicked(object sender, EventArgs e)
        {
            hamburgerMenuControl1.Width = 0;
            employeeFilterControl1.Visible = true;
            employeeFilterControl1.EnableFilterFields();
        }

        private void InitializeHamburgerMenu()
        {
            hamburgerMenuControl1 = new HamburgerMenuControl();

            hamburgerMenuControl1.Dock = DockStyle.Left;
            hamburgerMenuControl1.Width = 0;
            hamburgerMenuControl1.Visible = true;

            hamburgerMenuControl1.AddClicked += Hamburger_AddClicked;
            hamburgerMenuControl1.UpdateClicked += Hamburger_UpdateClicked;
            hamburgerMenuControl1.DeleteClicked += Hamburger_DeleteClicked;
            hamburgerMenuControl1.SearchClicked += Hamburger_SearchClicked;

            pnlBody.Controls.Add(hamburgerMenuControl1);
            hamburgerMenuControl1.BringToFront();
        }

        private void btnHamburger_Click_1(object sender, EventArgs e)
        {
            hamburgerMenuControl1.Visible = true;
            if (hamburgerMenuControl1.Width == 0)
            {
                hamburgerMenuControl1.Width = 220;
            }
            else
            {
                hamburgerMenuControl1.Width = 0;   // col
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlHeader.BringToFront();
        }

        private void hamburgerMenuControl2_Load(object sender, EventArgs e)
        {

        }

        private void ExecuteUpdate()
        {
            if (dgvEmployees.Rows.Count == 0)
            {
                MessageBox.Show("No records available to update.");
                return;
            }

            dgvEmployees.ReadOnly = false;
            dgvEmployees.Columns["EmployeeId"].ReadOnly = true;
            dgvEmployees.Columns["Name"].ReadOnly = false;
            EnableDropdownColumns();
        }

        private void ExecuteDelete()
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            btnDelete_Click(this, EventArgs.Empty);
        }


        private void DisableSearchMode()
        {
            employeeFilterControl1.Visible = false;
        }

        private void pnlBody_Click(object sender, EventArgs e)
        {
            CloseHamburgerMenuIfOpen();
        }

        private void CloseHamburgerMenuIfOpen()
        {
            hamburgerMenuControl1.Visible = false;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
