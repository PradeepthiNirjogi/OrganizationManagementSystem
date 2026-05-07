namespace OrganizationManagementSystem.Forms
{
    partial class MainForm
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
            Label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnFilter = new Button();
            btnRefresh = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            pnlBody = new Panel();
            employeeFilterControl1 = new EmployeeFilterControl();
            label2 = new Label();
            pnlHeader = new Panel();
            btnHamburger = new Button();
            dgvEmployees = new DataGridView();
            pnlBody.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(51, 153);
            Label1.Name = "Label1";
            Label1.Size = new Size(185, 28);
            Label1.TabIndex = 0;
            Label1.Text = "Employee Records";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(324, 127);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Salmon;
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(494, 524);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UpdateRecord";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(531, 127);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DeleteRecord";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(682, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 38);
            btnSave.TabIndex = 5;
            btnSave.Text = "SaveRecord";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Indigo;
            btnFilter.ForeColor = Color.WhiteSmoke;
            btnFilter.Location = new Point(275, 524);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(133, 36);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "FilterRecord";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Tan;
            btnRefresh.Location = new Point(839, 153);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 38);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "RefreshData";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.RosyBrown;
            btnNext.ForeColor = Color.WhiteSmoke;
            btnNext.Location = new Point(847, 524);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 31);
            btnNext.TabIndex = 9;
            btnNext.Text = "NextPage";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.WindowFrame;
            btnPrevious.ForeColor = Color.WhiteSmoke;
            btnPrevious.Location = new Point(722, 524);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(119, 31);
            btnPrevious.TabIndex = 10;
            btnPrevious.Text = "PreviousPage";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.WhiteSmoke;
            pnlBody.Controls.Add(employeeFilterControl1);
            pnlBody.Controls.Add(label2);
            pnlBody.Controls.Add(pnlHeader);
            pnlBody.Controls.Add(Label1);
            pnlBody.Controls.Add(btnPrevious);
            pnlBody.Controls.Add(dgvEmployees);
            pnlBody.Controls.Add(btnFilter);
            pnlBody.Controls.Add(btnRefresh);
            pnlBody.Controls.Add(btnNext);
            pnlBody.Controls.Add(btnAdd);
            pnlBody.Controls.Add(btnSave);
            pnlBody.Controls.Add(btnUpdate);
            pnlBody.Controls.Add(btnDelete);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 0);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1059, 800);
            pnlBody.TabIndex = 12;
            pnlBody.Click += pnlBody_Click;
            // 
            // employeeFilterControl1
            // 
            employeeFilterControl1.Location = new Point(51, 561);
            employeeFilterControl1.Name = "employeeFilterControl1";
            employeeFilterControl1.Size = new Size(895, 220);
            employeeFilterControl1.TabIndex = 13;
            employeeFilterControl1.Visible = false;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(179, 61);
            label2.Name = "label2";
            label2.Size = new Size(635, 53);
            label2.TabIndex = 0;
            label2.Text = "Organization Management System";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ActiveCaption;
            pnlHeader.Controls.Add(btnHamburger);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1059, 46);
            pnlHeader.TabIndex = 12;
            // 
            // btnHamburger
            // 
            btnHamburger.BackColor = SystemColors.ActiveCaption;
            btnHamburger.FlatAppearance.BorderSize = 0;
            btnHamburger.FlatStyle = FlatStyle.Flat;
            btnHamburger.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHamburger.Location = new Point(7, -8);
            btnHamburger.Name = "btnHamburger";
            btnHamburger.Size = new Size(62, 54);
            btnHamburger.TabIndex = 0;
            btnHamburger.Text = "☰";
            btnHamburger.UseVisualStyleBackColor = false;
            btnHamburger.Click += btnHamburger_Click_1;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(51, 197);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(909, 321);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 800);
            Controls.Add(pnlBody);
            Name = "MainForm";
            Text = "MainForm";
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnFilter;
        private Button btnRefresh;
        private Button btnNext;
        private Button btnPrevious;
        private Panel pnlBody;
        private Panel pnlHeader;
        private Button btnHamburger;
        private DataGridView dgvEmployees;
        private Label label2;
        private EmployeeFilterControl employeeFilterControl1;
        //private HamburgerMenuControl hamburgerMenuControl1;
    }
}