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
    public partial class User_Window : Form
    {
        private string username;

        public User_Window(string firstname)
        {
            InitializeComponent();
            username = firstname;
            //Set the form user to this
            linkLabelEditAccount.Text = username;
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuyItems_Click(object sender, EventArgs e)
        {

        }

        private void listBoxCartItems_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddtoCart_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelEditAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
