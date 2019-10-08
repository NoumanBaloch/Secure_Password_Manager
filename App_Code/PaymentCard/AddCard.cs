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
    public partial class AddCard : Form
    {
        #region Constructors
        public AddCard(string userName, int ID, string NameonCard, string Type, string Number, string SecurityCode, string StartDate, string ExpirationDate, string Note)
        {
            InitializeComponent();
            lbluser.Text = userName;
            lblID.Text = Convert.ToString(ID);
            txtNameOnCard.Text = NameonCard;
            txtType.Text = Type;
            txtNumber.Text = Number;
            txtSecurityCode.Text = SecurityCode;
            dtpStartDate.Text = StartDate;
            dtpExpirationDate.Text = ExpirationDate;
            txtNote.Text = Note;
            btnAddPaymentCard.Text = "Update Card";


        }
       
        public AddCard(string userName)
        {
            InitializeComponent();
            lbluser.Text = userName;
        }

        public AddCard()
        {
            InitializeComponent();


        }
        #endregion

        #region Submiting data to server
        //Submit the Data to database
        private void btnAddPaymentCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblID.Text) == true)
            {
                //Add Payment Account
                if (string.IsNullOrWhiteSpace(txtNameOnCard.Text) == false && string.IsNullOrWhiteSpace(txtType.Text) == false && string.IsNullOrWhiteSpace(txtNumber.Text) == false && string.IsNullOrWhiteSpace(txtSecurityCode.Text) == false )
                {
                    clsPaymentCardDB paymentCardObj = new clsPaymentCardDB();
                    paymentCardObj.NameOnCard = (txtNameOnCard.Text).ToString();
                    paymentCardObj.Type = (txtType.Text).ToString();
                    paymentCardObj.Number = (txtNumber.Text).ToString();
                    paymentCardObj.SecurityCode = (txtSecurityCode.Text).ToString();
                    paymentCardObj.StartDate = Convert.ToDateTime(dtpStartDate.Value.Date);
                    paymentCardObj.ExpirationDate = Convert.ToDateTime(dtpExpirationDate.Value.Date);
                    paymentCardObj.Note = (txtNote.Text).ToString();
                    paymentCardObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulatePaymentCard paymentObj = new clsManipulatePaymentCard();
                    paymentObj.AddCard(paymentCardObj);
                    MessageBox.Show("Inserted");
                    this.Hide();
                    new ShowCard(lbluser.Text).Show();
                }
                else
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
            
            //Update Card
            else
            {
                if (string.IsNullOrWhiteSpace(txtNameOnCard.Text) == false && string.IsNullOrWhiteSpace(txtType.Text) == false && string.IsNullOrWhiteSpace(txtNumber.Text) == false && string.IsNullOrWhiteSpace(txtSecurityCode.Text) == false)
                {
                    clsPaymentCardDB paymentCardObj = new clsPaymentCardDB();
                    paymentCardObj.CardID = Convert.ToInt32(lblID.Text);
                    paymentCardObj.NameOnCard = (txtNameOnCard.Text).ToString();
                    paymentCardObj.Type = (txtType.Text).ToString();
                    paymentCardObj.Number = (txtNumber.Text).ToString();
                    paymentCardObj.SecurityCode = (txtSecurityCode.Text).ToString();
                    paymentCardObj.StartDate = Convert.ToDateTime(dtpStartDate.Value.Date);
                    paymentCardObj.ExpirationDate = Convert.ToDateTime(dtpExpirationDate.Value.Date);
                    paymentCardObj.Note = (txtNote.Text).ToString();
                    paymentCardObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulatePaymentCard cardObj = new clsManipulatePaymentCard();
                    int output = cardObj.UpdateCard(paymentCardObj);
                    if (output == 1)
                    {
                        MessageBox.Show("Card Updated");
                        this.Hide();
                        new ShowCard(lbluser.Text).Show();
                    }
                    else
                    {
                        MessageBox.Show("Record is Note Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
        }
        #endregion

        #region Redirecting to othe page
        //Redirect to other pages
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

        #endregion
    }
}
