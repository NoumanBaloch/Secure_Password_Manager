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
    public partial class AddBank : Form
    {
        #region Constructor
        public AddBank(string userName, int ID, string BankName, string AccountType, string RoutingNumber, string AccountNumber, string SWIFTCode, string IBANNumber, string Pin, string BranchAddress, string BranchPhone, string Note) 
        {
            InitializeComponent();
            lbluser.Text = userName;
            lblID.Text = Convert.ToString(ID);
            txtBankName.Text = BankName;
            txtAccountType.Text = AccountType;
            txtRoutingNumber.Text = RoutingNumber;
            txtAccountNumber.Text = AccountNumber;
            txtSwiftCode.Text = SWIFTCode;
            txtIBANNumber.Text = IBANNumber;
            txtPin.Text = Pin;
            txtBranchAddress.Text = BranchAddress;
            txtBranchPhone.Text = BranchPhone;
            txtNote.Text = Note;
            btnAddBank.Text = "Update Account";
            
            
        }
        public AddBank(string userName)
        {
            InitializeComponent();
            lbluser.Text = userName;
        }

        public AddBank() 
        {
            InitializeComponent();
        }

        #endregion

        #region Submiting data to server
        //Submit the Data to database
        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblID.Text) == true)
            {
                //Add Bank Account
                if (string.IsNullOrWhiteSpace(txtBankName.Text) == false && string.IsNullOrWhiteSpace(txtAccountType.Text) == false && string.IsNullOrWhiteSpace(txtRoutingNumber.Text) == false && string.IsNullOrWhiteSpace(txtAccountNumber.Text) == false && string.IsNullOrWhiteSpace(txtSwiftCode.Text) == false && string.IsNullOrWhiteSpace(txtIBANNumber.Text) == false && string.IsNullOrWhiteSpace(txtPin.Text) == false && string.IsNullOrWhiteSpace(txtBranchAddress.Text) == false && string.IsNullOrWhiteSpace(txtBranchPhone.Text) == false)
                {
                    clsBankAccountsDB bankAccountObj = new clsBankAccountsDB();
                    bankAccountObj.BankName = (txtBankName.Text).ToString();
                    bankAccountObj.AccountType = (txtAccountType.Text).ToString();
                    bankAccountObj.RoutingNumber = (txtRoutingNumber.Text).ToString();
                    bankAccountObj.AccountNumber = (txtAccountNumber.Text).ToString();
                    bankAccountObj.SWIFTCode = (txtSwiftCode.Text).ToString();
                    bankAccountObj.IBANNumber = (txtIBANNumber.Text).ToString();
                    bankAccountObj.Pin = (txtPin.Text).ToString();
                    bankAccountObj.BranchAddress = (txtBranchAddress.Text).ToString();
                    bankAccountObj.BranchPhone = (txtBranchPhone.Text).ToString();
                    bankAccountObj.Note = (txtNote.Text).ToString();
                    bankAccountObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulateBankAccount bankObj = new clsManipulateBankAccount();
                    bankObj.AddBank(bankAccountObj);
                    MessageBox.Show("Inserted");
                    this.Hide();
                    new ShowBank(lbluser.Text).Show();
                }
                else
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
                //Update Bank Account
            else {
                if (string.IsNullOrWhiteSpace(txtBankName.Text) == false && string.IsNullOrWhiteSpace(txtAccountType.Text) == false && string.IsNullOrWhiteSpace(txtRoutingNumber.Text) == false && string.IsNullOrWhiteSpace(txtAccountNumber.Text) == false && string.IsNullOrWhiteSpace(txtSwiftCode.Text) == false && string.IsNullOrWhiteSpace(txtIBANNumber.Text) == false && string.IsNullOrWhiteSpace(txtPin.Text) == false && string.IsNullOrWhiteSpace(txtBranchAddress.Text) == false && string.IsNullOrWhiteSpace(txtBranchPhone.Text) == false)
                {
                    clsBankAccountsDB bankAccountObj = new clsBankAccountsDB();
                    bankAccountObj.BankID = Convert.ToInt32(lblID.Text);
                    bankAccountObj.BankName = (txtBankName.Text).ToString();
                    bankAccountObj.AccountType = (txtAccountType.Text).ToString();
                    bankAccountObj.RoutingNumber = (txtRoutingNumber.Text).ToString();
                    bankAccountObj.AccountNumber = (txtAccountNumber.Text).ToString();
                    bankAccountObj.SWIFTCode = (txtSwiftCode.Text).ToString();
                    bankAccountObj.IBANNumber = (txtIBANNumber.Text).ToString();
                    bankAccountObj.Pin = (txtPin.Text).ToString();
                    bankAccountObj.BranchAddress = (txtBranchAddress.Text).ToString();
                    bankAccountObj.BranchPhone = (txtBranchPhone.Text).ToString();
                    bankAccountObj.Note = (txtNote.Text).ToString();
                    bankAccountObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulateBankAccount bankObj = new clsManipulateBankAccount();
                    int output = bankObj.UpdateBank(bankAccountObj);
                    if (output == 1)
                    {
                        MessageBox.Show("Account Updated");
                        this.Hide();
                        new ShowBank(lbluser.Text).Show();
                    }
                    else {
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

        #region Redirecting to other pages
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
