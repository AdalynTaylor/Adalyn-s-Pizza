using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Adalyn_Pizza
{
    public partial class CustomerDetails : Form
    {
        public static string name;
        public static string street;
        public static string phonenumber;
        public static string postcode;
        public static bool toBeDelivered = false;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[A-Z]{1,2}[0-9R][0-9A-Z]? [0-9][ABD-HJLNP-UW-Z]{2}$");
            Regex phoneregex = new Regex("^\\+?[0-9][0-9]{7,14}$");
            if (txtCustName.Text == "" || txtCustStreet.Text == "" || txtCustPhone.Text == "" || txtCustPostcode.Text == "")
            {
                MessageBox.Show("Please fill in each box if you wish to progress further.");
            }
            else
            {
                if (regex.IsMatch(txtCustPostcode.Text) && phoneregex.IsMatch(txtCustPhone.Text)) 
                {
                    name = txtCustName.Text;
                    street = txtCustStreet.Text;
                    phonenumber = txtCustPhone.Text;
                    postcode = txtCustPostcode.Text;
                    toBeDelivered = true;
                    deliver Address = new deliver();
                    Address.Show();
                    this.Hide();
                }
                else if(!regex.IsMatch(txtCustPostcode.Text))
                {
                    MessageBox.Show("Please enter a valid Postcode");
                }
                else if (!phoneregex.IsMatch(txtCustPhone.Text))
                {
                    MessageBox.Show("Please enter a valid phone number");
                }
            }

        }


        private void btnSelectPizza_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            menu.FormClosed += (s, args) => this.Close();
        }

        private void txtCustPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
    }
}



