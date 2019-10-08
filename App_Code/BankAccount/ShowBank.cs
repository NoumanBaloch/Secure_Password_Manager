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
using FYP.App_Code.PasswordManager;

namespace FYP.App_Code.BankAccount
{
    public partial class ShowBank : Form
    {
        #region Constructors
        public ShowBank(string Username)
        {
            InitializeComponent();
            lbluser.Text = Username;
            GridView();
        }

        public ShowBank()
        {
            InitializeComponent();
        }
        #endregion

        #region Show the grid
        //Show gridview
        private void GridView()
        {
            clsBankAccountsDB bankObj = new clsBankAccountsDB();
            bankObj.FKUsername = lbluser.Text;
            List<clsBankAccountsDB> lst = clsManipulateBankAccount.ShowBank(bankObj);

            gv.AutoGenerateColumns = false;
            gv.Columns.Clear();
            gv.ReadOnly = true;

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "BankID";
            c.HeaderText = "BankID";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "BankName";
            c.HeaderText = "Bank Name";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "AccountType";
            c.HeaderText = "Account Type";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "RoutingNumber";
            c.HeaderText = "Routing Number";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "AccountNumber";
            c.HeaderText = "Account Number";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "SWIFTCode";
            c.HeaderText = "SWIFT Code";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "IBANNumber";
            c.HeaderText = "IBANNumber";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Pin";
            c.HeaderText = "Pin";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "BranchAddress";
            c.HeaderText = "Branch Address";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "BranchPhone";
            c.HeaderText = "Branch Phone";
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

        #region Deleting and update data
        //Delete and Update Bank Accounts
        private void gv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ID = 0;
            var current = gv.CurrentRow;
            if (e.ColumnIndex == gv.Columns.Count - 1 && current != null)
            {

                ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells[0].Value);

                int result = clsManipulateBankAccount.DeleteBank(ID);

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
                string BankName = Convert.ToString(gv.Rows[e.RowIndex].Cells[1].Value);
                string AccountType = Convert.ToString(gv.Rows[e.RowIndex].Cells[2].Value);
                string RoutingNumber = Convert.ToString(gv.Rows[e.RowIndex].Cells[3].Value);
                string AccountNumber = Convert.ToString(gv.Rows[e.RowIndex].Cells[4].Value);
                string SWIFTCode = Convert.ToString(gv.Rows[e.RowIndex].Cells[5].Value);
                string IBANNumber = Convert.ToString(gv.Rows[e.RowIndex].Cells[6].Value);
                string Pin = Convert.ToString(gv.Rows[e.RowIndex].Cells[7].Value);
                string BranchAddress = Convert.ToString(gv.Rows[e.RowIndex].Cells[8].Value);
                string BranchPhone = Convert.ToString(gv.Rows[e.RowIndex].Cells[9].Value);
                string Note = Convert.ToString(gv.Rows[e.RowIndex].Cells[10].Value);
                this.Hide();
                new AddBank(lbluser.Text, ID, BankName, AccountType, RoutingNumber, AccountNumber, SWIFTCode, IBANNumber, Pin, BranchAddress, BranchPhone, Note).Show();
            }
        }
        #endregion

        #region Styles of form
        //*Styling of buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home(lbluser.Text).Show();
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddBank(lbluser.Text).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }

        #endregion
    }
}
