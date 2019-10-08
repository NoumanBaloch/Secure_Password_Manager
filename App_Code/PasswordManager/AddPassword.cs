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
    public partial class AddPassword : Form
    {
        #region Constructors
        public AddPassword(string userName, int ID, string URL, string Name, string Username, string Password, string Note) 
        {
            InitializeComponent();
            lbluser.Text = userName;
            lblID.Text = Convert.ToString(ID);
            txtUrl.Text = URL;
            txtName.Text = Name;
            txtUName.Text = Username;
            txtPassword.Text = Password;
            txtNote.Text = Note;
            btnAddPassword.Text = "Update Password";
        }
        public AddPassword(string userName, string generatedPassword)
        {
            InitializeComponent();
            lbluser.Text = userName;
            txtPassword.Text = generatedPassword;
        }
        public AddPassword(string userName)
        {
            InitializeComponent();
            lbluser.Text = userName;
        }

        public AddPassword() 
        {
            InitializeComponent();
        }
        #endregion

        #region Submiting data to server
        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            if (lblID.Text == string.Empty)
            {
                //Add password
                if (string.IsNullOrWhiteSpace(txtUrl.Text) == false && string.IsNullOrWhiteSpace(txtName.Text) == false && string.IsNullOrWhiteSpace(txtUName.Text) == false && string.IsNullOrWhiteSpace(txtPassword.Text) == false)
                {
                    clsPasswordManagerDB passManageObj = new clsPasswordManagerDB();
                    passManageObj.URL = (txtUrl.Text).ToString();
                    passManageObj.Name = (txtName.Text).ToString();
                    passManageObj.Usernames = (txtUName.Text).ToString();
                    passManageObj.Passwords = (txtPassword.Text).ToString();
                    passManageObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulatePassword passObj = new clsManipulatePassword();
                    passObj.AddPassword(passManageObj);
                    MessageBox.Show("Inserted");
                    this.Hide();
                    new ShowPassword(lbluser.Text).Show();
                }
                else
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
            else {
                if (string.IsNullOrWhiteSpace(txtUrl.Text) == false && string.IsNullOrWhiteSpace(txtName.Text) == false && string.IsNullOrWhiteSpace(txtUName.Text) == false && string.IsNullOrWhiteSpace(txtPassword.Text) == false)
                {
                    clsPasswordManagerDB passManageObj = new clsPasswordManagerDB();
                    passManageObj.ID = Convert.ToInt32(lblID.Text);
                    passManageObj.URL = (txtUrl.Text).ToString();
                    passManageObj.Name = (txtName.Text).ToString();
                    passManageObj.Usernames = (txtUName.Text).ToString();
                    passManageObj.Passwords = (txtPassword.Text).ToString();
                    passManageObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulatePassword passObj = new clsManipulatePassword();
                    int output = passObj.UpdatePassword(passManageObj);
                    if (output == 1)
                    {
                        MessageBox.Show("Password Updated");
                        this.Hide();
                        new ShowPassword(lbluser.Text).Show();
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

        #region Show and hide password
        private void Show_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void Hide_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion

        #region Redirecting to other pages
        private void btnGen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GeneratePassword(lbluser.Text).Show();
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
        #endregion
    }
}
