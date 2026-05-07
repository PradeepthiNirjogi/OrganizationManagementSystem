namespace OrganizationManagementSystem.Forms
{
    partial class HamburgerMenuControl
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
            pnlMenu = new Panel();
            btnFilterMenu = new Button();
            btnDeleteMenu = new Button();
            btnUpdateMenu = new Button();
            bthAddMenu = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ActiveCaption;
            pnlMenu.Controls.Add(btnFilterMenu);
            pnlMenu.Controls.Add(btnDeleteMenu);
            pnlMenu.Controls.Add(btnUpdateMenu);
            pnlMenu.Controls.Add(bthAddMenu);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(843, 447);
            pnlMenu.TabIndex = 4;
            // 
            // btnFilterMenu
            // 
            btnFilterMenu.FlatAppearance.BorderSize = 0;
            btnFilterMenu.FlatStyle = FlatStyle.Flat;
            btnFilterMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterMenu.Image = Properties.Resources.Filter;
            btnFilterMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilterMenu.Location = new Point(0, 248);
            btnFilterMenu.Margin = new Padding(0, 5, 0, 5);
            btnFilterMenu.Name = "btnFilterMenu";
            btnFilterMenu.Padding = new Padding(12, 0, 0, 0);
            btnFilterMenu.Size = new Size(843, 40);
            btnFilterMenu.TabIndex = 3;
            btnFilterMenu.Text = "Search Employee";
            btnFilterMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnFilterMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFilterMenu.UseVisualStyleBackColor = true;
            btnFilterMenu.Click += btnFilterMenu_Click;
            // 
            // btnDeleteMenu
            // 
            btnDeleteMenu.FlatAppearance.BorderSize = 0;
            btnDeleteMenu.FlatStyle = FlatStyle.Flat;
            btnDeleteMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteMenu.ForeColor = Color.Black;
            btnDeleteMenu.Image = Properties.Resources.Delete;
            btnDeleteMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteMenu.Location = new Point(0, 174);
            btnDeleteMenu.Margin = new Padding(0, 5, 0, 5);
            btnDeleteMenu.Name = "btnDeleteMenu";
            btnDeleteMenu.Padding = new Padding(12, 0, 0, 0);
            btnDeleteMenu.Size = new Size(843, 40);
            btnDeleteMenu.TabIndex = 2;
            btnDeleteMenu.Text = "Delete Employee";
            btnDeleteMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteMenu.UseVisualStyleBackColor = true;
            btnDeleteMenu.Click += btnDeleteMenu_Click;
            // 
            // btnUpdateMenu
            // 
            btnUpdateMenu.FlatAppearance.BorderSize = 0;
            btnUpdateMenu.FlatStyle = FlatStyle.Flat;
            btnUpdateMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateMenu.ForeColor = Color.Black;
            btnUpdateMenu.Image = Properties.Resources.Update;
            btnUpdateMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateMenu.Location = new Point(0, 84);
            btnUpdateMenu.Margin = new Padding(0, 5, 0, 5);
            btnUpdateMenu.Name = "btnUpdateMenu";
            btnUpdateMenu.Padding = new Padding(12, 0, 0, 0);
            btnUpdateMenu.Size = new Size(843, 45);
            btnUpdateMenu.TabIndex = 1;
            btnUpdateMenu.Text = "Update Employee";
            btnUpdateMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateMenu.UseVisualStyleBackColor = true;
            btnUpdateMenu.Click += btnUpdateMenu_Click;
            // 
            // bthAddMenu
            // 
            bthAddMenu.FlatAppearance.BorderSize = 0;
            bthAddMenu.FlatStyle = FlatStyle.Flat;
            bthAddMenu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bthAddMenu.ForeColor = Color.Black;
            bthAddMenu.Image = Properties.Resources.Add;
            bthAddMenu.ImageAlign = ContentAlignment.MiddleLeft;
            bthAddMenu.Location = new Point(0, 0);
            bthAddMenu.Margin = new Padding(0, 5, 0, 5);
            bthAddMenu.Name = "bthAddMenu";
            bthAddMenu.Padding = new Padding(12, 0, 0, 0);
            bthAddMenu.Size = new Size(843, 45);
            bthAddMenu.TabIndex = 0;
            bthAddMenu.Text = "Add Employee";
            bthAddMenu.TextAlign = ContentAlignment.MiddleLeft;
            bthAddMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            bthAddMenu.UseVisualStyleBackColor = true;
            bthAddMenu.Click += bthAddMenu_Click;
            // 
            // HamburgerMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMenu);
            Name = "HamburgerMenuControl";
            Size = new Size(843, 447);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Button btnDeleteMenu;
        private Button btnUpdateMenu;
        private Button bthAddMenu;
        private Button btnFilterMenu;
    }
}
