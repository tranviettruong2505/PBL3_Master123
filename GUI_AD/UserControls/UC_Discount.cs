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
using PBL3_BookShopManagement.DTO;

namespace PBL3_BookShopManagement.GUI.UserControls
{
    public partial class UC_Discount : UserControl
    {
        public UC_Discount()
        {
            InitializeComponent();

            Show("");

            //Hàm tạo watermark
            txtSearchName.ForeColor = Color.LightGray;
            txtSearchName.Text = "Enter Name Book";
            txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            txtSearchName.Enter += new System.EventHandler(this.txtSearchName_Enter);
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "")
            {
                txtSearchName.Text = "Enter Name Book";
                txtSearchName.ForeColor = Color.Gray;
            }
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "Enter Name Book")
            {
                txtSearchName.Text = "";
                txtSearchName.ForeColor = Color.Black;
            }
        }

        public void Show(string name)
        {
            dataGridView2.DataSource = BLL_SachKhuyenMai.Instance.getListSachKMView_BLL(name);
            dataGridView2.Columns[0].HeaderText = "Book ID";
            dataGridView2.Columns[1].HeaderText = "Titile";
            dataGridView2.Columns[2].HeaderText = "Cost before";
            dataGridView2.Columns[3].HeaderText = "Discount(%)";
            dataGridView2.Columns[4].HeaderText = "Cost after";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Show("");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SachKhuyenMai sachKhuyenMai = new SachKhuyenMai
            {
                MaSach = Convert.ToInt32(txtIDBook.Text),
                MucGiamGia = (float)Convert.ToDouble(txtDiscount.Text)
            };
            BLL_SachKhuyenMai.Instance.ExecuteSachKM_BLL(sachKhuyenMai);
            Show(txtSearchName.Text);
            ResetGUI();
        }

        public void ResetGUI()
        {
            txtIDBook.Text = "";
            txtBookTitle.Text = "";
            txtPrice.Text = "";
            txtPriceAfter.Text = "";
            txtDiscount.Text = "";
        }

        private void txtIDBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIDBook.Text != "")
                {
                    SachKMView sachKMView = BLL_SachKhuyenMai.Instance.GetSachKMViewByID_All_BLL(Convert.ToInt32(txtIDBook.Text));
                   // SachKMView sachKMView = BLL_SachKhuyenMai.Instance.GetSachKMViewByID_BLL(Convert.ToInt32(txtIDBook.Text));
                    txtBookTitle.Text = sachKMView.TenSach;
                    txtPrice.Text = string.Format("{0:#,##0.00}", sachKMView.GiaBia);
                }
                else
                {
                    ResetGUI();
                }
            }
            catch(Exception)
            {

            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtDiscount.Text != "")
                {
                    //txtPriceAfter.Text = (Convert.ToDouble(txtPrice.Text) * (1 - (Convert.ToDouble(txtDiscount.Text) / 100))).ToString();
                    txtPriceAfter.Text = string.Format("{0:#,##0.00}", Convert.ToDouble(txtPrice.Text) * (1 - (Convert.ToDouble(txtDiscount.Text) / 100)));
                }
                else
                {
                    txtPriceAfter.Text = "";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["MaSach"].Value);
                SachKMView sachKMView = BLL_SachKhuyenMai.Instance.GetSachKMViewByID_BLL(id);
                txtIDBook.Text = sachKMView.MaSach.ToString();
                txtIDBook.Enabled = false;
                txtBookTitle.Text = sachKMView.TenSach.ToString();
                txtPrice.Text = string.Format("{0:#,##0.00}", sachKMView.GiaBia);
                txtPriceAfter.Text = sachKMView.GiaSauKM.ToString();
                txtDiscount.Text = sachKMView.MucGiamGia.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                List<int> listMasachDel = new List<int>();
                foreach (DataGridViewRow i in dataGridView2.SelectedRows)
                {
                    listMasachDel.Add(Convert.ToInt32(i.Cells["MaSach"].Value));
                }
                BLL_SachKhuyenMai.Instance.DeleteSachKM_BLL(listMasachDel);
                Show(txtSearchName.Text);
            }
            else
            {
                MessageBox.Show("Select row to delete");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetGUI();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex != -1)
            {
                string sortBy = cbbSort.SelectedItem.ToString();
                List<SachKMView> dt = new List<SachKMView>();
                if (txtSearchName.Text == "Enter Name Book")
                {
                    dt = BLL_SachKhuyenMai.Instance.getListSachKMView_BLL("");
                }
                else
                {
                    dt = BLL_SachKhuyenMai.Instance.getListSachKMView_BLL(txtSearchName.Text);
                }
                switch (sortBy)
                {
                    case "Book ID":
                        dataGridView2.DataSource = dt.OrderBy(o => o.MaSach).ToList();
                        break;
                    case "Title":
                        dataGridView2.DataSource = dt.OrderBy(o => o.TenSach).ToList();
                        break;
                    case "Discount":
                        dataGridView2.DataSource = dt.OrderBy(o => o.MucGiamGia).ToList();
                        break;
                    case "Price Before Discount":
                        dataGridView2.DataSource = dt.OrderBy(o => o.GiaBia).ToList();
                        break;
                    case "Price After Discount":
                        dataGridView2.DataSource = dt.OrderBy(o => o.GiaSauKM).ToList();
                        break;
                }
                dataGridView2.Columns[0].HeaderText = "Book ID";
                dataGridView2.Columns[1].HeaderText = "Titile";
                dataGridView2.Columns[2].HeaderText = "Cost before";
                dataGridView2.Columns[3].HeaderText = "Discount(%)";
                dataGridView2.Columns[4].HeaderText = "Cost after";
            }
            else
            {
                MessageBox.Show("select attribute to sort");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchName.Text == "Enter Name Book")
            {
                dataGridView2.DataSource = BLL_SachKhuyenMai.Instance.getListSachKMView_BLL("");
            }
            else
            {
                dataGridView2.DataSource = BLL_SachKhuyenMai.Instance.getListSachKMView_BLL(txtSearchName.Text);
            }
        }
    }
}
