using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        private bool CheckPass()
        {
            string OldPass = "";
            string NewPass = "";
            string RePass = "";
            OldPass = textBox1.Text;
            NewPass = textBox2.Text;
            RePass = textBox3.Text;
            if ((OldPass == Login_DAL.Instance.Pass) && (NewPass == RePass)) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckPass())
            {
                Login_DAL.Instance.ChangePass(textBox2.Text);
                MessageBox.Show("Done");
                this.Dispose();
            }
            else MessageBox.Show("Please Re-enter ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
