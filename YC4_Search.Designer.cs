namespace QLTiecCuoi
{
    partial class YC4_Search
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YC4_Search));
            this.datagv_hoadon = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTiecCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboboxNgay = new System.Windows.Forms.ComboBox();
            this.comboboxThang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btVeTrangChu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagv_hoadon
            // 
            this.datagv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaTiecCuoi,
            this.NgayThanhToan,
            this.TongTienBan,
            this.TongTienDichVu,
            this.TongTienHoaDon,
            this.ConLai});
            this.datagv_hoadon.Location = new System.Drawing.Point(14, 180);
            this.datagv_hoadon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.datagv_hoadon.Name = "datagv_hoadon";
            this.datagv_hoadon.RowHeadersWidth = 51;
            this.datagv_hoadon.RowTemplate.Height = 24;
            this.datagv_hoadon.Size = new System.Drawing.Size(990, 289);
            this.datagv_hoadon.TabIndex = 2;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "SoHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Width = 125;
            // 
            // MaTiecCuoi
            // 
            this.MaTiecCuoi.DataPropertyName = "MaTiecCuoi";
            this.MaTiecCuoi.HeaderText = "Mã Tiệc Cưới";
            this.MaTiecCuoi.MinimumWidth = 6;
            this.MaTiecCuoi.Name = "MaTiecCuoi";
            this.MaTiecCuoi.ReadOnly = true;
            this.MaTiecCuoi.Width = 125;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.DataPropertyName = "NgayThanhToan";
            this.NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.NgayThanhToan.MinimumWidth = 6;
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.ReadOnly = true;
            this.NgayThanhToan.Width = 125;
            // 
            // TongTienBan
            // 
            this.TongTienBan.DataPropertyName = "TongTienBan";
            this.TongTienBan.HeaderText = "Tổng Tiền Bàn";
            this.TongTienBan.MinimumWidth = 6;
            this.TongTienBan.Name = "TongTienBan";
            this.TongTienBan.ReadOnly = true;
            this.TongTienBan.Width = 125;
            // 
            // TongTienDichVu
            // 
            this.TongTienDichVu.DataPropertyName = "TongTienDichVu";
            this.TongTienDichVu.HeaderText = "Tổng Tiền Dịch Vụ";
            this.TongTienDichVu.MinimumWidth = 6;
            this.TongTienDichVu.Name = "TongTienDichVu";
            this.TongTienDichVu.ReadOnly = true;
            this.TongTienDichVu.Width = 125;
            // 
            // TongTienHoaDon
            // 
            this.TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            this.TongTienHoaDon.HeaderText = "Tổng Tiền Hóa Đơn";
            this.TongTienHoaDon.MinimumWidth = 6;
            this.TongTienHoaDon.Name = "TongTienHoaDon";
            this.TongTienHoaDon.ReadOnly = true;
            this.TongTienHoaDon.Width = 125;
            // 
            // ConLai
            // 
            this.ConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConLai.DataPropertyName = "ConLai";
            this.ConLai.HeaderText = "Còn Lại";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 4;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.bt_TimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_TimKiem.BackgroundImage")));
            this.bt_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_TimKiem.FlatAppearance.BorderSize = 0;
            this.bt_TimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_TimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TimKiem.ForeColor = System.Drawing.SystemColors.Menu;
            this.bt_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_TimKiem.Image")));
            this.bt_TimKiem.Location = new System.Drawing.Point(546, 112);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(120, 30);
            this.bt_TimKiem.TabIndex = 5;
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            this.bt_TimKiem.MouseEnter += new System.EventHandler(this.btVeTrangChu_MouseEnter);
            this.bt_TimKiem.MouseLeave += new System.EventHandler(this.bt_trangchu_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập ngày thanh toán :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(804, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.btVeTrangChu_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.bt_trangchu_MouseLeave);
            // 
            // comboboxNgay
            // 
            this.comboboxNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNgay.FormattingEnabled = true;
            this.comboboxNgay.Location = new System.Drawing.Point(253, 115);
            this.comboboxNgay.Name = "comboboxNgay";
            this.comboboxNgay.Size = new System.Drawing.Size(63, 30);
            this.comboboxNgay.TabIndex = 8;
            // 
            // comboboxThang
            // 
            this.comboboxThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxThang.FormattingEnabled = true;
            this.comboboxThang.Location = new System.Drawing.Point(349, 115);
            this.comboboxThang.Name = "comboboxThang";
            this.comboboxThang.Size = new System.Drawing.Size(63, 30);
            this.comboboxThang.TabIndex = 9;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(447, 115);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(73, 30);
            this.txtNam.TabIndex = 10;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btVeTrangChu
            // 
            this.btVeTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btVeTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVeTrangChu.BackgroundImage")));
            this.btVeTrangChu.FlatAppearance.BorderSize = 0;
            this.btVeTrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVeTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVeTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVeTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btVeTrangChu.Image")));
            this.btVeTrangChu.Location = new System.Drawing.Point(678, 112);
            this.btVeTrangChu.Name = "btVeTrangChu";
            this.btVeTrangChu.Size = new System.Drawing.Size(112, 31);
            this.btVeTrangChu.TabIndex = 59;
            this.btVeTrangChu.UseVisualStyleBackColor = false;
            this.btVeTrangChu.MouseEnter += new System.EventHandler(this.btVeTrangChu_MouseEnter);
            this.btVeTrangChu.MouseLeave += new System.EventHandler(this.bt_trangchu_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 58);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // YC4_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btVeTrangChu);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.comboboxThang);
            this.Controls.Add(this.comboboxNgay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagv_hoadon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "YC4_Search";
            this.Text = "TÌM HÓA ĐƠN";
            this.Load += new System.EventHandler(this.YC4_Search_Load);
            this.MouseEnter += new System.EventHandler(this.btVeTrangChu_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.bt_trangchu_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagv_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTiecCuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboboxNgay;
        private System.Windows.Forms.ComboBox comboboxThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btVeTrangChu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}