using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;

namespace Client_App
{
    public class Datahandler
    {

        #region Connections
        private string connectionstring;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable datatable;
        public Datahandler(string connectionstringP = "default") 
        {
            this.connectionstring = ConfigurationManager.ConnectionStrings[connectionstringP].ConnectionString;
            connection = new SqlConnection(this.connectionstring);
        }

        #endregion

        #region Push Data
        public void InstertData(string StoredProcedureName, List<string> ColumnNames, ArrayList insertData) // Insert Data
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;


                for (int i = 0; i < ColumnNames.Count; i++)
                {
                    command.Parameters.Add(new SqlParameter(ColumnNames[i], insertData[i]));
                }

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }


        }

        #endregion

        #region Pull Data
      
        public DataTable GetDataFromSource(string storedProcedureName)  // tessting if database exists.
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;

        }

       
        public DataTable GetDataWithIDOnly(string givenID, string storedProcedureName, string iDName) //Call for data minimal.
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter(iDName, givenID));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

      


       
       

        public DataTable GetDataWithConstraints(string StoredProcedureName, List<string> ColumnNames, ArrayList insertData)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(StoredProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;


                for (int i = 0; i < ColumnNames.Count; i++)
                {
                    command.Parameters.Add(new SqlParameter(ColumnNames[i], insertData[i]));
                }
                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }
        #endregion


    }
}



