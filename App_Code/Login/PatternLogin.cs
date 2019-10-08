using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP.App_Code.PasswordManager;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code
{
    public partial class PatternLogin : Form
    {
        public PatternLogin(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }
        #region Selecting the color
       
        private void RedColor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "*******";
            item.Tag = "#FF0000";
            listView.Items.Add(item);
        }
        private void GreenColor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "*******";
            item.Tag = "#008000";
            listView.Items.Add(item);
        }
        private void BlueColor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "*******";
            item.Tag = "#0000FF";
            listView.Items.Add(item);
        }
        #endregion

        #region Verifying user data
        int count = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count <= 0)
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                if (count < 2)
                {
                    List<string> lst = new List<string>();
                    clsPatternDB patternObj = new clsPatternDB();
                    string userPattern = "";
                    foreach (ListViewItem item in listView.Items)
                    {
                        lst.Add(item.Tag.ToString());
                        userPattern += item.Tag;
                    }
                    patternObj.FKUsername = (label1.Text).ToString();
                    patternObj.Pattern = userPattern.ToString();
                    MessageBox.Show(userPattern);
                    patternObj.Pattern = (userPattern);
                    bool Result = clsUserLogin.UserPatternValidation(patternObj);
                    if (Result)
                    {
                        this.Hide();
                        new Home(label1.Text).Show();

                    }
                    else
                    {
                        count++;
                        if (count == 1)
                        {

                            MessageBox.Show("2 Attemps Remain");
                            listView.Items.Clear();
                        }
                        else if (count == 2)
                        {
                            MessageBox.Show("1 Attemps Remain");
                            listView.Items.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your 3 Attempts Are Completed.");
                    new UserLogin().Show();
                    this.Hide();
                }
                }
            }
        #endregion

        #region Reset the value of list
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.Items.Clear();
            }
            else
            {
                MessageBox.Show("List is Empty");
            }
        }
        #endregion

        #region Redirecting to other pages
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserRegistration().Show();
        }
        #endregion

        #region Styles of form
        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.Transparent;
            btnSubmit.BackColor = Color.CornflowerBlue;
         }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.CornflowerBlue;
            btnSubmit.BackColor = Color.Transparent;
        }
        #endregion
    }
}