using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Collections;



namespace Client_App
{
    public class User_Class
    {
        private int customer_ID;
        private string customer_username;
        private string customer_password;
        private string customer_surname;
        private string customer_cell;
        private string customer_email;


        public User_Class() { }
        public void Populator(int ID)
        {
            Datahandler dth = new Datahandler();
            DataTable dataT = dth.GetDataWithIDOnly(ID.ToString(), "get_all_customer_info", "@customer_ID");
            foreach (DataRow dataItem in dataT.Rows)
            {
                Customer_username = dataItem["customer_name"].ToString();
                Customer_surname = dataItem["customer_surname"].ToString();
                Customer_cell = dataItem["customer_cell"].ToString();
                Customer_email = dataItem["customer_email"].ToString();
                Customer_password = dataItem["customer_password"].ToString();
            }


        }
        public User_Class( string customer_username, string customer_password)
        {
            this.Customer_username = customer_username;
            this.Customer_password = customer_password;
        }

        public User_Class(int customer_ID, string customer_username, string customer_password)
        {
            this.Customer_ID = customer_ID;
            this.Customer_username = customer_username;
            this.Customer_password = customer_password;
        }

        public User_Class(int customer_ID, string customer_username, string customer_password, string customer_surname, string customer_cell, string customer_email)
        {
            this.Customer_ID = customer_ID;
            this.Customer_username = customer_username;
            this.Customer_password = customer_password;
            this.Customer_surname = customer_surname;
            this.Customer_cell = customer_cell;
            this.Customer_email = customer_email;
        }

        public int Customer_ID { get => customer_ID; set => customer_ID = value; }
        public string Customer_username { get => customer_username; set => customer_username = value; }
        public string Customer_password { get => customer_password; set => customer_password = value; }
        public string Customer_surname { get => customer_surname; set => customer_surname = value; }
        public string Customer_cell { get => customer_cell; set => customer_cell = value; }
        public string Customer_email { get => customer_email; set => customer_email = value; }

        public bool GetCustomerLoginInfo()             // Collecting user data.
        {

            Datahandler dtHandler = new Datahandler();
            DataTable dTable = dtHandler.GetDataFromSource("get_customer_login_Info"); // get prosudure name;
            List<User_Class> theList = new List<User_Class>();

            foreach (DataRow dataitem in dTable.Rows)
            {
                theList.Add(new User_Class(int.Parse(dataitem["customer_ID"].ToString()), dataitem["customer_name"].ToString(), dataitem["customer_password"].ToString()));
            }
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i].Customer_username == Customer_username && theList[i].Customer_password == Customer_password)
                {
                    Customer_ID = theList[i].Customer_ID;
                    return true;
                }
            }
            return false;
        }



    }
}
