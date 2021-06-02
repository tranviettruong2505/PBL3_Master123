//Sửa lại tiêu đề mấy column trong datagridview
//Tìm kiếm gần đúng
//Sửa lại mấy cái icon

using PBL3_BookShopManagement.GUI.UserControls;
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
    public partial class Form_Dashboard_Admin : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Form_Dashboard_Admin()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBookManagement);
            UC_BookManagement us = new UC_BookManagement();
            AddControlsToPanel(us);
        }
        private void btnViewSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnViewSales);
            UC_ManageProfit vs = new UC_ManageProfit();
            AddControlsToPanel(vs);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDoanhThu);
            UC_ManageRevenue ea = new UC_ManageRevenue();
            AddControlsToPanel(ea);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_ManageUser us = new UC_ManageUser();
            AddControlsToPanel(us);
        }

        private void btnChiPhi_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnChiPhi);
            UC_ManageExpense ea = new UC_ManageExpense();
            AddControlsToPanel(ea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDiscount);
            UC_Discount ea = new UC_Discount();
            AddControlsToPanel(ea);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnWarehouse);
            UC_ManageKho ea = new UC_ManageKho();
            AddControlsToPanel(ea);
        }
    }
}
