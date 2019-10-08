using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP.App_Code.DomainClasses;
using FYP.App_Code.DBContext;
using FYP.App_Code.PasswordManager;
using System.IO;

namespace FYP.App_Code.Addresses
{
    public partial class AddAddress : Form
    {
        #region Constructor
        public AddAddress(string userName, int ID, string Title, string FirstName, string MiddleName, string LastName, string Username, string Gender, string BirthDay, string Address, string Country, string PhoneNo, string Note)
        {
            InitializeComponent();
            lbluser.Text = userName;
            lblID.Text = Convert.ToString(ID);
            drpTitle.Text = Title;
            txtFirstName.Text = FirstName;
            txtMiddleName.Text = MiddleName;
            txtLastName.Text = LastName;
            txtUsername.Text = Username;
            drpGender.Text = Gender;
            dtpBirthDay.Text = BirthDay;
            txtAddress.Text = Address;
            drpCountry.Text = Country;
            txtPhoneNo.Text = PhoneNo;
            txtNote.Text = Note;
            btnAddAddress.Text = "Update Address";


        }
        public AddAddress(string userName)
        {
            InitializeComponent();
            lbluser.Text = userName;
        }
        public AddAddress()
        {
            InitializeComponent();
        }

        #endregion

        #region DropDown Work
        private void AddAddress_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(lblID.Text))
            {
                Verifying();
            }
            else
            {
                LoadingDropDownListValues();
            }
            
           
        }
        private void drpCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void drpTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void drpGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void Verifying() 
        {
            string[] title = File.ReadAllLines(@"F:\FYP\FYP\Title.dsn");
            int titleCount = 0;
            for (int i = 0; i < title.Length; i++)
            {
                drpTitle.Items.Add(title[i]);
                if (drpTitle.Text == title[i])
                {
                    titleCount = i;
                }
            }
            if (titleCount > 0)
            {
                drpTitle.SelectedIndex = titleCount;
            }

            string[] countries = File.ReadAllLines(@"F:\FYP\FYP\countries.dsn");
            int countryCount = 0;
            for (int i = 0; i < countries.Length; i++)
            {
                drpCountry.Items.Add(countries[i]);
                if (drpCountry.Text == countries[i])
                {
                    countryCount = i;
                }
            }
            if (countryCount > 0)
            {
                drpCountry.SelectedIndex = countryCount;
            }

            string[] gender = File.ReadAllLines(@"F:\FYP\FYP\gender.dsn");
            int genderCount = 0;
            for (int i = 0; i < gender.Length; i++)
            {
                drpGender.Items.Add(gender[i]);
                if (drpGender.Text == gender[i])
                {
                    genderCount = i;
                }
            }
            if (genderCount > 0)
            {
                drpGender.SelectedIndex = genderCount;
            }

        }
        public void LoadingDropDownListValues()
        {
            string[] title = File.ReadAllLines(@"F:\FYP\FYP\Title.dsn");
            for (int i = 0; i < title.Length; i++)
            {

                drpTitle.Items.Add(title[i]);
            }
            if (drpTitle.Items.Count > 0)
            {
                drpTitle.SelectedIndex = 0;
            }

            string[] countries = File.ReadAllLines(@"F:\FYP\FYP\Countries.dsn");
            for (int i = 0; i < countries.Length; i++)
            {
                drpCountry.Items.Add(countries[i]);
            }
            if (drpCountry.Items.Count > 0)
            {
                drpCountry.SelectedIndex = 0;
            }

            string[] gender = File.ReadAllLines(@"F:\FYP\FYP\Gender.dsn");
            for (int i = 0; i < gender.Length; i++)
            {
                drpGender.Items.Add(gender[i]);
            }
            if (drpGender.Items.Count > 0)
            {
                drpGender.SelectedIndex = 0;
            }
        }
        #endregion

        #region Submiting data to server
        private void btnAddAddress_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblID.Text) == true)
            {
                //Add Address
                if (string.IsNullOrWhiteSpace(drpTitle.Text) == false && string.IsNullOrWhiteSpace(txtFirstName.Text) == false && string.IsNullOrWhiteSpace(txtMiddleName.Text) == false && string.IsNullOrWhiteSpace(txtLastName.Text) == false && string.IsNullOrWhiteSpace(txtUsername.Text) == false && string.IsNullOrWhiteSpace(drpGender.Text) == false && string.IsNullOrWhiteSpace(txtAddress.Text) == false && string.IsNullOrWhiteSpace(drpCountry.Text) == false && string.IsNullOrWhiteSpace(txtPhoneNo.Text) == false)
                {
                    clsAddressDB addressesObj = new clsAddressDB();
                    addressesObj.Title = (drpTitle.Text).ToString();
                    addressesObj.FirstName = (txtFirstName.Text).ToString();
                    addressesObj.MiddleName = (txtMiddleName.Text).ToString();
                    addressesObj.LastName = (txtLastName.Text).ToString();
                    addressesObj.Username = (txtUsername.Text).ToString();
                    addressesObj.Gender = (drpGender.Text).ToString();
                    addressesObj.BirthDay = Convert.ToDateTime(dtpBirthDay.Value.Date);
                    addressesObj.Address = (txtAddress.Text).ToString();
                    addressesObj.Country = (drpCountry.Text).ToString();
                    addressesObj.PhoneNo = (txtPhoneNo.Text).ToString();
                    addressesObj.Note = (txtNote.Text).ToString();
                    addressesObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulateAddress addressObj = new clsManipulateAddress();
                    addressObj.AddAddress(addressesObj);
                    MessageBox.Show("Inserted");
                    this.Hide();
                    new ShowAddress(lbluser.Text).Show();
                }
                else
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
            //Update Address
            else
            {
                if (string.IsNullOrWhiteSpace(drpTitle.Text) == false && string.IsNullOrWhiteSpace(txtFirstName.Text) == false && string.IsNullOrWhiteSpace(txtMiddleName.Text) == false && string.IsNullOrWhiteSpace(txtLastName.Text) == false && string.IsNullOrWhiteSpace(txtUsername.Text) == false && string.IsNullOrWhiteSpace(drpGender.Text) == false && string.IsNullOrWhiteSpace(txtAddress.Text) == false && string.IsNullOrWhiteSpace(drpCountry.Text) == false && string.IsNullOrWhiteSpace(txtPhoneNo.Text) == false)
                {
                    clsAddressDB addressesObj = new clsAddressDB();
                    addressesObj.AddressID = Convert.ToInt32(lblID.Text);
                    addressesObj.Title = (drpTitle.Text).ToString();
                    addressesObj.FirstName = (txtFirstName.Text).ToString();
                    addressesObj.MiddleName = (txtMiddleName.Text).ToString();
                    addressesObj.LastName = (txtLastName.Text).ToString();
                    addressesObj.Username = (txtUsername.Text).ToString();
                    addressesObj.Gender = (drpGender.Text).ToString();
                    addressesObj.BirthDay = Convert.ToDateTime(dtpBirthDay.Value.Date);
                    addressesObj.Address = (txtAddress.Text).ToString();
                    addressesObj.Country = (drpCountry.Text).ToString();
                    addressesObj.PhoneNo = (txtPhoneNo.Text).ToString();
                    addressesObj.Note = (txtNote.Text).ToString();
                    addressesObj.FKUsername = (lbluser.Text).ToString();
                    clsManipulateAddress addressObj = new clsManipulateAddress();
                    int output = addressObj.UpdateAddress(addressesObj);
                    if (output == 1)
                    {
                        MessageBox.Show("Address Updated");
                        this.Hide();
                        new ShowAddress(lbluser.Text).Show();
                    }
                    else
                    {
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

        #region Redirecting to other page
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