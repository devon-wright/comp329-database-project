using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ADD FACTORY SQL
// REMOVE CODE FOR E AND P

namespace comp329_database_project
{
    public partial class Admin_Analytics : Form
    {
        private string username;
        OracleAccessWidget DBWIDGET;

        public Admin_Analytics(string firstname)
        {
            InitializeComponent();
            this.username = firstname;

            DBWIDGET = new OracleAccessWidget();

            //set the logout text
            this.linkLabelEditAccount.Text = firstname;

            //load the current factories
            loadFactories();

            //load managers
            loadManagers();
        }

        private void loadFactories()
        {
            List<string> factoryNames = new List<string>();

            //SQL retrieve to get all the factories to be loaded -> into 'factoryNames'
            factoryNames = DBWIDGET.RetrieveFactoryNames("SELECT flocation FROM Factory");

            //Put the factories into the combobox
            comboBoxSelectFactory.Items.Clear();
            comboBoxSelectFactory.Items.AddRange(factoryNames.ToArray());
        }

        private void loadManagers()
        {
            List<string> managerIDs = new List<string>();

            //SQL retrieve to get all the factories to be loaded -> into 'factoryNames'
            managerIDs = DBWIDGET.RetrieveFactoryNames("SELECT management_ID FROM managementi");

            //Put the factories into the combobox
            comboBoxFactoryManager.Items.Clear();
            comboBoxFactoryManager.Items.AddRange(managerIDs.ToArray());
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
                //Get the last factory id
                int factoryID = DBWIDGET.getDBSize("SELECT count(*) FROM Factory") + 1;
                
                // Do an SQL query to add a new factory with connection to a manager - edit 'sqlCompleted'
                sqlCompleted = DBWIDGET.Insert("INSERT into factory (factory_id, flocation, amount_of_workers) VALUES(" + factoryID + ", '" + factoryLocation + "', " + amountOfWorkers + ")");

                //then connect to a management ID
                sqlCompleted = DBWIDGET.Insert("Insert into owns(manager_id, factory_id) Values(" + managerOfFactory + ", " + factoryID + ")");

                if (sqlCompleted)
                {
                    //Update the form with the new factory
                    loadFactories();
                    MessageBox.Show("Factory Added");
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
            string factory_name = comboBoxSelectFactory.Text;

            loadEmployees(factory_name);
            loadProducts(factory_name);

            //enable the add/remove buttons on screen
            buttonAddNewEmployee_P.Enabled = true;
            buttonAddNewProduct_P.Enabled = true;
        }

        private void loadEmployees(string factoryName)
        {
            List<string> employeeNames = new List<string>();

            //Do an SQL query to get all employee names for this selected factory
            //put into the combo-box
            employeeNames = DBWIDGET.RetrieveEmployeeNames("SELECT p.fname FROM person p, driver d, employs e, managementi m, owns o, factory f WHERE p.person_id = d.driver_id AND d.driver_id = e.driver_id AND e.manager_id = m.management_id AND m.management_id = o.manager_id AND o.factory_id = f.factory_id AND f.flocation = '" + factoryName + "'");

            comboBoxEmployees.Items.Clear();
            comboBoxEmployees.Items.AddRange(employeeNames.ToArray());
        }

        private void loadProducts(string factoryName)
        {
            List<string> productNames = new List<string>();

            //DO an SQL query to get all products this factory sells
            productNames = DBWIDGET.RetrieveProductNames("SELECT i.flavour FROM ice_cream i, makes m, factory f WHERE i.ice_cream_id = m.ice_cream_id AND m.factory_id = f.factory_id AND f.flocation = '" + factoryName + "'");

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
            //DBWIDGET.Delete("DELETE FROM ... WHERE fname='" + employeeName + "'"); <-- -REMOVE ALL FORIEGN KEYS
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
            //DBWIDGET.Delete("DELETE FROM ... WHERE fname='" + productName + "'"); <-- -REMOVE ALL FORIEGN KEYS
        }

        private void comboBoxSelectFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disable the add/remove buttons
            buttonAddNewEmployee_P.Enabled = false;
            buttonAddNewProduct_P.Enabled = false;
        }

        private void linkLabelEditAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open up the Account_Page form to edit account details
            Account_Details AccountDetails = new Account_Details(username);
            this.Hide();
            AccountDetails.ShowDialog();
            this.Show();
        }
    }
}
