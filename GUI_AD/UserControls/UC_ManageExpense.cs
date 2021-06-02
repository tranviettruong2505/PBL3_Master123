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
    public partial class UC_ManageExpense : UserControl
    {
        public UC_ManageExpense()
        {
            InitializeComponent();
            SetGUI();
            ShowBaoCaoTH(dtpFrom.Value, dtpTo.Value);
            ////Tạo watermark cho txtIDBook
            //txtIDBook.ForeColor = Color.LightGray;
            //txtIDBook.Text = "Enter IDBook";
            //txtIDBook.Leave += new System.EventHandler(this.txtIDBook_Leave);
            //txtIDBook.Enter += new System.EventHandler(this.txtIDBook_Enter);

            ////Tạo watermark cho txtIDStaff
            //txtIDStaff.ForeColor = Color.LightGray;
            //txtIDStaff.Text = "Enter IDStaff";
            //txtIDStaff.Leave += new System.EventHandler(this.txtIDStaff_Leave);
            //txtIDStaff.Enter += new System.EventHandler(this.txtIDStaff_Enter);
        }

        //Tạo watermark cho txtIDBook
        //private void txtIDBook_Leave(object sender, EventArgs e)
        //{
        //    if(txtIDBook.Text == "")
        //    {
        //        txtIDBook.Text = "Enter IDBook";
        //        txtIDBook.ForeColor = Color.Gray;
        //    }
        //}

        //private void txtIDBook_Enter(object sender, EventArgs e)
        //{
        //    if(txtIDBook.Text == "Enter IDBook")
        //    {
        //        txtIDBook.Text = "";
        //        txtIDBook.ForeColor = Color.Black;
        //    }
        //}

        ////Tạo watermark cho txtIDStaff
        //private void txtIDStaff_Leave(object sender, EventArgs e)
        //{
        //    if (txtIDStaff.Text == "")
        //    {
        //        txtIDStaff.Text = "Enter IDStaff";
        //        txtIDStaff.ForeColor = Color.Gray;
        //    }
        //}

        //private void txtIDStaff_Enter(object sender, EventArgs e)
        //{
        //    if (txtIDStaff.Text == "Enter IDStaff")
        //    {
        //        txtIDStaff.Text = "";
        //        txtIDStaff.ForeColor = Color.Black;
        //    }
        //}
        public void SetGUI()
        {
            rbtnTongHop.Checked = true;
            txtSoSachMua.Text = BLL_ThongKe.Instance.GetSoLuongSachMua_BLL().ToString();
            txtChiPhi.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetChiPhi_BLL());

            dtpFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTo.Value = dtpFrom.Value.AddYears(1).AddDays(-1);
            SetChiPhi_TG();
        }

        public void ShowBaoCaoTH(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetNhatKiNhapKho_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "Number";
            dataGridView1.Columns[1].HeaderText = "ID Book";
            dataGridView1.Columns[2].HeaderText = "Title";
            dataGridView1.Columns[3].HeaderText = "Quantity";
            dataGridView1.Columns[4].HeaderText = "Amount of Money";
            dataGridView1.Columns[5].HeaderText = "Date(month/day/year)";
            dataGridView1.Columns[6].HeaderText = "ID Staff";
            dataGridView1.Columns[7].HeaderText = "Name Staff";
        }
        public void ShowTheoNV(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetChiPhiTheoNhanVien_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "ID Staff";
            dataGridView1.Columns[1].HeaderText = "Name Staff";
            dataGridView1.Columns[2].HeaderText = "Amount of book";
            dataGridView1.Columns[3].HeaderText = "Amount of money";
        }
        public void ShowTheoSach(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetChiPhiTheoTenSach_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "ID Book";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Amount of book";
            dataGridView1.Columns[3].HeaderText = "Amount of money";
        }
        public void ShowTheoLoaiSach(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetChiPhiTheoLoaiSach_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "Kind of book";
            dataGridView1.Columns[1].HeaderText = "Amount of book";
            dataGridView1.Columns[2].HeaderText = "Amount of money";
        }
        public void ShowTheoLinhVuc(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetChiPhiTheoLinhVuc_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "Category";
            dataGridView1.Columns[1].HeaderText = "Amount of book";
            dataGridView1.Columns[2].HeaderText = "Amount of money";
        }
        private void rbtnTongHop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnThuKho_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnThuKho.Checked)
            {
                ShowTheoNV(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnTheoSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTheoSach.Checked) 
            {
                ShowTheoSach(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnTheoLoaiSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTheoLoaiSach.Checked)
            {
                ShowTheoLoaiSach(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnTheoLinhVuc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTheoLinhVuc.Checked)
            {
                ShowTheoLinhVuc(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFrom.Value;
            DateTime dateTo = dtpTo.Value;
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dateFrom, dateTo);
            }
            else
            {
                if (rbtnThuKho.Checked)
                {
                    ShowTheoNV(dateFrom, dateTo);
                }
                else
                {
                    if (rbtnTheoSach.Checked)
                    {
                        ShowTheoSach(dateFrom, dateTo);
                    }
                    else
                    {
                        if (rbtnTheoLoaiSach.Checked)
                        {
                            ShowTheoLoaiSach(dateFrom, dateTo);
                        }
                        else
                        {
                            ShowTheoLinhVuc(dateFrom, dateTo);
                        }
                    }
                }
            }
            SetChiPhi_TG();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFrom.Value;
            DateTime dateTo = dtpTo.Value;
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dateFrom, dateTo);
            }
            else
            {
                if (rbtnThuKho.Checked)
                {
                    ShowTheoNV(dateFrom, dateTo);
                }
                else
                {
                    if (rbtnTheoSach.Checked)
                    {
                        ShowTheoSach(dateFrom, dateTo);
                    }
                    else
                    {
                        if (rbtnTheoLoaiSach.Checked)
                        {
                            ShowTheoLoaiSach(dateFrom, dateTo);
                        }
                        else
                        {
                            ShowTheoLinhVuc(dateFrom, dateTo);
                        }
                    }
                }
            }
            SetChiPhi_TG();
        }

        private void SetChiPhi_TG()
        {
            txtSachMua_TG.Text = BLL_ThongKe.Instance.GetSoSachMua_TG_BLL(dtpFrom.Value, dtpTo.Value).ToString();
            txtChiPhi_TG.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetTongTienMua_TG_BLL(dtpFrom.Value, dtpTo.Value));
        }
    }
}
