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
 *  TODO:
 *  - At load - do an SQL query to get all icecreams
 *  - For each icecream set its image, button handlers
 *  - For each button handler add item details to cart screen
 *  - Open Cart window when BUY pressed
 * 
 */ 

namespace comp329_database_project
{
    public partial class User_Window : Form
    {
        private string username;
        private BindingList<IcecreamItem> items = new BindingList<IcecreamItem>();
        OracleAccessWidget DBWIDGET;

        public User_Window(string firstname)
        {
            InitializeComponent();
            DBWIDGET = new OracleAccessWidget();

            username = firstname;
            //Set the form user to this
            linkLabelEditAccount.Text = username;
            //set the binding list to represent the cart items
            listBoxCartItems.DataSource = items;

            loadProducts();
        }

        private void loadProducts()
        {
            List<string> productNames = new List<string>();

            //SQL retrieve to get all the factories to be loaded -> into 'factoryNames'
            productNames = DBWIDGET.RetrieveFactoryNames("SELECT flavour FROM ice_cream");

            //Put the factories into the combobox
            listBoxListOfProducts.Items.Clear();
            listBoxListOfProducts.Items.AddRange(productNames.ToArray());
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            // Delete the selected item
            int index = listBoxCartItems.SelectedIndex;
            items.RemoveAt(index);
        }

        private void buttonBuyItems_Click(object sender, EventArgs e)
        {
            // Open the Checkout window and send through the cart items
            Checkout checkout = new Checkout(items, username);
            this.Hide();
            checkout.ShowDialog();
            
            //Delete items if brought otherwise dont if returned
            // ...

            this.Show();
        }

        private void linkLabelEditAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open up the Account_Page form to edit account details
            Account_Details AccountDetails = new Account_Details(username);
            this.Hide();
            AccountDetails.ShowDialog();
            this.Show();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Close this window
            this.Close();
        }

        private void buttonBuyItem_Click(object sender, EventArgs e)
        {
            //get select item name
            string itemName = listBoxListOfProducts.SelectedItem.ToString();

            //get amount
            int amount = (int)numericUpDownAmountToBuy.Value;

            //add the item to the customers items cart
            items.Add(new IcecreamItem(itemName, amount));

            //enable delete button on cart
            buttonBuyItems.Enabled = true;
            buttonRemoveSelected.Enabled = true;

            //reset the amount
            numericUpDownAmountToBuy.Value = 1;
        }
    }

    //Item class to temporarly store the wanted items
    public class IcecreamItem
    {
        public string flavour;
        public int amount;

        public IcecreamItem(string _flavour, int _amount)
        {
            this.flavour = _flavour;
            this.amount = _amount;
        }

        public override string ToString()
        {
            return flavour + " x" + amount;
        }
    }
}
