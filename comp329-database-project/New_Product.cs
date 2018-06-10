using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp329_database_project
{
    public partial class New_Product : Form
    {
        public New_Product()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Add a new product from the DB
            string flavour = textBoxFlavour.Text;
            string amountMade = textBoxIcecreamMade.Text;
            string factoryname = comboBoxSelectFactory.Text;

            //Do an SQL insert to add a new icecream to the DB
            // ...
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            //close this window
            this.Close();
        }
    }
}
