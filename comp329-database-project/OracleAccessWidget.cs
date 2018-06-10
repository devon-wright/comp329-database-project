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
                MessageBox.Show(dr.GetString(0));
                conn.Dispose();

                return true;
            }
            catch(Exception ex)
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

        public object Retrieve(string commandString)
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

                closeConnection();
                return reader;
            }
            catch (Exception ex)
            {
                return new Exception("Error with Retrieve Query");
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

                closeConnection();

                if (reader.FetchSize == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
