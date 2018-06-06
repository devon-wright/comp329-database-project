using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO:
 * - SQL insert to connect up a new delivery
 * - Show the time to deliver?
 */ 

namespace comp329_database_project
{
    public partial class Checkout : Form
    {
        List<IcecreamItem> items;

        public Checkout(List<IcecreamItem> _items)
        {
            InitializeComponent();
            //Load in the list of items in cart
            items = _items;
        }

        private void buttonBuyItems_Click(object sender, EventArgs e)
        {
            //Do an SQL query to add the items to be delivered, etc (requires a lot of linking with drivers and factories, etc)
            // ...

            //Tell the user the items will be delivered ... etc
            MessageBox.Show("Items have been brought. Will be delivered in ** days");

            //Close this window
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //return back to browse
            this.Close();
        }
    }
}
