using PBL3_BookShopManagement.BLL;
using PBL3_BookShopManagement.DAL;
using PBL3_BookShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_BookShopManagement.GUI.Forms
{
    public partial class Form_BookDetail : Form
    {
        public delegate void MyDel(string name, string LinhVuc, string LoaiSach);
        public MyDel d { get; set; }
        public int masach { get; set; }
            //get { return -1; }
            //set { } }
        public Form_BookDetail(int s)
        {
            InitializeComponent();
            masach = s;
            SetGUI();

        }
        public void SetGUI()
        {
            numNamXuatBan.Maximum = DateTime.Now.Year;
            numGiaMua.Maximum = int.MaxValue;
            numGiaBan.Maximum = int.MaxValue;
            if (masach != 0)
            {
                SachView sach = BLL_Sach.Instance.GetSachViewByMaSach(masach);
                txtBookID.Text = sach.MaSach.ToString();
                txtTenSach.Text = sach.TenSach.ToString();
                cbbLinhVuc.SelectedIndex = cbbLinhVuc.Items.IndexOf(sach.TenLinhVuc);
                cbbLoaiSach.SelectedIndex = cbbLoaiSach.Items.IndexOf(sach.TenLoaiSach);
                txtTacGia.Text = sach.TenTacGia;
                txtNXB.Text = sach.NhaXuatBan;
                numLanTaiBan.Value = Convert.ToInt32(sach.LanTaiBan);
                numNamXuatBan.Value = Convert.ToInt32(sach.NamXuatBan);
                numGiaBan.Value = sach.GiaBia;
                numGiaMua.Value = sach.GiaMua;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Sach GetSach()
        {
            try
            {
                Sach sach = new Sach();
                if (txtBookID.Text != "")
                {
                    sach.MaSach = Convert.ToInt32(txtBookID.Text.ToString());
                }
                sach.TenSach = txtTenSach.Text;
                sach.GiaMua = Convert.ToInt32(numGiaMua.Value);
                sach.TenLoaiSach = cbbLoaiSach.SelectedItem.ToString();
                sach.TenTacGia = txtTacGia.Text;
                sach.TenLinhVuc = cbbLinhVuc.SelectedItem.ToString();
                return sach;
            }
            catch(Exception e)
            {
                MessageBox.Show("entered wrong format");
                return null;
            }
        }
        private ThongTinXuatBan GetThongTinXuatBan()
        {
            try
            {
                ThongTinXuatBan thongTin = new ThongTinXuatBan();
                if (txtBookID.Text != "")
                {
                    thongTin.MaSach = Convert.ToInt32(txtBookID.Text);
                }
                thongTin.LanTaiBan = numLanTaiBan.Value.ToString();
                thongTin.NamXuatBan = numNamXuatBan.Value.ToString();
                thongTin.NhaXuatBan = txtNXB.Text;
                thongTin.GiaBia = Convert.ToInt32(numGiaBan.Value);
                return thongTin;
            }
            catch
            {
                MessageBox.Show("entered wrong format");
                return null;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtTenSach.Text == null) || (cbbLinhVuc.SelectedIndex == -1) || (cbbLoaiSach.SelectedIndex == -1) || 
                (txtTacGia.Text == null) || (txtNXB.Text == null))
            {
                MessageBox.Show("Enter complete information");
            }
            else
            {
                if ((GetSach() != null) && (GetThongTinXuatBan() != null))
                {
                    BLL_Sach.Instance.ExecuteSach(GetSach(), GetThongTinXuatBan());
                    d("", "All", "All");
                    this.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtNXB.Text = "";
            txtTacGia.Text = "";
            txtTenSach.Text= "";
            cbbLinhVuc.SelectedIndex = -1;
            cbbLoaiSach.SelectedIndex = -1;
            numGiaBan.Value = numGiaBan.Minimum;
            numGiaMua.Value = numGiaMua.Minimum;
            numLanTaiBan.Value = numLanTaiBan.Minimum;
            numNamXuatBan.Value = numNamXuatBan.Minimum;
        }
    }
}
