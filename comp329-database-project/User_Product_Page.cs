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

        public User_Window(string firstname)
        {
            InitializeComponent();
            username = firstname;
            //Set the form user to this
            linkLabelEditAccount.Text = username;
            //set the binding list to represent the cart items
            listBoxCartItems.DataSource = items;
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
            Checkout checkout = new Checkout(items.ToList());
        }

        private void listBoxCartItems_Click(object sender, EventArgs e)
        {
            // Highlight the selected item (if any) and enable the delete button (work with its ID!)
            // ...
        }

        private void buttonAddtoCart_Click(object sender, EventArgs e)
        {
            // ! This needs to be a seperate handler for each icecream GUI panel

            //Add a "IcecreamItem" item to the list "items" 

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
    }

    //Item class to temporarly store the wanted items
    public class IcecreamItem
    {
        public int id, amountToBuy;
        public string flavour;

        public IcecreamItem(int _id, string _flavour, int _amountToBuy)
        {
            this.id = _id;
            this.flavour = _flavour;
            this.amountToBuy = _amountToBuy;
        }

        public override string ToString()
        {
            return id + " - " + flavour + " x" + amountToBuy;
        }
    }
}
