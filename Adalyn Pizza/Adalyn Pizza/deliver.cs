using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adalyn_Pizza
{
    public partial class deliver : Form
    {

        public deliver()
        {
            InitializeComponent();

        }

        private void btnSelectPizza_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void deliver_Load(object sender, EventArgs e)
        {
            txtCustName.Text = CustomerDetails.name;
            txtCustStreet.Text = CustomerDetails.street;
            txtCustPostcode.Text = CustomerDetails.postcode;
            txtCustPhone.Text = CustomerDetails.phonenumber;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDetails cust = new CustomerDetails();
            cust.Show();
            this.Close();

        }
    }
}
