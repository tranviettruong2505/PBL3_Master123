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
    public partial class UC_ManageBook : UserControl
    {
        public UC_ManageBook()
        {
            InitializeComponent();
          dataGridView2.DataSource = CSDL_OOP.Instance.GetBookstores("");
            dataGridView1.DataSource = CSDL_OOP.Instance.GetBookstores("");
            setCBB();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = "";
            name = textBox1.Text;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = CSDL_OOP.Instance.GetBookstores(name);
        }
        private void setCBB()
        {
            int count = 0;
            foreach (DataColumn i in CSDL_USER.Instance.Books.Columns)
            {
                comboBox1.Items.Add(new CBBItems()
                {
                    Text = i.ColumnName,
                    value = count
                });
                count++;
            }
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
