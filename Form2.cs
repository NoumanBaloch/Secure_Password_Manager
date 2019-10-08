using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FYP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] countries = File.ReadAllLines(@"F:\FYP\FYP\countries.dsn");
            for (int i = 0; i < countries.Length; i++)
            {
                drpCountries.Items.Add(countries[i]);
            }
            if (drpCountries.Items.Count > 0)
                drpCountries.SelectedIndex = 0;
        }

        private void drpCountries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
