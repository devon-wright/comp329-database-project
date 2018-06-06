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
 *  - SQL query to load user details
 *  - Put the returned details into the textboxes
 *  - SQL Update to update the user details
 */ 

namespace comp329_database_project
{
    public partial class Account_Details : Form
    {
        private string username;

        public Account_Details(string firstname)
        {
            InitializeComponent();
            username = firstname;

            //load the users details
            loadDetails(firstname);
        }

        private void loadDetails(string firstname)
        {
            bool isLoadSuccessful = false;

            //Do an SQL query to get this users details - edit "isLoadSuccessful"
            // ...

            if (isLoadSuccessful)
            {
                //put the details into the textboxes
                // ...
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        { 
            string lastname = textBoxLastname.Text;
            string phoneNumber = textBoxPhone.Text;
            string streetAddress = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string postcode = textBoxPostcode.Text;
            string password = textBoxPassword.Text;

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
            else if (string.IsNullOrWhiteSpace(password))
                isFilledIn = false;
            else
                isFilledIn = true;

            if (isFilledIn)
            {
                //Do an SQL edit to update the user details - edit "isSuccessfulEdit"
                // ...

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
