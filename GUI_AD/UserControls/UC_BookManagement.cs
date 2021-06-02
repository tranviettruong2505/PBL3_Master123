using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_BookShopManagement.GUI.Forms;
using PBL3_BookShopManagement.BLL;
using PBL3_BookShopManagement.DTO;

namespace PBL3_BookShopManagement.GUI.UserControls
{
    public partial class UC_BookManagement : UserControl
    {
        public UC_BookManagement()
        {
            InitializeComponent();

            Show("", "All", "All");

            //Tạo watermark cho txtSearch
            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Text = "Enter Name Book";
            txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            cbbLoaiSach.SelectedIndex = 0;
            cbbLinhVuc.SelectedIndex = 0;
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Enter Name Book";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Name Book")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        //Có trong bảng sách nhưng ko show ra do chưa có trong bảng Thông tin xuất bản
        public void Show(string name, string LinhVuc, string LoaiSach)
        {
            if (txtSearch.Text == "Enter Name Book")
            {
                dataGridView1.DataSource = BLL_Sach.Instance.getListSachView_BLL("", LinhVuc, LoaiSach);
            }
            else
            {
                dataGridView1.DataSource = BLL_Sach.Instance.getListSachView_BLL(name, LinhVuc, LoaiSach);
            }
            dataGridView1.Columns[0].HeaderText = "Book ID";
            dataGridView1.Columns[1].HeaderText = "Book Title";
            dataGridView1.Columns[2].HeaderText = "Cost Price";
            dataGridView1.Columns[3].HeaderText = "Kind of Book";
            dataGridView1.Columns[4].HeaderText = "Author";
            dataGridView1.Columns[5].HeaderText = "Category";
            dataGridView1.Columns[6].HeaderText = "Reprint";
            dataGridView1.Columns[7].HeaderText = "Publishing year";
            dataGridView1.Columns[8].HeaderText = "Publisher";
            dataGridView1.Columns[9].HeaderText = "Selling price";
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Show("", cbbLinhVuc.SelectedItem.ToString(), cbbLoaiSach.SelectedItem.ToString());
            //DAL.DAL_Sach.Instance.getListSachViewbyLoaiSach_DAL("", cbbLinhVuc.SelectedItem.ToString(), cbbLoaiSach.SelectedItem.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Show(txtSearch.Text, cbbLinhVuc.SelectedItem.ToString(), cbbLoaiSach.SelectedItem.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_BookDetail f = new Form_BookDetail(0);
            f.d += new Form_BookDetail.MyDel(Show);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int masach = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaSach"].Value.ToString());
                Form_BookDetail f = new Form_BookDetail(masach);
                f.d += new Form_BookDetail.MyDel(Show);
                f.Show();
            }
            else
            {
                MessageBox.Show("Select the row you want to update");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            List<int> lisMSDel = new List<int>();
            foreach(DataGridViewRow i in dataGridView1.SelectedRows)
            {
                lisMSDel.Add(Convert.ToInt32(i.Cells["MaSach"].Value));
            }
            BLL_Sach.Instance.DeleteSach_BLL(lisMSDel);
            Show(txtSearch.Text, cbbLinhVuc.SelectedItem.ToString(), cbbLoaiSach.SelectedItem.ToString());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex != -1)
            {
                List<SachView> dt = new List<SachView>();
                if (txtSearch.Text == "Enter Name Book")
                {
                    dt = BLL_Sach.Instance.getListSachView_BLL("", cbbLinhVuc.SelectedItem.ToString(), cbbLoaiSach.SelectedItem.ToString());
                }
                else
                {
                    dt = BLL_Sach.Instance.getListSachView_BLL(txtSearch.Text, cbbLinhVuc.SelectedItem.ToString(), cbbLoaiSach.SelectedItem.ToString());
                }
                string sortBy = cbbSort.SelectedItem.ToString();
                switch (sortBy)
                {
                    case "Book ID":
                        dataGridView1.DataSource = dt.OrderBy(o => o.MaSach).ToList();
                        break;
                    case "Title":
                        dataGridView1.DataSource = dt.OrderBy(o => o.TenSach).ToList();
                        break;
                    case "Selling Cost":
                        dataGridView1.DataSource = dt.OrderBy(o => o.GiaBia).ToList();
                        break;
                    case "Cost Price":
                        dataGridView1.DataSource = dt.OrderBy(o => o.GiaMua).ToList();
                        break;
                }
                dataGridView1.Columns[0].HeaderText = "Book ID";
                dataGridView1.Columns[1].HeaderText = "Book Title";
                dataGridView1.Columns[2].HeaderText = "Cost Price";
                dataGridView1.Columns[3].HeaderText = "Kind of Book";
                dataGridView1.Columns[4].HeaderText = "Author";
                dataGridView1.Columns[5].HeaderText = "Category";
                dataGridView1.Columns[6].HeaderText = "Reprint";
                dataGridView1.Columns[7].HeaderText = "Publishing year";
                dataGridView1.Columns[8].HeaderText = "Publisher";
                dataGridView1.Columns[9].HeaderText = "Selling price";
            }
            else
            {
                MessageBox.Show("select attribute to sort");
            }
        }
    }
}
