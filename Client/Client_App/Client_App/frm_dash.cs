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
         int c_ID;
        public frm_Customer_Dash()
        {
            InitializeComponent();
            tbc_Customer.Appearance = TabAppearance.FlatButtons;
            tbc_Customer.ItemSize = new Size(0, 1);
            tbc_Customer.SizeMode = TabSizeMode.Fixed;
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
    }
}
