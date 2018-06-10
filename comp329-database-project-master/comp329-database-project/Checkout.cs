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
        BindingList<IcecreamItem> items;
        OracleAccessWidget DBWIDGET;
        string username;

        public Checkout(BindingList<IcecreamItem> _items, string firstname)
        {
            InitializeComponent();
            DBWIDGET = new OracleAccessWidget();

            //Load in the list of items in cart
            items = _items;

            //set the binding list to represent the cart items
            listBoxCartItems.DataSource = items;

            //set the users name
            username = firstname;
        }

        private void buttonBuyItems_Click(object sender, EventArgs e)
        {
            // Get the customer id
            int customerID = DBWIDGET.RetrieveSingleID("SELECT c.customer_id FROM customer c, person p WHERE p.person_id = c.customer_id AND p.fname = '" + username + "'");

            foreach (IcecreamItem i in items) {
                // Get the icecream id
                int iceCreamID = DBWIDGET.RetrieveSingleID("SELECT i.ice_cream_id FROM ice_cream i WHERE i.flavour = '" + i.flavour + "'");

                //Set the date
                DateTime dateTime = new DateTime(2018, 6, 11, 8, 27, 0);
                string formattedDate = dateTime.ToString("d"); //?
                string formattedTime = dateTime.ToString("T");

                int amountToMake = i.amount;

                for (int j = 0; j < amountToMake; j++)
                {
                    //Do an SQL query to add the items to be delivered, etc (requires a lot of linking with drivers and factories, etc)
                    // 1- Customer to Icecream via orders
                    DBWIDGET.Insert("INSERT into orders(date_ordered, time_ordered, ice_cream_id, customer_id) VALUES(to_date('" + formattedDate + "', 'MM/DD/YYYY'), '" + formattedTime + "', " + iceCreamID + ", " + customerID + ")");
                }
                // 2- Create a delivery truck?
                // 3- connect delivery truck to this icecream order?
            }

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
