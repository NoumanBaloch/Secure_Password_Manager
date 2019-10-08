using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP.App_Code.DBContext;
using System.Data.SqlClient;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code.PasswordManager
{
    public partial class ShowPassword : Form
    {
        #region Constructors
        public ShowPassword(string Username)
        {
            InitializeComponent();
            lbluser.Text = Username;
            GridView();
        }

        public ShowPassword()
        {
            InitializeComponent();
        }
        #endregion

        #region Show the grid
        private void GridView()
        {
            clsPasswordManagerDB passObj = new clsPasswordManagerDB();
            passObj.FKUsername = lbluser.Text;
            List<clsPasswordManagerDB> lst = clsManipulatePassword.ShowPassword(passObj);

            gv.AutoGenerateColumns = false;
            gv.Columns.Clear();
            gv.ReadOnly = true;

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "ID";
            c.HeaderText = "ID";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "URL";
            c.HeaderText = "URL";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Name";
            c.HeaderText = "Name";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Usernames";
            c.HeaderText = "Usernames";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Passwords";
            c.HeaderText = "Passwords";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Note";
            c.HeaderText = "Note";
            gv.Columns.Add(c);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.HeaderText = "Update";
            deleteBtn.Text = "Update";
            deleteBtn.UseColumnTextForButtonValue = true;
            gv.Columns.Add(deleteBtn);

            DataGridViewButtonColumn updateBtn = new DataGridViewButtonColumn();
            updateBtn.HeaderText = "Delete";
            updateBtn.Text = "Delete";
            updateBtn.UseColumnTextForButtonValue = true;
            gv.Columns.Add(updateBtn);

            gv.DataSource = lst;
        }
        #endregion

        #region Deleting and updating buttons
        private void gv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ID = 0;
            var current = gv.CurrentRow;
            if (e.ColumnIndex == gv.Columns.Count - 1 && current != null)
            {

                ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells[0].Value);

                int result = clsManipulatePassword.DeletePassword(ID);

                if (result == 1)
                {
                    MessageBox.Show("Record Deleted");
                    GridView();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted");
                }
            }
            if (e.ColumnIndex == gv.Columns.Count - 2 && current != null)
            {
                ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells[0].Value);
                string URL = Convert.ToString(gv.Rows[e.RowIndex].Cells[1].Value);
                string Name = Convert.ToString(gv.Rows[e.RowIndex].Cells[2].Value);
                string Username = Convert.ToString(gv.Rows[e.RowIndex].Cells[3].Value);
                string Password = Convert.ToString(gv.Rows[e.RowIndex].Cells[4].Value);
                string Note = Convert.ToString(gv.Rows[e.RowIndex].Cells[5].Value);
                this.Hide();
                new AddPassword(lbluser.Text, ID, URL, Name, Username, Password, Note).Show();
            }
        }
        #endregion

        #region Redirecting to other pages
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(lbluser.Text).Show();
        }

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPassword(lbluser.Text).Show();
        }
        #endregion
    }
}
