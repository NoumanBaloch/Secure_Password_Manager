using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FYP.App_Code.PasswordManager
{
    public partial class GeneratePassword : Form
    {
        #region Cosntrucotrs
        public GeneratePassword(string userName) 
        {
            InitializeComponent();
            lbluser.Text = userName;
        }

        public GeneratePassword()
        {
            InitializeComponent();
        }
#endregion
        #region Password generator
        //Generate random password based on length
        public static string RandomPasswordGenerator(int stringLength)
        {
            start:
            var finalString = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@%+!#$^?:.(){}[]~";
            var stringChars = new char[stringLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new string(stringChars);
            if (finalString.Any(ch => !Char.IsLetterOrDigit(ch)))
            {

                return finalString = new String(stringChars);
            }
            else
            {
                goto start;
            }


        }

        //Generate random password wihtout special characters
        public static string RandomPasswordGeneratorWithoutSpecialCharacters(int stringLength)
        {
            var finalString = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[stringLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return finalString = new string(stringChars);

        }
        #endregion
        #region Getting user input for password generator
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string finalString = "";
            #region 8 Characters string generator
            if (eightDigit.Checked && uperCase.Checked && specialYes.Checked) 
            {
                finalString = "";
                finalString = RandomPasswordGenerator(8);
                txtPassword.Text = finalString.ToUpper();
            }
            else if (eightDigit.Checked && lowerCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(8);
                txtPassword.Text = finalString.ToLower();
            }
            else if (eightDigit.Checked && mixCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(8);
                txtPassword.Text = finalString;
            }
            else if (eightDigit.Checked && uperCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(8);
                txtPassword.Text = finalString.ToUpper();
            }
            else if (eightDigit.Checked && lowerCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(8);
                txtPassword.Text = finalString.ToLower();
            }
            else if (eightDigit.Checked && mixCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(8);
                txtPassword.Text = finalString;
            }
            #endregion
            #region 12 Characters string generator
            if (twelveDigit.Checked && uperCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(12);
                txtPassword.Text = finalString.ToUpper();
            }
            else if (twelveDigit.Checked && lowerCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(12);
                txtPassword.Text = finalString.ToLower();
            }
            else if (twelveDigit.Checked && mixCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(12);
                txtPassword.Text = finalString;
            }
            else if (twelveDigit.Checked && uperCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(12);
                txtPassword.Text = finalString.ToUpper();
            }
            else if (twelveDigit.Checked && lowerCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(12);
                txtPassword.Text = finalString.ToLower();
            }
            else if (twelveDigit.Checked && mixCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(12);
                txtPassword.Text = finalString;
            }
            #endregion
            #region 16 Characters string
            if (sixteenDigit.Checked && uperCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(16);
                txtPassword.Text = finalString.ToUpper();
            }
            else if (sixteenDigit.Checked && lowerCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(16);
                txtPassword.Text = finalString.ToLower();
            }
            else if (sixteenDigit.Checked && mixCase.Checked && specialYes.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGenerator(16);
                txtPassword.Text = finalString;
            }
            else if (sixteenDigit.Checked && uperCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(16);
                txtPassword.Text = finalString.ToUpper();
            }
            else if (sixteenDigit.Checked && lowerCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(16);
                txtPassword.Text = finalString.ToLower();
            }
            else if (sixteenDigit.Checked && mixCase.Checked && specialNo.Checked)
            {
                finalString = "";
                finalString = RandomPasswordGeneratorWithoutSpecialCharacters(16);
                txtPassword.Text = finalString;
            }
            #endregion
            #region Error Conditions
            if (!eightDigit.Checked && !twelveDigit.Checked && !sixteenDigit.Checked)
            {
                MessageBox.Show("Select the password length");
            }
            if (!uperCase.Checked && !lowerCase.Checked && !mixCase.Checked)
            {
                MessageBox.Show("Select the case for your password");
            }
            if (!specialYes.Checked && !specialNo.Checked)
            {
                MessageBox.Show("Do you want to include special characters!");
            }

        }
#endregion
        #endregion
        #region Copy to clipboard
        private void CopyToClip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
            MessageBox.Show("Password is Copied to Clipboard.");
            DialogResult dialogResult = MessageBox.Show("Do You Want to Use this Password", "Choice", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                new AddPassword(lbluser.Text, txtPassword.Text).Show();
            }
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
