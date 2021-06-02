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
    public partial class UC_ManageProfit : UserControl
    {
        public UC_ManageProfit()
        {
            InitializeComponent();
            SetGUI();
        }
        
        private void SetGUI()
        {
            txtVon.Text = string.Format("{0:#,##0.00}", 100000000);
            txtDoanhThu.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetDoanhThu_BLL());
            txtChiPhi.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetChiPhi_BLL());
            txtLai.Text = string.Format("{0:#,##0.00}", BLL_ThongKe.Instance.GetDoanhThu_BLL() - BLL_ThongKe.Instance.GetChiPhi_BLL() - 100000000);
        }
    }
}
