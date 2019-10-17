using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Client_App
{
    public partial class frm_Sign_up : Form
    {
        public frm_Sign_up()
        {
            InitializeComponent();
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            if ((txt_signup_cell.Text == "") || ( txt_signup_email.Text == "") || (txt_signup_name.Text == "") || (txt_signup_password.Text == "") || (txt_signup_surname.Text == "") ||)
            {
                MessageBox.Show("please don't leave any fields empty");
            }
            else
            {
                
                ArrayList a1 = new ArrayList();
                List<string> c_names = new List<string>() {"customer_name","customer_surname","customer_cell","customer_email" };
                
                
                a1.Add(txt_signup_name.Text);
                a1.Add(txt_signup_surname.Text);
                a1.Add(txt_signup_cell.Text);
                a1.Add(txt_signup_email.Text);

                Datahandler data = new Datahandler();
                data.InstertData("", c_names , a1);
               
            }
           
        }
    }
}
