using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Helpers;
using OrganizationManagementSystem.Models;
using Serilog;
using System.Text.RegularExpressions;

namespace OrganizationManagementSystem.Forms
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void LoadDropdowns()
        {
            DropdownHelper.LoadRoles(cmbRole);
            DropdownHelper.LoadDepartments(cmbDepartment);
            DropdownHelper.LoadManagers(cmbManager);
        }

        private bool isFormLoading = true;
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            isFormLoading = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //UI -Validations
        private bool ValidateName()
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                name.Length < 2 ||
                !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                lblNameError.Text = ValidationMessages.NameRequired;
                lblNameError.Visible = true;
                pnlNameBorder.BackColor = Color.LightCoral;

                return false;
            }
            lblNameError.Visible = false;
            pnlNameBorder.BackColor = Color.Gray;
            lblNameError.Visible = false;
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Text = ValidationMessages.EmailRequired;
                lblEmailError.Visible = true;
                pnlEmailBorder.BackColor = Color.LightCoral;
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@]+@[^@]+\.[^@]+$"))
            {
                lblEmailError.Text = ValidationMessages.EmailInvalid;
                pnlEmailBorder.BackColor = Color.LightCoral;
                lblEmailError.Visible = true;
                return false;
            }

            lblEmailError.Visible = false;
            pnlEmailBorder.BackColor = Color.Gray;
            return true;
        }

        private bool ValidateRole()
        {
            if (isFormLoading) return true;

            if (!int.TryParse(cmbRole.SelectedValue?.ToString(), out int roleId) || roleId == 0)
            {
                lblRoleNameError.Text = ValidationMessages.RoleRequired;
                lblRoleNameError.Visible = true;
                pnlRoleNameBorder.BackColor = Color.LightCoral;
                return false;
            }

            lblRoleNameError.Visible = false;
            pnlRoleNameBorder.BackColor = Color.Gray;
            return true;
        }
        private bool ValidateDepartment()
        {
            if (isFormLoading) return true;

            if (!int.TryParse(cmbDepartment.SelectedValue?.ToString(), out int deptId) || deptId == 0)
            {
                lblDeptError.Text = ValidationMessages.DepartmentRequired;
                lblDeptError.Visible = true;
                pnlDeptBorder.BackColor = Color.LightCoral;
                return false;
            }

            lblDeptError.Visible = false;
            pnlDeptBorder.BackColor = Color.Gray;
            return true;
        }

        private bool ValidateManager()
        {
            if (isFormLoading) return true;

            if (cmbRole.Text != "Manager")
            {
                if (!int.TryParse(cmbManager.SelectedValue?.ToString(), out int mgrId) || mgrId == 0)
                {
                    lblManagerError.Text = ValidationMessages.ManagerRequired;
                    lblManagerError.Visible = true;
                    pnlManagerBorder.BackColor = Color.LightCoral;
                    return false;
                }
            }

            lblManagerError.Visible = false;
            pnlManagerBorder.BackColor = Color.Gray;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid =
                ValidateName() &&
                ValidateEmail() &&
                ValidateRole() &&
                ValidateDepartment() &&
                ValidateManager();

            if (!isValid)
                return;

            // Save logic

            try
            {
                using (var db = new OrganizationDbContext())
                {
                    Employee emp = new Employee
                    {
                        Name = txtName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        RoleId = (int)cmbRole.SelectedValue,
                        DepartmentId = (int)cmbDepartment.SelectedValue,
                        ManagerId = cmbRole.Text == "Manager"
                                    ? null
                                    : (int)cmbManager.SelectedValue,
                        CreatedDate = DateTime.Now
                    };

                    db.Employee.Add(emp);
                    db.SaveChanges();
                }
                Log.Information($"added employee successfully \"{txtName.Text.Trim()}\"");
                MessageBox.Show("Employee added successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error("Error occured while adding employee");
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;

            ValidateRole();

            if (cmbRole.Text == "Manager")
            {
                cmbManager.SelectedIndex = 0;
                cmbManager.Enabled = false;

            }
            else
            {
                cmbManager.Enabled = true;
                ValidateManager();
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }



        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;
            ValidateDepartment();
        }

        private void cmbManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;
            ValidateManager();
        }

    }
}
