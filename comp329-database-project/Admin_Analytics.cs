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
    public partial class Admin_Analytics : Form
    {
        public Admin_Analytics()
        {
            InitializeComponent();
        }

        private void buttonAddNewFactory_Click(object sender, EventArgs e)
        {
            //Create a new factory
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            //Add a new icecream to factory
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            //delete an icecream from factory
        }

        private void tabControlFactories_TabIndexChanged(object sender, EventArgs e)
        {
            //load the selected city tab
        }

        private void buttonAddNewEmployee_Click(object sender, EventArgs e)
        {
            //Add a new employee to this factory
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            //Remove a employee from this factory
        }

        private void buttonRemoveFactory_Click(object sender, EventArgs e)
        {
            //delete this factory
        }
    }
}
