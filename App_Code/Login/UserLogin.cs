using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        #region Selecting click points
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (prgImage.Image != null)
            {
                lblClickPointXAxis.Text = (e.X).ToString();
                lblClickPointYAxis.Text = (e.Y).ToString();
            }
            else
            {
                MessageBox.Show("Select the image");
            }
        }
        #endregion

        #region Verifying data from database
        private void btnVerify_Click(object sender, EventArgs e)
        {
            clsUserDB userObj = new clsUserDB();
            userObj.Username = (txtUsername.Text).ToString();
            int salt = clsUserLogin.FetchingSalt(userObj);
            string passwordHash = HashGenerator(salt);
            userObj.Username = (txtUsername.Text).ToString();
            userObj.Password = passwordHash;
            bool Result = clsUserLogin.UsernameValidationForLogin(userObj);
            if (Result)
            {
                SqlConnection con = new SqlConnection(Variables.ConStr);
                string Username = txtUsername.Text;
                SqlCommand cmd = new SqlCommand("usp_FetchingImage", con);
                cmd.Parameters.Add("@FKUsername", SqlDbType.VarChar, 100).Value = Username;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Picture"]);
                        prgImage.Image = new Bitmap(ms);
                        prgImage.SizeMode = PictureBoxSizeMode.StretchImage;

                        txtUsername.Enabled = false;
                        btnVerify.Text = "Verified";
                        btnVerify.Enabled = false;
                    }
                  
                }
                catch (Exception x)
                {
                    throw new Exception("Error Occured: " + x.Message);
                }
            }
            else if (txtUsername.Text == string.Empty && txtPassword.Text == string.Empty) 
            {
                MessageBox.Show("Enter your username and password");
            
            }
            else if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Enter your username");
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter your password");
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
        #endregion

        #region Redirection to next
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (prgImage.Image != null && lblClickPointXAxis.Text != string.Empty && lblClickPointYAxis.Text != string.Empty && txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                clsUserDB userObj = new clsUserDB();
                userObj.ClickPointOnXAxis = Convert.ToInt32(lblClickPointXAxis.Text);
                userObj.ClickPointOnYAxis = Convert.ToInt32(lblClickPointYAxis.Text);
                bool Result = clsUserLogin.UserLoginValidation(userObj);
                if (Result)
                {
                    this.Hide();
                    new PatternLogin(txtUsername.Text).Show();
                }
                else
                {
                    MessageBox.Show("Click on the correct point on image");
                }
            }
            else if (txtUsername.Text == string.Empty && txtPassword.Text == string.Empty) 
            {
                MessageBox.Show("Enter your username and password");
            }
            else if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Enter your username");
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter your password");
            }
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserRegistration().Show();    
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

        #region Styles of form
        private void btnVerify_MouseHover(object sender, EventArgs e)
        {
            btnVerify.ForeColor = Color.Transparent;
            btnVerify.BackColor = Color.CornflowerBlue;
        }

        private void btnVerify_MouseLeave(object sender, EventArgs e)
        {
            btnVerify.ForeColor = Color.CornflowerBlue;
            btnVerify.BackColor = Color.Transparent;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.Transparent;
            btnNext.BackColor = Color.CornflowerBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.CornflowerBlue;
            btnNext.BackColor = Color.Transparent;
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.Transparent;
            btnNext.BackColor = Color.CornflowerBlue;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.CornflowerBlue;
            btnNext.BackColor = Color.Transparent;
        }
        #endregion

        #region Password show and hide
        private void show_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void hide_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
    
