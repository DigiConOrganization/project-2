using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truck
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            int emp_id;
            emp_id = 0;



            Employee_Class ec = new Employee_Class(emp_id, txt_emp_username.Text, txt_emp_pass.Text);
            if (ec.GetEmployeeLoginInfo())
            {
                frm_employee_dash ed = new frm_employee_dash();         //If GetEmployeeLoginInfo = true. move to frm_Customer_Dash
                ed.Region = this.Region;
                ed.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("The username or password is incorect");
            }
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            frm_sign_up fs = new frm_sign_up();                 // closing frm_login and openong frm_sign_up.
            fs.Region = this.Region;
            fs.Show();
            this.Hide();
        }
    }
}
