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
            txtName = new TextBox();
            LabelEmail = new Label();
            statusStrip1 = new StatusStrip();
            txtEmail = new TextBox();
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
            LabelName.Size = new Size(137, 25);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name              :";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Location = new Point(75, 202);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(140, 25);
            LabelRole.TabIndex = 2;
            LabelRole.Text = "RoleName       :";
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(249, 194);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(288, 28);
            cmbRole.TabIndex = 3;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // LabelDepartment
            // 
            LabelDepartment.AutoSize = true;
            LabelDepartment.Location = new Point(70, 257);
            LabelDepartment.Name = "LabelDepartment";
            LabelDepartment.Size = new Size(145, 25);
            LabelDepartment.TabIndex = 4;
            LabelDepartment.Text = "Department     :";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(249, 254);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(288, 28);
            cmbDepartment.TabIndex = 5;
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
            LabelManager.Location = new Point(69, 319);
            LabelManager.Name = "LabelManager";
            LabelManager.Size = new Size(143, 25);
            LabelManager.TabIndex = 8;
            LabelManager.Text = "Manager          :";
            // 
            // cmbManager
            // 
            cmbManager.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(249, 316);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(292, 28);
            cmbManager.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(261, 372);
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
            btnCancel.Location = new Point(460, 372);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(249, 94);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Employee Name";
            txtName.Size = new Size(288, 27);
            txtName.TabIndex = 13;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(75, 146);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(138, 25);
            LabelEmail.TabIndex = 14;
            LabelEmail.Text = "Email               :";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 417);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(807, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(249, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter the Employee Mail";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 16;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(807, 439);
            Controls.Add(txtEmail);
            Controls.Add(statusStrip1);
            Controls.Add(LabelEmail);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbManager);
            Controls.Add(LabelManager);
            Controls.Add(label4);
            Controls.Add(cmbDepartment);
            Controls.Add(LabelDepartment);
            Controls.Add(cmbRole);
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
        private TextBox txtName;
        private Label LabelEmail;
        private StatusStrip statusStrip1;
        private TextBox txtEmail;
    }
}