using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using PBL3_BookShopManagement.GUI.Forms;

namespace BookShopManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBox1.Text;
            string password = textBox2.Text;
            if (Login_DAL.Instance.Staff_Infor(account,password).Rows.Count >0)
            {
                Login_DAL.Instance.Get_Infor_Staff();
                string k =Login_DAL.Instance.ID_Pos;
               if(k == "3")
                using (Form_Dashboard fd = new Form_Dashboard())
                {
                    fd.ShowDialog();
                }
               if(k=="1")
                {
                    using (Form_Dashboard_Admin fd = new Form_Dashboard_Admin())
                    {
                        fd.ShowDialog();
                    }
                }
               if(k == "2")
                    using (Form_DB_ST fd = new Form_DB_ST())
                    {
                        fd.ShowDialog();
                    }
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
        }
    }
}
