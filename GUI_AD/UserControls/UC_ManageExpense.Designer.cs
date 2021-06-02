namespace PBL3_BookShopManagement.GUI.UserControls
{
    partial class UC_ManageExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ManageExpense));
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbtnTheoLinhVuc = new System.Windows.Forms.RadioButton();
            this.rbtnTheoLoaiSach = new System.Windows.Forms.RadioButton();
            this.rbtnTheoSach = new System.Windows.Forms.RadioButton();
            this.rbtnThuKho = new System.Windows.Forms.RadioButton();
            this.rbtnTongHop = new System.Windows.Forms.RadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSoSachMua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSachMua_TG = new System.Windows.Forms.TextBox();
            this.txtChiPhi_TG = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.rbtnTheoLinhVuc);
            this.panel5.Controls.Add(this.rbtnTheoLoaiSach);
            this.panel5.Controls.Add(this.rbtnTheoSach);
            this.panel5.Controls.Add(this.rbtnThuKho);
            this.panel5.Controls.Add(this.rbtnTongHop);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1309, 46);
            this.panel5.TabIndex = 9;
            // 
            // rbtnTheoLinhVuc
            // 
            this.rbtnTheoLinhVuc.AutoSize = true;
            this.rbtnTheoLinhVuc.ForeColor = System.Drawing.Color.White;
            this.rbtnTheoLinhVuc.Location = new System.Drawing.Point(689, 13);
            this.rbtnTheoLinhVuc.Name = "rbtnTheoLinhVuc";
            this.rbtnTheoLinhVuc.Size = new System.Drawing.Size(158, 27);
            this.rbtnTheoLinhVuc.TabIndex = 19;
            this.rbtnTheoLinhVuc.TabStop = true;
            this.rbtnTheoLinhVuc.Text = "Theo lĩnh vực";
            this.rbtnTheoLinhVuc.UseVisualStyleBackColor = true;
            this.rbtnTheoLinhVuc.CheckedChanged += new System.EventHandler(this.rbtnTheoLinhVuc_CheckedChanged);
            // 
            // rbtnTheoLoaiSach
            // 
            this.rbtnTheoLoaiSach.AutoSize = true;
            this.rbtnTheoLoaiSach.ForeColor = System.Drawing.Color.White;
            this.rbtnTheoLoaiSach.Location = new System.Drawing.Point(512, 13);
            this.rbtnTheoLoaiSach.Name = "rbtnTheoLoaiSach";
            this.rbtnTheoLoaiSach.Size = new System.Drawing.Size(171, 27);
            this.rbtnTheoLoaiSach.TabIndex = 18;
            this.rbtnTheoLoaiSach.TabStop = true;
            this.rbtnTheoLoaiSach.Text = "Theo loai sach";
            this.rbtnTheoLoaiSach.UseVisualStyleBackColor = true;
            this.rbtnTheoLoaiSach.CheckedChanged += new System.EventHandler(this.rbtnTheoLoaiSach_CheckedChanged);
            // 
            // rbtnTheoSach
            // 
            this.rbtnTheoSach.AutoSize = true;
            this.rbtnTheoSach.ForeColor = System.Drawing.Color.White;
            this.rbtnTheoSach.Location = new System.Drawing.Point(376, 13);
            this.rbtnTheoSach.Name = "rbtnTheoSach";
            this.rbtnTheoSach.Size = new System.Drawing.Size(130, 27);
            this.rbtnTheoSach.TabIndex = 17;
            this.rbtnTheoSach.TabStop = true;
            this.rbtnTheoSach.Text = "Theo sách";
            this.rbtnTheoSach.UseVisualStyleBackColor = true;
            this.rbtnTheoSach.CheckedChanged += new System.EventHandler(this.rbtnTheoSach_CheckedChanged);
            // 
            // rbtnThuKho
            // 
            this.rbtnThuKho.AutoSize = true;
            this.rbtnThuKho.ForeColor = System.Drawing.Color.White;
            this.rbtnThuKho.Location = new System.Drawing.Point(221, 13);
            this.rbtnThuKho.Name = "rbtnThuKho";
            this.rbtnThuKho.Size = new System.Drawing.Size(152, 27);
            this.rbtnThuKho.TabIndex = 16;
            this.rbtnThuKho.TabStop = true;
            this.rbtnThuKho.Text = "Theo thủ kho";
            this.rbtnThuKho.UseVisualStyleBackColor = true;
            this.rbtnThuKho.CheckedChanged += new System.EventHandler(this.rbtnThuKho_CheckedChanged);
            // 
            // rbtnTongHop
            // 
            this.rbtnTongHop.AutoSize = true;
            this.rbtnTongHop.ForeColor = System.Drawing.Color.White;
            this.rbtnTongHop.Location = new System.Drawing.Point(9, 13);
            this.rbtnTongHop.Name = "rbtnTongHop";
            this.rbtnTongHop.Size = new System.Drawing.Size(203, 27);
            this.rbtnTongHop.TabIndex = 15;
            this.rbtnTongHop.TabStop = true;
            this.rbtnTongHop.Text = "Báo cáo tổng hợp";
            this.rbtnTongHop.UseVisualStyleBackColor = true;
            this.rbtnTongHop.CheckedChanged += new System.EventHandler(this.rbtnTongHop_CheckedChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(211, 52);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(364, 32);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(618, 52);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(367, 32);
            this.dtpTo.TabIndex = 11;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSoSachMua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(236, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 95);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtSoSachMua
            // 
            this.txtSoSachMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSoSachMua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoSachMua.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSachMua.ForeColor = System.Drawing.Color.White;
            this.txtSoSachMua.Location = new System.Drawing.Point(158, 48);
            this.txtSoSachMua.Name = "txtSoSachMua";
            this.txtSoSachMua.Size = new System.Drawing.Size(100, 29);
            this.txtSoSachMua.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Purchased Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txtChiPhi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(689, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 95);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.BackColor = System.Drawing.Color.Teal;
            this.txtChiPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChiPhi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhi.ForeColor = System.Drawing.Color.White;
            this.txtChiPhi.Location = new System.Drawing.Point(86, 48);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(202, 29);
            this.txtChiPhi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Expense";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 384);
            this.dataGridView1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số sách mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chi phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thống kê theo khoảng thời gian";
            // 
            // txtSachMua_TG
            // 
            this.txtSachMua_TG.Location = new System.Drawing.Point(180, 619);
            this.txtSachMua_TG.Name = "txtSachMua_TG";
            this.txtSachMua_TG.Size = new System.Drawing.Size(343, 32);
            this.txtSachMua_TG.TabIndex = 19;
            // 
            // txtChiPhi_TG
            // 
            this.txtChiPhi_TG.Location = new System.Drawing.Point(180, 657);
            this.txtChiPhi_TG.Name = "txtChiPhi_TG";
            this.txtChiPhi_TG.Size = new System.Drawing.Size(343, 32);
            this.txtChiPhi_TG.TabIndex = 20;
            // 
            // UC_ManageExpense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtChiPhi_TG);
            this.Controls.Add(this.txtSachMua_TG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ManageExpense";
            this.Size = new System.Drawing.Size(1309, 697);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbtnTongHop;
        private System.Windows.Forms.RadioButton rbtnTheoLoaiSach;
        private System.Windows.Forms.RadioButton rbtnTheoSach;
        private System.Windows.Forms.RadioButton rbtnThuKho;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTheoLinhVuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoSachMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSachMua_TG;
        private System.Windows.Forms.TextBox txtChiPhi_TG;
    }
}
