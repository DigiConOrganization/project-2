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
    public partial class frm_Customer_Dash : Form
    {
         public int c_ID;
        public User_Class us;

        public frm_Customer_Dash()
        {
            InitializeComponent();
            tbc_Customer.TabPages.Remove(tbp_account);
            tbc_Customer.TabPages.Remove(tbp_view_oder);
            tbc_Customer.TabPages.Remove(tbp_hire_truck);
            tbc_Customer.Appearance = TabAppearance.FlatButtons;
            tbc_Customer.ItemSize = new Size(0, 1);
            tbc_Customer.SizeMode = TabSizeMode.Fixed;
            us = new User_Class();
        }

        private void btn_reset_pass_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_account_info_Click(object sender, EventArgs e)
        {
            
            tbc_Customer.TabPages.Add(tbp_account);
            tbc_Customer.TabPages.Remove(tbp_view_oder);
            tbc_Customer.TabPages.Remove(tbp_hire_truck);
            
            us.Populator(c_ID);
            txt_account_name.Text = us.Customer_username;
            txt_account_surname.Text = us.Customer_surname;
            txt_account_cell.Text = us.Customer_cell;
            txt_account_email.Text = us.Customer_email;

        }

        private void Btn_view_orders_Click(object sender, EventArgs e)
        {
            
            tbc_Customer.TabPages.Remove(tbp_account);
            tbc_Customer.TabPages.Add(tbp_view_oder);
            tbc_Customer.TabPages.Remove(tbp_hire_truck);
        }

        private void Btn_hire_truck_Click(object sender, EventArgs e)
        {
            
            tbc_Customer.TabPages.Remove(tbp_account);
            tbc_Customer.TabPages.Remove(tbp_view_oder);
            tbc_Customer.TabPages.Add(tbp_hire_truck);
        }

        private void Btn_update_Click(object sender, EventArgs e)   
        {
            string sNewPassword;
            
            if (us.Customer_password == txt_account_current_pass.Text && txt_account_current_pass.Text != "" )
            {
                User_Class up = new User_Class(c_ID, txt_account_name.Text, txt_account_surname.Text, txt_account_cell.Text, txt_account_email.Text, txt_account_pass.Text);
            }

           

        }
    }
}
