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

namespace FYP.App_Code.PaymentCard
{
    public partial class ShowCard : Form
    {
        #region Constructors
        public ShowCard(string Username)
        {
            InitializeComponent();
            lbluser.Text = Username;
            GridView();
        }

        public ShowCard()
        {
            InitializeComponent();
        }
        #endregion

        #region Show the grid
        //Show gridview
        private void GridView()
        {
            clsPaymentCardDB cardObj = new clsPaymentCardDB();
            cardObj.FKUsername = lbluser.Text;
            List<clsPaymentCardDB> lst = clsManipulatePaymentCard.ShowCard(cardObj);
            

            gv.AutoGenerateColumns = false;
            gv.Columns.Clear();
            gv.ReadOnly = true;

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "CardID";
            c.HeaderText = "CardID";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "NameonCard";
            c.HeaderText = "Name on Card";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Type";
            c.HeaderText = "Type";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "Number";
            c.HeaderText = "Number";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "SecurityCode";
            c.HeaderText = "Security Code";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "StartDate";
            c.HeaderText = "Start Date";
            gv.Columns.Add(c);

            c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = "ExpirationDate";
            c.HeaderText = "Expiration Date";
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

        #region Deleting and updating data
        private void gv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ID = 0;
            var current = gv.CurrentRow;
            if (e.ColumnIndex == gv.Columns.Count - 1 && current != null)
            {

                ID = Convert.ToInt32(gv.Rows[e.RowIndex].Cells[0].Value);

                int result = clsManipulatePaymentCard.DeleteCard(ID);

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
                string NameOnCard = Convert.ToString(gv.Rows[e.RowIndex].Cells[1].Value);
                string Type = Convert.ToString(gv.Rows[e.RowIndex].Cells[2].Value);
                string Number = Convert.ToString(gv.Rows[e.RowIndex].Cells[3].Value);
                string SecurityCode = Convert.ToString(gv.Rows[e.RowIndex].Cells[4].Value);
                string StartDate = Convert.ToString(gv.Rows[e.RowIndex].Cells[5].Value);
                string ExpirationDate = Convert.ToString(gv.Rows[e.RowIndex].Cells[6].Value);
                string Note = Convert.ToString(gv.Rows[e.RowIndex].Cells[7].Value);

                this.Hide();
                new AddCard(lbluser.Text, ID, NameOnCard, Type, Number, SecurityCode, StartDate, ExpirationDate, Note).Show();
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

        private void btnAddCard_Click(object sender, EventArgs e)
        {

            this.Hide();
            new AddCard(lbluser.Text).Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }

        #endregion

    }
}
