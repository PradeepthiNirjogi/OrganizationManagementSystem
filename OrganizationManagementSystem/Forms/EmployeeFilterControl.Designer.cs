namespace OrganizationManagementSystem.Forms
{
    partial class EmployeeFilterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmployeeName = new Label();
            txtName = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblDept = new Label();
            groupBox1 = new GroupBox();
            cmbDepartment = new ComboBox();
            lblManager = new Label();
            cmbManager = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            OrganizationManagementSystem = new Label();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.AutoSize = true;
            txtEmployeeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(32, 73);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(165, 23);
            txtEmployeeName.TabIndex = 0;
            txtEmployeeName.Text = "EmployeeName     :";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 27);
            txtName.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = SystemColors.ControlText;
            lblRole.Location = new Point(438, 76);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(90, 23);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role        :";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(567, 75);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 3;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDept.Location = new Point(39, 125);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(158, 23);
            lblDept.TabIndex = 4;
            lblDept.Text = "Department         :";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(352, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(220, 124);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(162, 28);
            cmbDepartment.TabIndex = 6;
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManager.Location = new Point(437, 124);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(91, 23);
            lblManager.TabIndex = 7;
            lblManager.Text = "Manager :";
            // 
            // cmbManager
            // 
            cmbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(577, 124);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(151, 28);
            cmbManager.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.ForeColor = Color.WhiteSmoke;
            btnSearch.Location = new Point(319, 170);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlDark;
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.Location = new Point(438, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // OrganizationManagementSystem
            // 
            OrganizationManagementSystem.AutoSize = true;
            OrganizationManagementSystem.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrganizationManagementSystem.ForeColor = Color.Navy;
            OrganizationManagementSystem.Location = new Point(220, 14);
            OrganizationManagementSystem.Name = "OrganizationManagementSystem";
            OrganizationManagementSystem.Size = new Size(478, 33);
            OrganizationManagementSystem.TabIndex = 11;
            OrganizationManagementSystem.Text = "Organization Management System";
            // 
            // EmployeeFilterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrganizationManagementSystem);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(cmbManager);
            Controls.Add(lblManager);
            Controls.Add(cmbDepartment);
            Controls.Add(groupBox1);
            Controls.Add(lblDept);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(txtName);
            Controls.Add(txtEmployeeName);
            Name = "EmployeeFilterControl";
            Size = new Size(838, 473);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtEmployeeName;
        private TextBox txtName;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblDept;
        private GroupBox groupBox1;
        private ComboBox cmbDepartment;
        private Label lblManager;
        private ComboBox cmbManager;
        private Button btnSearch;
        private Button btnClear;
        private Label OrganizationManagementSystem;
    }
}
