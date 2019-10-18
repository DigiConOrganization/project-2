using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

       

        private void Btn_new_customer_Click(object sender, EventArgs e)
        {
            frm_Sign_up fs = new frm_Sign_up();                 // closing frm_login and openong frm_Sign_up.
            fs.Region = this.Region;
            fs.Show();
            this.Hide();
        }

        private void Btn_login_Click_1(object sender, EventArgs e)
        {

            



            User_Class us = new User_Class( txt_customer_username.Text, txt_customer_pass.Text);
            if (us.GetCustomerLoginInfo())
            {
                frm_Customer_Dash cd = new frm_Customer_Dash();         //If GetCustomerLoginInfo = true. move to frm_Customer_Dash
                cd.Region = this.Region;
                cd.c_ID = us.Customer_ID;
                cd.Show();
                this.Hide();
                


            }
            else
            {
                MessageBox.Show("The username or password is incorect");
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Sign_up fs = new frm_Sign_up();                 // closing frm_login and openong frm_Sign_up.
            fs.Region = this.Region;
            fs.Show();
            this.Hide();
        }
    }
}
