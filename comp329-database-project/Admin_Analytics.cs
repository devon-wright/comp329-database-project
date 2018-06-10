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
        private string username;

        public Admin_Analytics(string firstname)
        {
            InitializeComponent();
            this.username = firstname;

            //set the logout text
            this.linkLabelEditAccount.Text = firstname;

            //load the current factories
            loadFactories();
        }

        private void loadFactories()
        {
            List<string> factoryNames = new List<string>();

            //SQL retireve to get all the factories to be loaded -> into 'factoryNames'
            // ...

            //Put the factories into the combobox
            comboBoxEmployees.Items.Clear();
            comboBoxEmployees.Items.AddRange(factoryNames.ToArray());
        }

        private void buttonAddNewFactory_Click_1(object sender, EventArgs e)
        {
            //Create a new factory
            bool isFilledIn = false;
            bool sqlCompleted = false;

            string factoryLocation = textBoxLocation.Text;
            string amountOfWorkers = textBoxAmountofWorkers.Text; // convert it to int for DB
            string managerOfFactory = comboBoxFactoryManager.Text;

            if (string.IsNullOrWhiteSpace(factoryLocation))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(amountOfWorkers))
                isFilledIn = false;
            else if (string.IsNullOrWhiteSpace(managerOfFactory))
                isFilledIn = false;
            else
                isFilledIn = true;

            if (isFilledIn)
            {
                // Do an SQL query to add a new factory with connection to a manager - edit 'sqlCompleted'

                if (sqlCompleted)
                {
                    //Update the form with the new factory
                    loadFactories();
                }
                else
                {
                    MessageBox.Show("There was an error completing your request");
                }
            }
            else
            {
                MessageBox.Show("Please complete all textboxes before submitting");
            }
        }

        private void buttonLoadFactory_Click(object sender, EventArgs e)
        {
            //load the details Of the selected factory into the combobox's
            string factory_name = comboBoxSelectFactory.SelectedText;

            loadEmployees(factory_name);
            loadProducts(factory_name);

            //enable the add/remove buttons on screen
            buttonAddNewEmployee_P.Enabled = true;
            buttonAddNewProduct_P.Enabled = true;
            buttonRemoveEmployee_P.Enabled = true;
            buttonRemoveProduct_P.Enabled = true;
        }

        private void loadEmployees(string factoryName)
        {
            List<string> employeeNames = new List<string>();

            //Do an SQL query to get all employee names for this selected factory
            //put into the combo-box
            // ...

            comboBoxEmployees.Items.Clear();
            comboBoxEmployees.Items.AddRange(employeeNames.ToArray());
        }

        private void loadProducts(string factoryName)
        {
            List<string> productNames = new List<string>();

            //DO an SQL query to get all products this factory sells
            //put into the combo-box
            // ...

            comboBoxProducts.Items.Clear();
            comboBoxProducts.Items.AddRange(productNames.ToArray());
        }

        private void buttonAddNewEmployee_P_Click(object sender, EventArgs e)
        {
            //Open up the Add-New-Employee Form
            New_Employee newEmployee = new New_Employee();
            this.Hide();
            newEmployee.ShowDialog();
            this.Show();

            loadEmployees(comboBoxSelectFactory.Text);
        }

        private void buttonRemoveEmployee_P_Click(object sender, EventArgs e)
        {
            string employeeName = comboBoxEmployees.Text;

            //Do an SQL delete to remove the employee that matches the employee name
            // ...
        }

        private void buttonAddNewProduct_P_Click(object sender, EventArgs e)
        {
            //Open up the add-product form
            New_Product newProduct = new New_Product();
            this.Hide();
            newProduct.ShowDialog();
            this.Show();

            loadProducts(comboBoxSelectFactory.Text);
        }

        private void buttonRemoveProduct_P_Click(object sender, EventArgs e)
        {
            string productName = comboBoxProducts.Text;

            //Do an SQL delete to remove the product that matches the product name
            // ...
        }

        private void comboBoxSelectFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disable the add/remove buttons
            buttonAddNewEmployee_P.Enabled = false;
            buttonAddNewProduct_P.Enabled = false;
            buttonRemoveEmployee_P.Enabled = false;
            buttonRemoveProduct_P.Enabled = false;
        }
    }
}
