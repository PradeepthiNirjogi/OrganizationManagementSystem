using OrganizationManagementSystem.Data;
using OrganizationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OrganizationManagementSystem.Services;
using OrganizationManagementSystem.Helpers;

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

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Name and Email are required");
                return;
            }

            //if (cmbRole.SelectedValue == null ||
            //    cmbDepartment.SelectedValue == null)
            //{
            //    MessageBox.Show("Please select valid Role and Department");
            //    return;
            //}

            string email = txtEmail.Text.Trim();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@org\.com$";

            if (!Regex.IsMatch(email, emailPattern))
            {

                MessageBox.Show(
                        "Please enter a valid email (example: user@org.com).",
                        "Invalid Email",
                        MessageBoxButtons.OK);

                return;
            }

            // 3. Role/Department placeholder check
            if ((int)cmbRole.SelectedValue == -1 ||
                (int)cmbDepartment.SelectedValue == -1)
            {
                MessageBox.Show("Please select valid Role and Department");
                return;
            }


            string roleName = cmbRole.Text;

            // Developer / Tester MUST have a Manager
            if (roleName != "Manager" && cmbManager.SelectedValue == null)
            {
                MessageBox.Show("Developer/Tester must report to a Manager");
                return;
            }

            try
            {
                using (var db = new OrganizationDbContext())
                {
                    Employee emp = new Employee
                    {
                        Name = txtName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        RoleId = Convert.ToInt32(cmbRole.SelectedValue),
                        //int RoleId = (int)cmbRole.SelectedValue,
                        DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue),

                        ManagerId=roleName=="Manager"
                                    ? null
                                    : Convert.ToInt32(cmbManager.SelectedValue),

                        CreatedDate = DateTime.Now
                    };

                    db.Employee.Add(emp);
                    db.SaveChanges();
                }

                MessageBox.Show("Employee added successfully ");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.InnerException?.Message ?? ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Manager")
            {
                cmbManager.SelectedIndex = -1;
                cmbManager.Enabled = false;
            }
            else
            {
                cmbManager.Enabled = true;
            }
        }
    }
}
