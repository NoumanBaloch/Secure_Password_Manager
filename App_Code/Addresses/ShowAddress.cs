using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP.App_Code.DomainClasses;
using FYP.App_Code.DBContext;
using FYP.App_Code.PasswordManager;

namespace FYP.App_Code.Addresses
{
    public partial class ShowAddress : Form
    {
        public ShowAddress(string userName)
        {
            InitializeComponent();
            lbluser.Text = userName;
            GridView();
        }
        public ShowAddress()
        {
            InitializeComponent();
            GridView();
        }
        //Show gridview
        private void GridView()
        {
            clsAddressDB addressObj = new clsAddressDB();
            addressObj.FKUsername = lbluser.Text;
            List<clsAddressDB> lst = clsManipulateAddress.ShowAddress(addressObj);

            gv.AutoGenerateColumns = false;
            gv.Columns.Clear();
            gv.ReadOnly = true;

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "AddressID";
            c.HeaderText = "AddressID";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Title";
            c.HeaderText = "Title";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "FirstName";
            c.HeaderText = "First Name";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "MiddleName";
            c.HeaderText = "Middle Name";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "LastName";
            c.HeaderText = "Last Name";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Username";
            c.HeaderText = "Username";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Gender";
            c.HeaderText = "Gender";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "BirthDay";
            c.HeaderText = "BirthDay";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Address";
            c.HeaderText = "Address";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Country";
            c.HeaderText = "Country";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "PhoneNo";
            c.HeaderText = "Phone No";
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

        private void gv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ID = 0;
            var current = gv.CurrentRow;
            if (e.ColumnIndex == gv.Columns.Count - 1 && current != null)
            {

                ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells[0].Value);

                int result = clsManipulateAddress.DeleteAddress(ID);

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
                string Title = Convert.ToString(gv.Rows[e.RowIndex].Cells[1].Value);
                string FirstName = Convert.ToString(gv.Rows[e.RowIndex].Cells[2].Value);
                string MiddleName = Convert.ToString(gv.Rows[e.RowIndex].Cells[3].Value);
                string LastName = Convert.ToString(gv.Rows[e.RowIndex].Cells[4].Value);
                string Username = Convert.ToString(gv.Rows[e.RowIndex].Cells[5].Value);
                string Gender = Convert.ToString(gv.Rows[e.RowIndex].Cells[6].Value);
                string BirthDay = Convert.ToString(gv.Rows[e.RowIndex].Cells[7].Value);
                string Address = Convert.ToString(gv.Rows[e.RowIndex].Cells[8].Value);
                string Country = Convert.ToString(gv.Rows[e.RowIndex].Cells[9].Value);
                string PhoneNo = Convert.ToString(gv.Rows[e.RowIndex].Cells[10].Value);
                string Note = Convert.ToString(gv.Rows[e.RowIndex].Cells[11].Value);
                this.Hide();
                new AddAddress(lbluser.Text, ID, Title, FirstName, MiddleName, LastName, Username, Gender, BirthDay, Address, Country, PhoneNo, Note).Show();
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAddress(lbluser.Text).Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(lbluser.Text).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }

       


    }
}
