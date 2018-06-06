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
 *  - Add User SQL check
 *  - Add Admin SQL + Connect to Admin_Page form
 */ 

namespace comp329_database_project
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            textBoxFirstname.Focus();
        }

        private void buttonLoginUser_Click(object sender, EventArgs e)
        {
            string username = textBoxFirstname.Text;
            string password = textBoxPassword.Text;
            bool isCorrect = false;

            //Do an SQL check for user - edit "isCorrect"
            // ...

            if (isCorrect)
            {
                //Login the user - by opening User_Product_Page form and hide Form1 form (this)
                User_Window ProductPage = new User_Window(username);
                this.Hide();
                ProductPage.ShowDialog();
                this.Show(); // This is run once the User form is closed
            }
            else
            {
                //Show a dialogue box to reenter data, clear password field
                MessageBox.Show("Firstname/Password is incorrect. Please re-enter");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            string username = textBoxFirstname.Text;
            string password = textBoxPassword.Text;
            bool isCorrect = false;

            //Do an SQL check for admin - edit "isCorrect"
            // ...

            if (isCorrect)
            {
                //Login the user - by opening Admin_Window form and hide Form1 form (this)
                //Admin_Window AdminPage = new Admin_Window(username);
                //this.Hide();
                //Admin_Window.ShowDialog();
                //this.Show(); // This is run once the Admin form is closed
            }
            else
            {
                //Show a dialogue box to reenter data, clear password field
                MessageBox.Show("Firstname/Password is incorrect. Please re-enter");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }

        private void linkLabelAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Add_New_User form 
            Add_New_User NewUser = new Add_New_User();
            this.Hide();
            NewUser.ShowDialog();
            this.Show();
        }
    }
}
