using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrganizationManagementSystem.Forms
{
    public partial class HamburgerMenuControl : UserControl
    {
        public HamburgerMenuControl()
        {
            InitializeComponent();
        }

        public event EventHandler? AddClicked;
        public event EventHandler? UpdateClicked;
        public event EventHandler? DeleteClicked;
        public event EventHandler? SearchClicked;

        //ADD
        private void bthAddMenu_Click(object sender, EventArgs e)
        {
            AddClicked?.Invoke(this, EventArgs.Empty);
        }

        // UPDATE
        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            UpdateClicked?.Invoke(this, EventArgs.Empty);
        }

        // DELETE
        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        // SEARCH
        private void btnFilterMenu_Click(object sender, EventArgs e)
        {
            SearchClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShowWithText()
        {
            bthAddMenu.Text = "Add Employee";
            btnUpdateMenu.Text = "Update Employee";
            btnDeleteMenu.Text = "Delete Employee";
            btnFilterMenu.Text = "Search Employee";

            bthAddMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnFilterMenu.TextAlign = ContentAlignment.MiddleLeft;
        }

        public void ShowIconsOnly()
        {
            bthAddMenu.Text = "";
            btnUpdateMenu.Text = "";
            btnDeleteMenu.Text = "";
            btnFilterMenu.Text = "";

            bthAddMenu.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateMenu.TextAlign = ContentAlignment.MiddleCenter;
            btnDeleteMenu.TextAlign = ContentAlignment.MiddleCenter;
            btnFilterMenu.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
