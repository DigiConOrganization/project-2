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
    class User_Class
    {
        private int customer_ID;
        private string customer_username;
        private string customer_password;

        public User_Class(int customer_ID, string customer_username, string customer_password)
        {
            this.Customer_ID = customer_ID;
            this.Customer_username = customer_username;
            this.Customer_password = customer_password;
        }

        public int Customer_ID { get => customer_ID; set => customer_ID = value; }
        public string Customer_username { get => customer_username; set => customer_username = value; }
        public string Customer_password { get => customer_password; set => customer_password = value; }

        public bool GetCustomerLoginInfo()             // Collecting user data.
        {

            Datahandler dtHandler = new Datahandler();
            DataTable dTable = dtHandler.GetDataFromSource("GetCustomerLoginInfo"); // get prosudure name;
            List<User_Class> theList = new List<User_Class>();

            foreach (DataRow dataitem in dTable.Rows)
            {
                theList.Add(new User_Class(int.Parse(dataitem["customer_ID"].ToString()), dataitem["customer_name"].ToString(), dataitem["customer_password"].ToString()));
            }
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i].Customer_ID == Customer_ID && theList[i].Customer_password == customer_password)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
