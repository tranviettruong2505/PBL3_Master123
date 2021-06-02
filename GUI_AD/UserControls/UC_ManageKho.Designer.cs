namespace PBL3_BookShopManagement.GUI.UserControls
{
    partial class UC_ManageKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ManageKho));
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbtnTheoLinhVuc = new System.Windows.Forms.RadioButton();
            this.rbtnTheoLoaiSach = new System.Windows.Forms.RadioButton();
            this.rbtnTheoSach = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTongSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSachCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.rbtnTheoLoaiSach.Location = new System.Drawing.Point(337, 13);
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
            this.rbtnTheoSach.Location = new System.Drawing.Point(35, 13);
            this.rbtnTheoSach.Name = "rbtnTheoSach";
            this.rbtnTheoSach.Size = new System.Drawing.Size(130, 27);
            this.rbtnTheoSach.TabIndex = 17;
            this.rbtnTheoSach.TabStop = true;
            this.rbtnTheoSach.Text = "Theo sách";
            this.rbtnTheoSach.UseVisualStyleBackColor = true;
            this.rbtnTheoSach.CheckedChanged += new System.EventHandler(this.rbtnTheoSach_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTongSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(236, 52);
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
            // txtTongSach
            // 
            this.txtTongSach.BackColor = System.Drawing.Color.IndianRed;
            this.txtTongSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongSach.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSach.ForeColor = System.Drawing.Color.White;
            this.txtTongSach.Location = new System.Drawing.Point(93, 48);
            this.txtTongSach.Name = "txtTongSach";
            this.txtTongSach.Size = new System.Drawing.Size(164, 29);
            this.txtTongSach.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng số sách đã mua";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txtSachCon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(689, 52);
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
            // txtSachCon
            // 
            this.txtSachCon.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtSachCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSachCon.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSachCon.ForeColor = System.Drawing.Color.White;
            this.txtSachCon.Location = new System.Drawing.Point(92, 48);
            this.txtSachCon.Name = "txtSachCon";
            this.txtSachCon.Size = new System.Drawing.Size(186, 29);
            this.txtSachCon.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng sách còn trong kho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 529);
            this.dataGridView1.TabIndex = 15;
            // 
            // UC_ManageKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ManageKho";
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

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbtnTheoLoaiSach;
        private System.Windows.Forms.RadioButton rbtnTheoSach;
        private System.Windows.Forms.RadioButton rbtnTheoLinhVuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSachCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
