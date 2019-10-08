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
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code.PasswordManager
{
    public partial class DeleteProfile : Form
    {
        #region Constructors
        public DeleteProfile()
        {
            InitializeComponent();
        }
        public DeleteProfile(string userName) 
        {
            InitializeComponent();
            lbluser.Text = userName;

        }
        #endregion

        #region Deleting profile
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) == false)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Delete Account", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    clsUserDB userObj = new clsUserDB();
                    clsPasswordManagerDB pasObj = new clsPasswordManagerDB();
                    userObj.Username = Convert.ToString(lbluser.Text);
                    int salt = clsUserLogin.FetchingSalt(userObj);
                    string passwordHash = HashGenerator(salt);
                    userObj.Password = passwordHash;
                    pasObj.FKUsername = Convert.ToString(lbluser.Text);
                    bool result = clsUserLogin.UsernameValidationForLogin(userObj);
                    if (result == false)
                    {
                        MessageBox.Show("Password Doesn't Match");
                    }
                    else
                    {
                        clsAccountSetting.DeleteAccount(userObj, pasObj);
                        MessageBox.Show("Successfull Deleted");
                        this.Hide();
                        new MainPage().Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Password Field is Missing");
            }
        }
        #endregion

        #region Hash generator
        public string HashGenerator(int salt)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            return BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(salt + txtPassword.Text)));
        }
        #endregion

        #region Redirecting to other pages
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
