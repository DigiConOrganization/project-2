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

namespace Classbuilds
{
    class Employee_Class
    {
        private int emp_ID;
        private string emp_name;
        private string emp_password;
        private string emp_surname;
        private string emp_dob;
        private string emp_email;
        private string emp_cell;
        private string emp_job_title;
        private double emp_pay_cut;
        private double emp_total_pay;
        private string emp_type;
        private SqlConnection connection;
        private SqlCommand command;
        

        public Employee_Class(int emp_ID, string emp_name, string emp_password)
        {
            this.emp_ID = emp_ID;
            this.emp_name = emp_name;
            this.emp_password = emp_password;
        }

        public Employee_Class(int emp_ID, string emp_name, string emp_surname, string emp_dob, string emp_password, string emp_email, string emp_cell, string emp_job_title, double emp_pay_cut, double emp_total_pay, string emp_type)
        {
            this.Emp_ID = emp_ID;
            this.Emp_name = emp_name;
            this.Emp_password = emp_password;
            this.Emp_surname = emp_surname;
            this.Emp_dob = emp_dob;
            this.Emp_email = emp_email;
            this.Emp_cell = emp_cell;
            this.Emp_job_title = emp_job_title;
            this.Emp_pay_cut = emp_pay_cut;
            this.Emp_total_pay = emp_total_pay;
            this.Emp_type = emp_type;
        }

        public int Emp_ID { get => emp_ID; set => emp_ID = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public string Emp_surname { get => emp_surname; set => emp_surname = value; }
        public string Emp_dob { get => emp_dob; set => emp_dob = value; }
        public string Emp_password { get => emp_password; set => emp_password = value; }
        public string Emp_email { get => emp_email; set => emp_email = value; }
        public string Emp_cell { get => emp_cell; set => emp_cell = value; }
        public string Emp_job_title { get => emp_job_title; set => emp_job_title = value; }
        public double Emp_pay_cut { get => emp_pay_cut; set => emp_pay_cut = value; }
        public double Emp_total_pay { get => emp_total_pay; set => emp_total_pay = value; }
        public string Emp_type { get => emp_type; set => emp_type = value; }

        public bool GetEmployeeLoginInfo()             // Collecting user data.
        {

            Datahandler dtHandler = new Datahandler();
            DataTable dTable = dtHandler.GetDataFromSource("GetEmployeeLoginInfo"); // get prosudure name;
            List<Employee_Class> theList = new List<Employee_Class>();

            foreach (DataRow dataitem in dTable.Rows)
            {
                theList.Add(new Employee_Class(int.Parse(dataitem["emp_ID"].ToString()), dataitem["emp_name"].ToString(), dataitem["emp_password"].ToString()));
            }
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i].Emp_ID == emp_ID && theList[i].Emp_password == emp_password)
                {
                    return true;
                }
            }
            return false;
        }
        public void InstertData(string StoredProcedureName, List<string> ColumnNames, ArrayList insertData) // Insert Data, throw the stroredProcedureName in its namesake.
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


    }
}
