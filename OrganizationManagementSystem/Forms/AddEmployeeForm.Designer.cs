namespace OrganizationManagementSystem.Forms
{
    partial class AddEmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LabelName = new Label();
            LabelRole = new Label();
            cmbRole = new ComboBox();
            LabelDepartment = new Label();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            LabelManager = new Label();
            cmbManager = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            LabelEmail = new Label();
            statusStrip1 = new StatusStrip();
            txtEmail = new TextBox();
            lblNameError = new Label();
            txtName = new TextBox();
            pnlNameBorder = new Panel();
            pnlEmailBorder = new Panel();
            pnlRoleNameBorder = new Panel();
            pnlDeptBorder = new Panel();
            pnlManagerBorder = new Panel();
            lblEmailError = new Label();
            lblRoleNameError = new Label();
            lblDeptError = new Label();
            lblManagerError = new Label();
            pnlNameBorder.SuspendLayout();
            pnlEmailBorder.SuspendLayout();
            pnlRoleNameBorder.SuspendLayout();
            pnlDeptBorder.SuspendLayout();
            pnlManagerBorder.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter Employee Details";
            label1.Click += label1_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(75, 94);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(145, 25);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name *             :";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Location = new Point(67, 328);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(148, 25);
            LabelRole.TabIndex = 2;
            LabelRole.Text = "RoleName *      :";
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(311, 28);
            cmbRole.TabIndex = 3;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // LabelDepartment
            // 
            LabelDepartment.AutoSize = true;
            LabelDepartment.Location = new Point(67, 253);
            LabelDepartment.Name = "LabelDepartment";
            LabelDepartment.Size = new Size(153, 25);
            LabelDepartment.TabIndex = 4;
            LabelDepartment.Text = "Department *    :";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(3, 3);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(310, 28);
            cmbDepartment.TabIndex = 5;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 257);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 6;
            // 
            // LabelManager
            // 
            LabelManager.AutoSize = true;
            LabelManager.Location = new Point(70, 406);
            LabelManager.Name = "LabelManager";
            LabelManager.Size = new Size(143, 25);
            LabelManager.TabIndex = 8;
            LabelManager.Text = "Manager          :";
            // 
            // cmbManager
            // 
            cmbManager.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(6, 3);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(308, 28);
            cmbManager.TabIndex = 9;
            cmbManager.SelectedIndexChanged += cmbManager_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(249, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(449, 482);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(75, 171);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(151, 25);
            LabelEmail.TabIndex = 14;
            LabelEmail.Text = "Email *               :";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 538);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(936, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(3, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter the Employee Mail";
            txtEmail.Size = new Size(311, 27);
            txtEmail.TabIndex = 16;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(253, 125);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(0, 17);
            lblNameError.TabIndex = 17;
            lblNameError.Visible = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Employee Name";
            txtName.Size = new Size(311, 27);
            txtName.TabIndex = 13;
            txtName.Leave += txtName_Leave;
            // 
            // pnlNameBorder
            // 
            pnlNameBorder.BackColor = Color.LightGray;
            pnlNameBorder.Controls.Add(txtName);
            pnlNameBorder.Location = new Point(260, 94);
            pnlNameBorder.Name = "pnlNameBorder";
            pnlNameBorder.Size = new Size(317, 34);
            pnlNameBorder.TabIndex = 18;
            // 
            // pnlEmailBorder
            // 
            pnlEmailBorder.BackColor = Color.LightGray;
            pnlEmailBorder.Controls.Add(txtEmail);
            pnlEmailBorder.Location = new Point(260, 171);
            pnlEmailBorder.Name = "pnlEmailBorder";
            pnlEmailBorder.Size = new Size(317, 34);
            pnlEmailBorder.TabIndex = 18;
            // 
            // pnlRoleNameBorder
            // 
            pnlRoleNameBorder.BackColor = Color.LightGray;
            pnlRoleNameBorder.Controls.Add(cmbDepartment);
            pnlRoleNameBorder.Location = new Point(260, 253);
            pnlRoleNameBorder.Name = "pnlRoleNameBorder";
            pnlRoleNameBorder.Size = new Size(317, 34);
            pnlRoleNameBorder.TabIndex = 18;
            // 
            // pnlDeptBorder
            // 
            pnlDeptBorder.BackColor = Color.LightGray;
            pnlDeptBorder.Controls.Add(cmbRole);
            pnlDeptBorder.Location = new Point(261, 326);
            pnlDeptBorder.Name = "pnlDeptBorder";
            pnlDeptBorder.Size = new Size(317, 34);
            pnlDeptBorder.TabIndex = 18;
            // 
            // pnlManagerBorder
            // 
            pnlManagerBorder.BackColor = Color.LightGray;
            pnlManagerBorder.Controls.Add(cmbManager);
            pnlManagerBorder.Location = new Point(257, 405);
            pnlManagerBorder.Name = "pnlManagerBorder";
            pnlManagerBorder.Size = new Size(317, 34);
            pnlManagerBorder.TabIndex = 18;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(264, 208);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 17);
            lblEmailError.TabIndex = 19;
            lblEmailError.Visible = false;
            // 
            // lblRoleNameError
            // 
            lblRoleNameError.AutoSize = true;
            lblRoleNameError.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoleNameError.ForeColor = Color.Red;
            lblRoleNameError.Location = new Point(264, 290);
            lblRoleNameError.Name = "lblRoleNameError";
            lblRoleNameError.Size = new Size(0, 17);
            lblRoleNameError.TabIndex = 20;
            lblRoleNameError.Visible = false;
            // 
            // lblDeptError
            // 
            lblDeptError.AutoSize = true;
            lblDeptError.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeptError.ForeColor = Color.Red;
            lblDeptError.Location = new Point(263, 363);
            lblDeptError.Name = "lblDeptError";
            lblDeptError.Size = new Size(0, 17);
            lblDeptError.TabIndex = 21;
            lblDeptError.Click += label2_Click;
            // 
            // lblManagerError
            // 
            lblManagerError.AutoSize = true;
            lblManagerError.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagerError.ForeColor = Color.Red;
            lblManagerError.Location = new Point(264, 442);
            lblManagerError.Name = "lblManagerError";
            lblManagerError.Size = new Size(0, 17);
            lblManagerError.TabIndex = 22;
            lblManagerError.Visible = false;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(936, 560);
            Controls.Add(lblManagerError);
            Controls.Add(lblDeptError);
            Controls.Add(lblRoleNameError);
            Controls.Add(lblEmailError);
            Controls.Add(pnlManagerBorder);
            Controls.Add(pnlDeptBorder);
            Controls.Add(pnlRoleNameBorder);
            Controls.Add(pnlEmailBorder);
            Controls.Add(pnlNameBorder);
            Controls.Add(lblNameError);
            Controls.Add(statusStrip1);
            Controls.Add(LabelEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(LabelManager);
            Controls.Add(label4);
            Controls.Add(LabelDepartment);
            Controls.Add(LabelRole);
            Controls.Add(LabelName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(20, 20);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Employee";
            Load += AddEmployeeForm_Load;
            pnlNameBorder.ResumeLayout(false);
            pnlNameBorder.PerformLayout();
            pnlEmailBorder.ResumeLayout(false);
            pnlEmailBorder.PerformLayout();
            pnlRoleNameBorder.ResumeLayout(false);
            pnlDeptBorder.ResumeLayout(false);
            pnlManagerBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LabelName;
        private Label LabelRole;
        private ComboBox cmbRole;
        private Label LabelDepartment;
        private ComboBox cmbDepartment;
        private Label label4;
        private Label LabelManager;
        private ComboBox cmbManager;
        private Button btnSave;
        private Button btnCancel;
        private Label LabelEmail;
        private StatusStrip statusStrip1;
        private TextBox txtEmail;
        private Label lblNameError;
        private TextBox txtName;
        private Panel pnlNameBorder;
        private Panel pnlEmailBorder;
        private Panel pnlRoleNameBorder;
        private Panel pnlDeptBorder;
        private Panel pnlManagerBorder;
        private Label lblEmailError;
        private Label lblRoleNameError;
        private Label lblDeptError;
        private Label lblManagerError;
    }
}