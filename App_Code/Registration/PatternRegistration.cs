using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP.App_Code.DomainClasses;

namespace FYP.App_Code
{
    public partial class PatternRegistration : Form
    {
        #region Constructors
        public PatternRegistration()
        {
            InitializeComponent();
        }
        public PatternRegistration(string Username, string passwordHash, int salt, string inputXAxis, string inputYAxis, Image userPicture )
        {
            InitializeComponent();
            lblUsername.Text = Username;
            lblPassword.Text = passwordHash;
            lblSalt.Text = Convert.ToString(salt);
            lblX.Text = inputXAxis;
            lblY.Text = inputYAxis;
            pictureBox1.Image = userPicture;
         }
#endregion

        #region selecting and submiting pattern
        
        private void redColor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "*******";
            item.Tag = "#FF0000";
            lvwListView.Items.Add(item);

           
        }
        private void greenColor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "*******";
            item.Tag = "#008000";
            lvwListView.Items.Add(item);
        }
        private void blueColor_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = "*******";
            item.Tag = "#0000FF";
            lvwListView.Items.Add(item);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(lvwListView.Items.Count <= 0)
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                List<string> lst = new List<string>();
                clsUserDB userObj = new clsUserDB();
                clsImageDB imageObj = new clsImageDB();
                clsPatternDB patternObj = new clsPatternDB();
                string userPattern = "";
                foreach (ListViewItem item in lvwListView.Items)
                {
                    lst.Add(item.Tag.ToString());
                    userPattern += item.Tag;
                }
                userObj.Username = (lblUsername.Text).ToString();
                userObj.Password = (lblPassword.Text).ToString();
                userObj.Salt = Convert.ToInt32(lblSalt.Text);
                userObj.ClickPointOnXAxis = Convert.ToInt32(lblX.Text);
                userObj.ClickPointOnYAxis = Convert.ToInt32(lblY.Text);
                ImageConverter converter = new ImageConverter();
                imageObj.Picture = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                imageObj.FKUsername = (lblUsername.Text).ToString();
                MessageBox.Show(userPattern);
                patternObj.Pattern = (userPattern).ToString();
                patternObj.FKUsername = (lblUsername.Text).ToString();
                clsUserRegistration.RegisterUser(userObj, imageObj, patternObj);
                MessageBox.Show("You are successfully registered");
                this.Hide();
                new UserLogin().Show();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lvwListView.Items.Count > 0)
            {
                lvwListView.Items.Clear();
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
        private void btnRegistration_Click(object sender, EventArgs e)
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