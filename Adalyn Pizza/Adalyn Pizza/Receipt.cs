using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace Adalyn_Pizza
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            listOrder.GridLines = true;
            if (CustomerDetails.toBeDelivered == true)
            {
                txtName.Visible = true; txtName.Text = CustomerDetails.name;
                txtStreet.Visible = true; txtStreet.Text = CustomerDetails.street;
                txtPostcode.Visible = true; txtPostcode.Text = CustomerDetails.postcode;
                txtPhone.Visible = true; txtPhone.Text = CustomerDetails.phonenumber;
                lblName.Visible = true;
                lblStreet.Visible = true;
                lblPhone.Visible = true;
                lblPostcode.Visible = true;
            }
            txtPrice.Text = ("The Final price is £" + Menu.finalPrice.ToString());





            try
            {
                listOrder.View = View.Details;
                for (int i = 0; i < Menu.FinalList.Length; i++)
                {
                    if (Menu.FinalList[i] == "Pizza Size : Small")
                    {
                        listOrder.Items.Add("Pizza Size : Small");


                    }
                    else
                    {
                        listOrder.Items.Add(Menu.FinalList[i].ToString());
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\22033662.OCC\receipt.txt");
            
            for (int i = 0; i < Menu.FinalList.Length; i++)
            {
                sw.WriteLine(Menu.FinalList[i]);
            }
        }
    }
}

