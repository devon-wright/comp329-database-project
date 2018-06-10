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
    public partial class Add_New_User : Form
    {
        OracleAccessWidget DBWIDGET;

        public Add_New_User()
        {
            InitializeComponent();
            DBWIDGET = new OracleAccessWidget();
            textBoxFirstname.Focus();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string firstname = textBoxFirstname.Text;
            string lastname = textBoxLastname.Text;
            string phoneNumber = textBoxPhone.Text;
            string streetAddress = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string postcode = textBoxPostcode.Text;

            bool isFilledIn = false;
            bool isUsernameFree = false;
            bool isSuccessfulAdd = false;

            //Check all textbox's - only continue if they are filled - otherwise tell the user
            if (string.IsNullOrWhiteSpace(firstname))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(lastname))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(phoneNumber))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(streetAddress))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(city))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(postcode))
                isFilledIn = false;
            else
                isFilledIn = true;

            if (isFilledIn)
            {
                //Do an SQL check to see if username is free to use - edit "isUsernameFree"
                isUsernameFree = !DBWIDGET.itemExists("SELECT * FROM Person WHERE fname='" + firstname + "'");

                if (isUsernameFree)
                {
                    //Do an SQL statement to get the last Person ID, then + 1 to it
                    int nextID = DBWIDGET.getDBSize("SELECT count(*) FROM Person") + 1;

                    //Do an SQL insert to add a new user - if successful then edit "isSuccessfulAdd"
                    isSuccessfulAdd = DBWIDGET.Insert("INSERT INTO Person (person_ID, fname, lname, Phone_number, Street_Address, City, Postcode) VALUES (" + nextID + ", '" + firstname + "', '" + lastname + "', '" + phoneNumber + "', '" + streetAddress + "', '" + city + "', '" + postcode + "')");
                    //and set them as a customer
                    DBWIDGET.Insert("INSERT INTO customer (customer_id) VALUES (" + nextID + ")");

                    if (isSuccessfulAdd)
                    {
                        //Login the user - by opening User_Product_Page form and hide Form1 form (this)
                        User_Window ProductPage = new User_Window(firstname);
                        this.Hide();
                        ProductPage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //Tell the user there has been an error
                        MessageBox.Show("Error on user profile addition. Contact System Admin");
                    }
                }
                else
                {
                    //Username is taken
                    MessageBox.Show("Username is taken. Please enter a new first/user name");
                    textBoxFirstname.Clear();
                    textBoxFirstname.Focus();
                }
            }
            else
            {
                //Need to fill in all boxes
                MessageBox.Show("Please fill in all areas.");
            }
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            //Close this window
            this.Close();
        }
    }
}
