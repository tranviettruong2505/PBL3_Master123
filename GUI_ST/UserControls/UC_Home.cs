using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            setLabel();
           
        }
        void setLabel()
        {
            label10.Text = Convert.ToString(CSDL_OOP.Instance.getST().ID_Staff);
            label9.Text = CSDL_OOP.Instance.getST().Name_Staff;
            if (CSDL_OOP.Instance.getST().Gender) label11.Text = "Male"; else label11.Text = "Female";
            label12.Text = Convert.ToString(CSDL_OOP.Instance.getST().DateOfBirth);
            label13.Text = Convert.ToString(CSDL_OOP.Instance.getST().Address);
            label14.Text = Convert.ToString(CSDL_OOP.Instance.getST().PhoneNumber);
            label16.Text = CSDL_OOP.Instance.getST().Email;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePass f = new ChangePass();
            f.Show();
            
        }
    }
}
