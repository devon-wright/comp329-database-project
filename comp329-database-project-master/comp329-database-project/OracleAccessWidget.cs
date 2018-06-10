using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

/*
 * TODO:
 * - Add password (last 8 nums from ID) to "dbString" 
 * - Test each function works
 */

namespace comp329_database_project
{
    public class OracleAccessWidget
    {
        string dbString = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMP329_13;Password=VSmhECr9xu;";
        OracleConnection connection;

        public OracleAccessWidget()
        {
        }

        public bool testConnection()
        {
            try
            {
                string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMP329_13;Password=VSmhECr9xu;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Person";
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                MessageBox.Show(dr.GetValue(1).ToString());
                dr.Read();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void openConnection()
        {
            connection = new OracleConnection(dbString);
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Dispose();
        }

        public bool Insert(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Update(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Delete(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int getDBSize(string commandString)
        {
            openConnection();

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = commandString;
            command.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader = command.ExecuteReader();
            reader.Read();
            int size = reader.GetInt32(0);

            closeConnection();

            return size;
        }

        public List<string> RetrieveFactoryNames(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;

                OracleDataReader reader = command.ExecuteReader();

                List<string> names = new List<string>();
                while (reader.Read())
                {
                    names.Add(reader.GetValue(0).ToString());
                }
                return names;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<string>();
            }
        }

        public List<string> RetrieveProductNames(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;

                OracleDataReader reader = command.ExecuteReader();

                List<string> names = new List<string>();
                while (reader.Read())
                {
                    names.Add(reader.GetValue(0).ToString());
                }
                return names;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<string>();
            }
        }

        public List<string> RetrieveEmployeeNames(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;

                OracleDataReader reader = command.ExecuteReader();

                List<string> names = new List<string>();
                while (reader.Read())
                {
                    names.Add(reader.GetValue(0).ToString());
                }
                return names;
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }

        public int RetrieveSingleID(string commandString)
        {
            openConnection();

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = commandString;
            command.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader = command.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0);

            closeConnection();

            return id;
        }

        public string RetrieveString(string commandString)
        {
            openConnection();

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = commandString;
            command.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader = command.ExecuteReader();
            reader.Read();
            string value = reader.GetValue(0).ToString();

            closeConnection();

            return value;
        }

        public List<string> Retrieve(string commandString)
        {
            List<string> valueList = new List<string>();

            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;

                OracleDataReader reader = command.ExecuteReader();

                /*while(reader.Read())
                {
                    string line = reader.GetBoolean....;
                    valueList.Add(line);
                }*/


                closeConnection();
                return valueList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<string>();
            }

        }

        public bool itemExists(string commandString)
        {
            try
            {
                openConnection();

                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = commandString;
                command.CommandType = System.Data.CommandType.Text;

                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                reader.GetValue(0);

                closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
