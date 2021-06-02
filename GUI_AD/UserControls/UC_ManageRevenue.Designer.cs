namespace PBL3_BookShopManagement.GUI.UserControls
{
    partial class UC_ManageRevenue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ManageRevenue));
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbtnLinhVuc = new System.Windows.Forms.RadioButton();
            this.rbtnLoaiSach = new System.Windows.Forms.RadioButton();
            this.rbtnSach = new System.Windows.Forms.RadioButton();
            this.rbtnNhanVien = new System.Windows.Forms.RadioButton();
            this.rbtnTongHop = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoSachBan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSachBan_TG = new System.Windows.Forms.TextBox();
            this.txtDoanhThu_TG = new System.Windows.Forms.TextBox();
            this.txtHoaDon_TG = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.rbtnLinhVuc);
            this.panel5.Controls.Add(this.rbtnLoaiSach);
            this.panel5.Controls.Add(this.rbtnSach);
            this.panel5.Controls.Add(this.rbtnNhanVien);
            this.panel5.Controls.Add(this.rbtnTongHop);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1319, 49);
            this.panel5.TabIndex = 9;
            // 
            // rbtnLinhVuc
            // 
            this.rbtnLinhVuc.AutoSize = true;
            this.rbtnLinhVuc.ForeColor = System.Drawing.Color.White;
            this.rbtnLinhVuc.Location = new System.Drawing.Point(983, 11);
            this.rbtnLinhVuc.Name = "rbtnLinhVuc";
            this.rbtnLinhVuc.Size = new System.Drawing.Size(158, 27);
            this.rbtnLinhVuc.TabIndex = 19;
            this.rbtnLinhVuc.TabStop = true;
            this.rbtnLinhVuc.Text = "Theo lĩnh vực";
            this.rbtnLinhVuc.UseVisualStyleBackColor = true;
            this.rbtnLinhVuc.CheckedChanged += new System.EventHandler(this.rbtnLinhVuc_CheckedChanged);
            // 
            // rbtnLoaiSach
            // 
            this.rbtnLoaiSach.AutoSize = true;
            this.rbtnLoaiSach.ForeColor = System.Drawing.Color.White;
            this.rbtnLoaiSach.Location = new System.Drawing.Point(784, 11);
            this.rbtnLoaiSach.Name = "rbtnLoaiSach";
            this.rbtnLoaiSach.Size = new System.Drawing.Size(166, 27);
            this.rbtnLoaiSach.TabIndex = 18;
            this.rbtnLoaiSach.TabStop = true;
            this.rbtnLoaiSach.Text = "Theo loại sách";
            this.rbtnLoaiSach.UseVisualStyleBackColor = true;
            this.rbtnLoaiSach.CheckedChanged += new System.EventHandler(this.rbtnLoaiSach_CheckedChanged);
            // 
            // rbtnSach
            // 
            this.rbtnSach.AutoSize = true;
            this.rbtnSach.ForeColor = System.Drawing.Color.White;
            this.rbtnSach.Location = new System.Drawing.Point(577, 11);
            this.rbtnSach.Name = "rbtnSach";
            this.rbtnSach.Size = new System.Drawing.Size(132, 27);
            this.rbtnSach.TabIndex = 17;
            this.rbtnSach.TabStop = true;
            this.rbtnSach.Text = "Theo Sách";
            this.rbtnSach.UseVisualStyleBackColor = true;
            this.rbtnSach.CheckedChanged += new System.EventHandler(this.rbtnSach_CheckedChanged);
            // 
            // rbtnNhanVien
            // 
            this.rbtnNhanVien.AutoSize = true;
            this.rbtnNhanVien.ForeColor = System.Drawing.Color.White;
            this.rbtnNhanVien.Location = new System.Drawing.Point(270, 11);
            this.rbtnNhanVien.Name = "rbtnNhanVien";
            this.rbtnNhanVien.Size = new System.Drawing.Size(283, 27);
            this.rbtnNhanVien.TabIndex = 16;
            this.rbtnNhanVien.TabStop = true;
            this.rbtnNhanVien.Text = "Theo nhân viên bán hàng";
            this.rbtnNhanVien.UseVisualStyleBackColor = true;
            this.rbtnNhanVien.CheckedChanged += new System.EventHandler(this.rbtnNhanVien_CheckedChanged);
            // 
            // rbtnTongHop
            // 
            this.rbtnTongHop.AutoSize = true;
            this.rbtnTongHop.ForeColor = System.Drawing.Color.White;
            this.rbtnTongHop.Location = new System.Drawing.Point(40, 11);
            this.rbtnTongHop.Name = "rbtnTongHop";
            this.rbtnTongHop.Size = new System.Drawing.Size(203, 27);
            this.rbtnTongHop.TabIndex = 15;
            this.rbtnTongHop.TabStop = true;
            this.rbtnTongHop.Text = "Báo cáo tổng hợp";
            this.rbtnTongHop.UseVisualStyleBackColor = true;
            this.rbtnTongHop.CheckedChanged += new System.EventHandler(this.rbtnTongHop_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "to";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(416, 55);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(345, 32);
            this.dtpTo.TabIndex = 12;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(35, 59);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(339, 32);
            this.dtpFrom.TabIndex = 11;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 350);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.txtSoSachBan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 89);
            this.panel1.TabIndex = 18;
            // 
            // txtSoSachBan
            // 
            this.txtSoSachBan.BackColor = System.Drawing.Color.Green;
            this.txtSoSachBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoSachBan.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSachBan.ForeColor = System.Drawing.Color.White;
            this.txtSoSachBan.Location = new System.Drawing.Point(124, 47);
            this.txtSoSachBan.Name = "txtSoSachBan";
            this.txtSoSachBan.Size = new System.Drawing.Size(143, 29);
            this.txtSoSachBan.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total sold books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtDoanhThu);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(509, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 89);
            this.panel2.TabIndex = 19;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.BackColor = System.Drawing.Color.Red;
            this.txtDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoanhThu.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txtDoanhThu.ForeColor = System.Drawing.Color.White;
            this.txtDoanhThu.Location = new System.Drawing.Point(91, 47);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(200, 29);
            this.txtDoanhThu.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total revenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.txtSoHoaDon);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(983, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 89);
            this.panel3.TabIndex = 20;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.BackColor = System.Drawing.Color.Blue;
            this.txtSoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoHoaDon.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txtSoHoaDon.ForeColor = System.Drawing.Color.White;
            this.txtSoHoaDon.Location = new System.Drawing.Point(124, 47);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(143, 29);
            this.txtSoHoaDon.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total invoice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(18, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Thống kê theo khoảng thời gian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(18, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sách đã bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(18, 646);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Doanh thu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(18, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số hóa đơn";
            // 
            // txtSachBan_TG
            // 
            this.txtSachBan_TG.Location = new System.Drawing.Point(164, 602);
            this.txtSachBan_TG.Name = "txtSachBan_TG";
            this.txtSachBan_TG.Size = new System.Drawing.Size(412, 32);
            this.txtSachBan_TG.TabIndex = 26;
            // 
            // txtDoanhThu_TG
            // 
            this.txtDoanhThu_TG.Location = new System.Drawing.Point(164, 643);
            this.txtDoanhThu_TG.Name = "txtDoanhThu_TG";
            this.txtDoanhThu_TG.Size = new System.Drawing.Size(412, 32);
            this.txtDoanhThu_TG.TabIndex = 27;
            // 
            // txtHoaDon_TG
            // 
            this.txtHoaDon_TG.Location = new System.Drawing.Point(164, 681);
            this.txtHoaDon_TG.Name = "txtHoaDon_TG";
            this.txtHoaDon_TG.Size = new System.Drawing.Size(412, 32);
            this.txtHoaDon_TG.TabIndex = 28;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(1094, 564);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(209, 49);
            this.btnDetail.TabIndex = 29;
            this.btnDetail.Text = "View invoice detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // UC_ManageRevenue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.txtHoaDon_TG);
            this.Controls.Add(this.txtDoanhThu_TG);
            this.Controls.Add(this.txtSachBan_TG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ManageRevenue";
            this.Size = new System.Drawing.Size(1319, 724);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnLinhVuc;
        private System.Windows.Forms.RadioButton rbtnLoaiSach;
        private System.Windows.Forms.RadioButton rbtnSach;
        private System.Windows.Forms.RadioButton rbtnNhanVien;
        private System.Windows.Forms.RadioButton rbtnTongHop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSoSachBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSachBan_TG;
        private System.Windows.Forms.TextBox txtDoanhThu_TG;
        private System.Windows.Forms.TextBox txtHoaDon_TG;
        private System.Windows.Forms.Button btnDetail;
    }
}
