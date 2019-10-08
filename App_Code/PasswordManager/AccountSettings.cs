using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using FYP.App_Code.DBContext;

namespace FYP.App_Code.PasswordManager
{
    public partial class AccountSettings : Form
    {
        #region Constructors
        public AccountSettings(string userName) 
        {
            InitializeComponent();
            lbluser.Text = userName;
        }

        public AccountSettings()
        {
            InitializeComponent();
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
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteProfile(lbluser.Text).Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword(lbluser.Text).Show();
        }
        #endregion
    }
}
