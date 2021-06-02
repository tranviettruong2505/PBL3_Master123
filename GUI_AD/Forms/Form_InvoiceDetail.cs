using PBL3_BookShopManagement.BLL;
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
    public partial class Form_InvoiceDetail : Form
    {
        public int MaHD { get; set; }
        public Form_InvoiceDetail(int s)
        {
            InitializeComponent();
            MaHD = s;
            SetGUI();
        }
        private void SetGUI()
        {
            
            if (BLL_ThongKe.Instance.GetChiTietHoaDonbyMaHD_BLL(MaHD) != null)
            {
                dataGridView1.DataSource = BLL_ThongKe.Instance.GetChiTietHoaDonbyMaHD_BLL(MaHD);
                txtMaHoaDon.Text = MaHD.ToString();
                DataTable dt = BLL_ThongKe.Instance.GetHoaDonbyMaHD_BLL(MaHD);
                foreach(DataRow i in dt.Rows)
                {
                    txtTenKhachHang.Text = i["TenKhachHang"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(i["NgayLap"]);
                    txtTongTien.Text = string.Format("{0:#,##0.00}", i["TongTien"]);
                    txtMaNV.Text = i["ID_Staff"].ToString();
                    txtTenNV.Text = i["Name_Staff"].ToString();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
