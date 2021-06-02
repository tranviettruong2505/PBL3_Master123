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
using PBL3_BookShopManagement.GUI.Forms;

namespace PBL3_BookShopManagement.GUI.UserControls
{
    public partial class UC_ManageRevenue : UserControl
    {
        public UC_ManageRevenue()
        {
            InitializeComponent();
            SetGUI();
            ShowBaoCaoTH(dtpFrom.Value, dtpTo.Value);
        }

        //Tạo watermark cho txtIDBook
        //private void txtIDBook_Leave(object sender, EventArgs e)
        //{
        //    if(txtIDHoaDon.Text == "")
        //    {
        //        txtIDHoaDon.Text = "Enter IDInvoice";
        //        txtIDHoaDon.ForeColor = Color.Gray;
        //    }
        //}

        //private void txtIDBook_Enter(object sender, EventArgs e)
        //{
        //    if(txtIDHoaDon.Text == "Enter IDInvoice")
        //    {
        //        txtIDHoaDon.Text = "";
        //        txtIDHoaDon.ForeColor = Color.Black;
        //    }
        //}

        //Tạo watermark cho txtIDStaff
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
            txtSoHoaDon.Text = BLL_ThongKe.Instance.GetSoLuongHoaDon_BLL().ToString();
            txtDoanhThu.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetDoanhThu_BLL());
            txtSoSachBan.Text = BLL_ThongKe.Instance.GetSoLuongSachBan_BLL().ToString();

            dtpFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTo.Value = dtpFrom.Value.AddYears(1).AddDays(-1);
            SetDoanhThu_TG();
        }

        public void ShowBaoCaoTH(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetHoaDon_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "ID Invoice";
            dataGridView1.Columns[1].HeaderText = "Name Customer";
            dataGridView1.Columns[2].HeaderText = "Date(month/day/year)";
            dataGridView1.Columns[3].HeaderText = "Total";
            dataGridView1.Columns[4].HeaderText = "ID Staff";
            dataGridView1.Columns[5].HeaderText = "Name Staff";
        }

        public void ShowTheoNV(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetDoanhThuTheoNhanVien_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "ID Staff";
            dataGridView1.Columns[1].HeaderText = "Name Staff";
            dataGridView1.Columns[2].HeaderText = "Amount of book";
            dataGridView1.Columns[3].HeaderText = "Amount of money";
        }

        public void ShowTheoSach(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetDoanhThuTheoTenSach_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "ID Book";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Amount of book";
            dataGridView1.Columns[3].HeaderText = "Amount of money";
        }

        public void ShowTheoLoaiSach(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetDoanhThuTheoLoaiSach_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "Kind of book";
            dataGridView1.Columns[1].HeaderText = "Amount of book";
            dataGridView1.Columns[2].HeaderText = "Amount of money";
        }

        public void ShowTheoLinhVuc(DateTime dateFrom, DateTime dateTo)
        {
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetDoanhThuTheoLinhVuc_BLL(dateFrom, dateTo);
            dataGridView1.Columns[0].HeaderText = "Category";
            dataGridView1.Columns[1].HeaderText = "Amount of book";
            dataGridView1.Columns[2].HeaderText = "Amount of money";
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFrom.Value;
            DateTime dateTo = dtpTo.Value;
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dateFrom, dateTo);
            }
            else
            {
                if (rbtnNhanVien.Checked)
                {
                    ShowTheoNV(dateFrom, dateTo);
                }
                else
                {
                    if (rbtnSach.Checked)
                    {
                        ShowTheoSach(dateFrom, dateTo);
                    }
                    else
                    {
                        if (rbtnLoaiSach.Checked)
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
        }

        private void rbtnTongHop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNhanVien.Checked)
            {
                ShowTheoNV(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSach.Checked)
            {
                ShowTheoSach(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnLoaiSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLoaiSach.Checked)
            {
                ShowTheoLoaiSach(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void rbtnLinhVuc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLinhVuc.Checked)
            {
                ShowTheoLinhVuc(dtpFrom.Value, dtpTo.Value);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dtpFrom.Value, dtpTo.Value);
            }
            else
            {
                if (rbtnNhanVien.Checked)
                {
                    ShowTheoNV(dtpFrom.Value, dtpTo.Value);
                }
                else
                {
                    if (rbtnSach.Checked)
                    {
                        ShowTheoSach(dtpFrom.Value, dtpTo.Value);
                    }
                    else
                    {
                        if (rbtnLoaiSach.Checked)
                        {
                            ShowTheoLoaiSach(dtpFrom.Value, dtpTo.Value);
                        }
                        else
                        {
                            ShowTheoLinhVuc(dtpFrom.Value, dtpTo.Value);
                        }
                    }
                }
            }
            SetDoanhThu_TG();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (rbtnTongHop.Checked)
            {
                ShowBaoCaoTH(dtpFrom.Value, dtpTo.Value);
            }
            else
            {
                if (rbtnNhanVien.Checked)
                {
                    ShowTheoNV(dtpFrom.Value, dtpTo.Value);
                }
                else
                {
                    if (rbtnSach.Checked)
                    {
                        ShowTheoSach(dtpFrom.Value, dtpTo.Value);
                    }
                    else
                    {
                        if (rbtnLoaiSach.Checked)
                        {
                            ShowTheoLoaiSach(dtpFrom.Value, dtpTo.Value);
                        }
                        else
                        {
                            ShowTheoLinhVuc(dtpFrom.Value, dtpTo.Value);
                        }
                    }
                }
            }
            SetDoanhThu_TG();
        }

        private void SetDoanhThu_TG()
        {
            txtSachBan_TG.Text = BLL_ThongKe.Instance.GetSoSachBan_TG_BLL(dtpFrom.Value, dtpTo.Value).ToString();
            txtDoanhThu_TG.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetTongTienBan_TG_BLL(dtpFrom.Value, dtpTo.Value));
            txtHoaDon_TG.Text = BLL_ThongKe.Instance.GetSoHoaDon_TG_BLL(dtpFrom.Value, dtpTo.Value).ToString();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count > 0) && (rbtnTongHop.Checked))
            {
                int MaHD = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaHoaDon"].Value);
                Form_InvoiceDetail f = new Form_InvoiceDetail(MaHD);
                f.Show();
            }
            else
            {
                MessageBox.Show("Select the row you want to see invoice details");
            }
        }
    }
}
