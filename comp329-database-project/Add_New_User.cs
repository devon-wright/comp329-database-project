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
 *  - SQL check for username being taken
 *  - SQL insert for new user
 *  - On successful add close current window
 */ 

namespace comp329_database_project
{
    public partial class Add_New_User : Form
    {
        public Add_New_User()
        {
            InitializeComponent();
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
            string password = textBoxPassword.Text;

            bool isFilledIn = true;
            bool isUsernameFree = true; // <
            bool isSuccessfulAdd = true;

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
            else if (string.IsNullOrWhiteSpace(password))
                isFilledIn = false;

            if (isFilledIn)
            {
                //Do an SQL check to see if username is free to use - edit "isUsernameFree"
                // ...

                if (isUsernameFree)
                {
                    //Do an SQL insert to add a new user - if successful then edit "isSuccessfulAdd"
                    // ...

                    if (isSuccessfulAdd)
                    {
                        //Login the user - by opening User_Product_Page form and hide Form1 form (this)
                        User_Window ProductPage = new User_Window(firstname);
                        ProductPage.ShowDialog();

                        // Close this page when logining in
                        // ...
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
