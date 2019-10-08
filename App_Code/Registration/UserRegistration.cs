using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code
{
    public partial class UserRegistration : Form
    {
        #region Constructor
        public UserRegistration()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
        }
        #endregion

        #region Username selection
        private void btnUserName_Click(object sender, EventArgs e)
        {
            clsUserDB clickObj = new clsUserDB();
            clickObj.Username = (txtUserName.Text).ToString();
            bool Result = clsUserRegistration.UserNameValidation(clickObj);
            if (string.IsNullOrWhiteSpace(txtUserName.Text) == true)
            {
                MessageBox.Show("Select a username");
             }
            else if (Result)
            {
                    MessageBox.Show("Sorry! Username already taken.");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Select this username", "Username Available", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    txtUserName.Enabled = false;
                    btnUserName.Text = "Selected";
                    btnUserName.Enabled = false;
                }
            }
        }
        #endregion

        #region Show and Hide password
        private void Show_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        private void Hide_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion

        #region Random password generator
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (rbEightDigits.Checked)
            {
                txtPassword.Text = RandomPasswordGenerator(8);
            }
            else if (rbTwelveDigits.Checked)
            {
                txtPassword.Text = RandomPasswordGenerator(12);
            }
            else if (rbSixtenDigits.Checked)
            {
                txtPassword.Text = RandomPasswordGenerator(16);
            }
            else
            {
                MessageBox.Show("Please Select the length for string.");
            }
        }
        public static string RandomPasswordGenerator(int stringLength)
        {
            var finalString = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@%+!#$^?:.(){}[]~";
            var stringChars = new char[stringLength];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return finalString = new String(stringChars);
        }
#endregion

        #region Browsing and selct click points from image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\";
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                         "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(dlg.FileName);
                Bitmap img = new Bitmap(dlg.FileName);
                if (img.Width > 800 && img.Height > 1200)
                {
                    string picLoc = dlg.FileName.ToString();
                    prgImage.ImageLocation = picLoc;
                    prgImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    prgImage.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    MessageBox.Show("Image dimension must be atleast 1200 X 800");
                }
                
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (prgImage.Image != null)
            {
                lblClickPointXAxis.Text = (e.X).ToString();
                lblClickPointYAxis.Text = (e.Y).ToString();
            }
            else {
                MessageBox.Show("Please First Select the Image");
            }
        }
        #endregion

        #region Verification process
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (txtUserName.Enabled != true && prgImage.Image != null && lblClickPointXAxis.Text != string.Empty && lblClickPointYAxis.Text != string.Empty && string.IsNullOrWhiteSpace(txtUserName.Text) == false && string.IsNullOrWhiteSpace(txtPassword.Text) == false && txtPassword.TextLength > 7)
            {
                clsUserDB clickObj = new clsUserDB();
                clickObj.Username = (txtUserName.Text).ToString();
                bool Result = clsUserRegistration.UserNameValidation(clickObj);
                if (Result)
                {
                    MessageBox.Show("Username already exist in database, chooose different name");
                }
                else
                {
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    byte[] randomNumber = new byte[10000000];
                    rng.GetBytes(randomNumber);
                    int salt = BitConverter.ToInt32(randomNumber, 0);
                    string passwordHash = HashGenerator(salt);
                    this.Hide();
                    new PatternRegistration(txtUserName.Text, passwordHash, salt, lblClickPointXAxis.Text, lblClickPointYAxis.Text, prgImage.Image).Show();
                }
            }
            else if (string.IsNullOrWhiteSpace(txtUserName.Text) == true)
            {
                MessageBox.Show("Select a username");
            }
            else if (txtUserName.Enabled != false)
            {
                MessageBox.Show("Check the availability of username");
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                MessageBox.Show("Choose a password");
            }
            if (txtPassword.TextLength <= 7)
            {
                MessageBox.Show("Your password Must Contain Atleast 8 Characters");
            }
            else if (prgImage.Image == null)
            {
                MessageBox.Show("Select the Image by click on browse button");
            }
            else if (lblClickPointXAxis.Text == string.Empty || lblClickPointYAxis.Text == string.Empty)
            {
                MessageBox.Show("Click on any point of image");
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

        #region Hash generator
        public string HashGenerator(int salt) 
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            return  BitConverter.ToString(sh.ComputeHash(utf8.GetBytes(salt + txtPassword.Text)));
        }
        #endregion

        #region Styles of form
        private void btnBrowse_MouseHover(object sender, EventArgs e)
        {
            btnBrowse.ForeColor = Color.Transparent;
            btnBrowse.BackColor = Color.DarkBlue;
        }
        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.ForeColor = Color.DarkBlue;
            btnBrowse.BackColor = Color.Transparent;
        }
        private void btnUpload_MouseHover(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.Transparent;
            btnNext.BackColor = Color.Green;
        }
        private void btnUpload_MouseLeave(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.Green;
            btnNext.BackColor = Color.Transparent;
        }
        private void btnusername_MouseHover(object sender, EventArgs e)
        {
            btnUserName.ForeColor = Color.Transparent;
            btnUserName.BackColor = Color.CornflowerBlue;
        }
        private void btnusername_MouseLeave(object sender, EventArgs e)
        {
            btnUserName.ForeColor = Color.CornflowerBlue;
            btnUserName.BackColor = Color.Transparent;
        }
        private void btnGenerate_MouseHover(object sender, EventArgs e)
        {
            btnGeneratePassword.ForeColor = Color.Transparent;
            btnGeneratePassword.BackColor = Color.CornflowerBlue;
        }
        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGeneratePassword.ForeColor = Color.CornflowerBlue;
            btnGeneratePassword.BackColor = Color.Transparent;
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.BackColor = Color.CornflowerBlue;
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.CornflowerBlue;
            btnLogin.BackColor = Color.Transparent;
        }
    }
#endregion
}

