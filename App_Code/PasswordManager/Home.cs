using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP.App_Code.BankAccount;
using FYP.App_Code.PaymentCard;
using FYP.App_Code.Addresses;

namespace FYP.App_Code.PasswordManager
{
    public partial class Home : Form
    {
        #region Constructors
        public Home(string userName) 
        {
            InitializeComponent();
            lbluser.Text = userName;
        }
        public Home()
        {
            InitializeComponent();
        }
        #endregion

        #region Redirecting to other pages
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowPassword(lbluser.Text).Show();
        }
        private void btnBankAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowBank(lbluser.Text).Show();
        }

        private void btnPaymentCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowCard(lbluser.Text).Show();
        }
        private void btnAddress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShowAddress(lbluser.Text).Show();
        }
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GeneratePassword(lbluser.Text).Show();
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountSettings(lbluser.Text).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainPage().Show();
        }
        #endregion

        
    }
}
