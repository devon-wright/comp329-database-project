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
    public partial class New_Product : Form
    {
        OracleAccessWidget DBWIDGET;

        public New_Product()
        {
            InitializeComponent();
            DBWIDGET = new OracleAccessWidget();
            LoadFactories();
        }

        private void LoadFactories()
        {
            List<string> factoryNames = new List<string>();

            //SQL retrieve to get all the factories to be loaded -> into 'factoryNames'
            factoryNames = DBWIDGET.RetrieveFactoryNames("SELECT flocation FROM Factory");

            //Put the factories into the combobox
            comboBoxSelectFactory.Items.Clear();
            comboBoxSelectFactory.Items.AddRange(factoryNames.ToArray());
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Add a new product from the DB
            string flavour = textBoxFlavour.Text;
            string amountMade = textBoxIcecreamMade.Text;
            string factoryname = comboBoxSelectFactory.Text;

            //get the last index value
            int nextIndex = DBWIDGET.getDBSize("SELECT count(*) FROM ice_cream");

            //get the id of the factory
            int factoryID = DBWIDGET.RetrieveSingleID("SELECT f.factory_id FROM factory f WHERE f.flocation = '" + factoryname + "'");

            //Do an SQL insert to add a new icecream to the DB
            DBWIDGET.Insert("INSERT into ice_cream (ice_cream_id, flavour, amount_made) VALUES(" + nextIndex + ", '" + flavour + "', " + amountMade + ")");
            DBWIDGET.Insert("INSERT into makes (factory_id, ice_cream_id) VALUES(" + factoryID + ", " + nextIndex + ")");

            this.Close();
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            //close this window
            this.Close();
        }
    }
}
