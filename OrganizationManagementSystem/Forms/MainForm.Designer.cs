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
            dgvEmployees = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnFilter = new Button();
            btnRefresh = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            employeeFilterControl1 = new EmployeeFilterControl();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(62, 245);
            Label1.Name = "Label1";
            Label1.Size = new Size(185, 28);
            Label1.TabIndex = 0;
            Label1.Text = "Employee Records";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(62, 306);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(856, 355);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(513, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Salmon;
            btnUpdate.ForeColor = Color.WhiteSmoke;
            btnUpdate.Location = new Point(627, 717);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UpdateRecord";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(658, 248);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DeleteRecord";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(786, 713);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "SaveRecord";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Indigo;
            btnFilter.ForeColor = Color.WhiteSmoke;
            btnFilter.Location = new Point(250, 704);
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
            btnRefresh.Location = new Point(797, 248);
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
            btnNext.Location = new Point(762, 665);
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
            btnPrevious.Location = new Point(658, 667);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(98, 31);
            btnPrevious.TabIndex = 10;
            btnPrevious.Text = "PreviousPage";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // employeeFilterControl1
            // 
            employeeFilterControl1.Location = new Point(91, 12);
            employeeFilterControl1.Name = "employeeFilterControl1";
            employeeFilterControl1.Size = new Size(856, 213);
            employeeFilterControl1.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 800);
            Controls.Add(employeeFilterControl1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvEmployees);
            Controls.Add(Label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private DataGridView dgvEmployees;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnFilter;
        private Button btnRefresh;
        private Button btnNext;
        private Button btnPrevious;
        private EmployeeFilterControl employeeFilterControl1;
    }
}