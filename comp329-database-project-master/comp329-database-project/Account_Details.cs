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
    public partial class Account_Details : Form
    {
        private string username;
        OracleAccessWidget DBWIDGET;

        public Account_Details(string firstname)
        {
            InitializeComponent();
            DBWIDGET = new OracleAccessWidget();

            username = firstname;

            //load the users details
            loadDetails(firstname);
        }

        private void loadDetails(string firstname)
        {
            bool isLoadSuccessful = true;

            //Do an SQL query to get this users details - edit "isLoadSuccessful"
            string fname = firstname;
            string lname = DBWIDGET.RetrieveString("SELECT p.lname from Person p WHERE fname='" + firstname + "'");
            string phone = DBWIDGET.RetrieveString("SELECT p.phone_number from Person p WHERE fname='" + firstname + "'");
            string saddress = DBWIDGET.RetrieveString("SELECT p.street_address from Person p WHERE fname='" + firstname + "'");
            string city = DBWIDGET.RetrieveString("SELECT p.city from Person p WHERE fname='" + firstname + "'");
            string postcode = DBWIDGET.RetrieveString("SELECT p.postcode from Person p WHERE fname='" + firstname + "'");

            if (isLoadSuccessful)
            {
                //put the details into the textboxes
                textBoxFirstname.Text = fname;
                textBoxLastname.Text = lname;
                textBoxPhone.Text = phone;
                textBoxStreet.Text = saddress;
                textBoxCity.Text = city;
                textBoxPostcode.Text = postcode;
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        { 
            string lastname = textBoxLastname.Text;
            string phoneNumber = textBoxPhone.Text;
            string streetAddress = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string postcode = textBoxPostcode.Text;

            bool isFilledIn = false;
            bool isSuccessfulEdit = false;

            //Check all textbox's - only continue if they are filled - otherwise tell the user
            if (string.IsNullOrWhiteSpace(lastname))
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
                //Do an SQL edit to update the user details - edit "isSuccessfulEdit"
                isSuccessfulEdit = DBWIDGET.Update("update person SET lname = '" + lastname + "', phone_number = '" + phoneNumber + "', street_address = '" + streetAddress + "', city = '" + city + "', postcode = '" + postcode + "' WHERE fname = '" + textBoxFirstname.Text + "'");

                if (isSuccessfulEdit)
                {
                    // Close this page 
                    this.Close();
                }
                else
                {
                    //Tell the user there has been an error
                    MessageBox.Show("Error on user profile edit. Contact System Admin");
                }
            }
            else
            {
                //Need to fill in all boxes
                MessageBox.Show("Please fill in all areas.");
            }
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            //Close the window without editing
            this.Close();
        }
    }
}
