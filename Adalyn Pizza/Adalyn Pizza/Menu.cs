using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adalyn_Pizza
{

    public partial class Menu : Form
    {
        public static int finalPrice = 0;
        List<string> ToppingItems = new List<string>();
        public static String[] FinalList;
        //public static System.Object[] ToppingItems = new System.Object[12];

        Dictionary<string, int> integers = new Dictionary<string, int>();
        public Menu()
        {
            InitializeComponent();


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            integers.Add("Small", 13);
            integers.Add("Medium", 16);
            integers.Add("Large", 18);
            integers.Add("Extra-Large", 23);
            integers.Add("Sausage Stuffed", 5);
            integers.Add("Cracker", 3);
            integers.Add("Thin", 2);
            integers.Add("Flat Bread", 2);
            integers.Add("Cheese stuffed", 5);
            integers.Add("Thick Stuffed", 3);
            integers.Add("Gluten Free", 1);
        }
        private void btnExtra_Click(object sender, EventArgs e)
        {
            int limit = 1;


            if (limit == 4)
            {
                cmbExtra.Enabled = false;
            }
            else
            {
                limit += 1;
                cmbExtra.Text = "";
                finalPrice += 1;
                ToppingItems.Add(cmbExtra.SelectedItem.ToString());
            }
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {

            int intValue = integers[(string)boxPizzaSize.SelectedItem];
            int intValue2 = integers[(string)boxCrust.SelectedItem];

            finalPrice = finalPrice += intValue += intValue2;

            ToppingItems.Add(boxTopping1.SelectedItem.ToString());
            ToppingItems.Add(boxTopping2.SelectedItem.ToString());
            ToppingItems.Add(boxTopping3.SelectedItem.ToString());
            ToppingItems.Add("Pizza Size : " + boxPizzaSize.SelectedItem.ToString());
            ToppingItems.Add("Sauce Choice : " + boxSauce.SelectedItem.ToString());
            ToppingItems.Add("Crust Choice : " + boxCrust.SelectedItem.ToString());
            ToppingItems.Add("Side Choice : " + boxSide.SelectedItem.ToString());
            if (cmbExtra.SelectedItem == "")
            {

            }
            else
            {
                ToppingItems.Add(cmbExtra.SelectedItem.ToString());
            }

            FinalList = ToppingItems.ToArray();

            Receipt receipt = new Receipt();
            receipt.Show();
            this.Hide();
        }

        private void boxTopping1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
