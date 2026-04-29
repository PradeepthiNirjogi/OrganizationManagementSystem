using OrganizationManagementSystem.Helpers;
using System;
using System.Windows.Forms;

namespace OrganizationManagementSystem.Forms
{
    public partial class EmployeeFilterControl : UserControl
    {
        public EmployeeFilterControl()
        {
            InitializeComponent();
            DisableFilterFields();
        }

        // ================= ENABLE / DISABLE =================

        // Disables all filter inputs initially
        public void DisableFilterFields()
        {
            txtName.Enabled = false;
            cmbRole.Enabled = false;
            cmbDepartment.Enabled = false;
            cmbManager.Enabled = false;
            btnSearch.Enabled = false;
            btnClear.Enabled = false;
        }

        // Enables filter inputs when FilterRecord is clicked
        public void EnableFilterFields()
        {
            txtName.Enabled = true;
            cmbRole.Enabled = true;
            cmbDepartment.Enabled = true;
            cmbManager.Enabled = true;
            btnSearch.Enabled = true;
            btnClear.Enabled = true;
        }

        // ================= DROPDOWNS =================

        // Loads Role, Department, Manager using shared helper
        public void LoadFilterDropdowns()
        {
            DropdownHelper.LoadDepartments(cmbDepartment);
            DropdownHelper.LoadManagers(cmbManager);
            DropdownHelper.LoadRoles(cmbRole);
        }

        // ================= EVENTS =================

        // Events exposed to MainForm
        public event EventHandler SearchClicked;
        public event EventHandler ClearClicked;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Notify MainForm that Search was clicked
            SearchClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Notify MainForm that Clear was clicked
            ClearClicked?.Invoke(this, EventArgs.Empty);
        }

        // ================= PUBLIC PROPERTIES =================
        // These are READ-ONLY values MainForm will consume

        public string EmployeeName => txtName.Text.Trim();

        public int RoleId =>
            cmbRole.SelectedValue==null?0:(int)cmbRole.SelectedValue;

        public int DepartmentId =>
            cmbDepartment.SelectedValue==null?0:(int)cmbDepartment.SelectedValue;

        public int ManagerId =>
            cmbManager.SelectedValue==null?0:(int)cmbManager.SelectedValue;

        // ================= CLEAR =================

        public void ClearFields()
        {
            txtName.Clear();
            cmbRole.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            cmbManager.SelectedIndex = 0;
        }
    }
}