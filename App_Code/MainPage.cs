using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FYP.App_Code
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Redirect to registration page.
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserRegistration().Show();
        }
        //Redirect to Login Page
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserLogin().Show();   
        }
        //Styling of buttons.
        private void btnRegistration_MouseHover(object sender, EventArgs e)
        {
            btnRegisration.ForeColor = Color.Black;
            btnRegisration.BackColor = Color.CornflowerBlue;
            btnLogin.ForeColor = Color.CornflowerBlue;
            btnLogin.BackColor = Color.Black;
        }

        private void btnRegistration_MouseLeave(object sender, EventArgs e)
        {
            btnRegisration.ForeColor = Color.CornflowerBlue;
            btnRegisration.BackColor = Color.Black;
            btnLogin.ForeColor = Color.Black;
            btnLogin.BackColor = Color.CornflowerBlue;
        }
    }
}
