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
    public partial class ChangePassword : Form
    {
        #region Constructors
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(string userName) 
        {
            InitializeComponent();
            lbluser.Text = userName;

        }
        #endregion

        #region Changing password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text) == false && string.IsNullOrWhiteSpace(txtNewPassword.Text) == false && string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text) == false && txtNewPassword.Text == txtConfirmNewPassword.Text && txtNewPassword.TextLength > 7) 
            {
                    clsUserDB userObj = new clsUserDB();
                    clsAccountSetting accountObj = new clsAccountSetting();
                    userObj.Username = Convert.ToString(lbluser.Text);
                    int salt = clsUserLogin.FetchingSalt(userObj);
                    string passwordHash = HashGenerator(salt);
                    userObj.Password = passwordHash;
                    bool result = clsUserLogin.UsernameValidationForLogin(userObj);
                    if (result)
                    {

                        string newPassword = HashGeneratorForNewPassowrd(salt);
                        userObj.Username = Convert.ToString(lbluser.Text);
                        userObj.Password = Convert.ToString(newPassword);
                        accountObj.ChangeingPassword(userObj);
                        MessageBox.Show("Password Changed Successfully");
                        this.Hide();
                        new MainPage().Show();
                    }
                    else
                    {
                        MessageBox.Show("Password does't match");
                    }
            }

            else if(txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password are not Same");
            }
            else if(txtNewPassword.TextLength <= 7)
            {
                MessageBox.Show("Password Length Must Be atleast 8 Characters.");
            }

        }
        #endregion

        #region Hash generator
        public string HashGenerator(int salt)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            return BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(salt + txtOldPassword.Text)));
        }
        public string HashGeneratorForNewPassowrd(int salt)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            return BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(salt + txtNewPassword.Text)));
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
