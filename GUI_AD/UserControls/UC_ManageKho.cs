using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_BookShopManagement.BLL;

namespace PBL3_BookShopManagement.GUI.UserControls
{
    public partial class UC_ManageKho : UserControl
    {
        public UC_ManageKho()
        {
            InitializeComponent();
            SetGUI();
            ShowTheoSach();
        }

        public void SetGUI()
        {
            rbtnTheoSach.Checked = true;
            txtTongSach.Text = BLL_ThongKe.Instance.GetTongSoSachKho_BLL().ToString();
            txtSachCon.Text = BLL_ThongKe.Instance.GetSoSachConKho_BLL().ToString();
        }

        public void ShowTheoSach()
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetKhobySach_BLL();
            dataGridView1.Columns[0].HeaderText = "ID Book";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Amount";
            dataGridView1.Columns[3].HeaderText = "Remaining Amount";
        }
        public void ShowTheoLoaiSach()
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetKhobyLoaiSach_BLL();
            dataGridView1.Columns[0].HeaderText = "Kind of book";
            dataGridView1.Columns[1].HeaderText = "Amount";
            dataGridView1.Columns[2].HeaderText = "Remaining Amount";
        }
        public void ShowTheoLinhVuc()
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetKhobyLinhVuc_BLL();
            dataGridView1.Columns[0].HeaderText = "Category";
            dataGridView1.Columns[1].HeaderText = "Amount";
            dataGridView1.Columns[2].HeaderText = "Remaining Amount";
        }

        private void rbtnTheoSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTheoSach.Checked) 
            {
                ShowTheoSach();
            }
        }

        private void rbtnTheoLoaiSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTheoLoaiSach.Checked)
            {
                ShowTheoLoaiSach();
            }
        }

        private void rbtnTheoLinhVuc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTheoLinhVuc.Checked)
            {
                ShowTheoLinhVuc();
            }
        }

    }
}
