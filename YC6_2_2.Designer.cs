namespace QLTiecCuoi
{
    partial class YC6_2_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YC6_2_2));
            this.gb_dichvu = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.datagv_dichvu = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_tendichvu = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_madichvu = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTImKiem = new System.Windows.Forms.Button();
            this.gb_dichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_dichvu)).BeginInit();
            this.gb_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_dichvu
            // 
            this.gb_dichvu.BackColor = System.Drawing.Color.Transparent;
            this.gb_dichvu.Controls.Add(this.button5);
            this.gb_dichvu.Controls.Add(this.datagv_dichvu);
            this.gb_dichvu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dichvu.Location = new System.Drawing.Point(4, 144);
            this.gb_dichvu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_dichvu.Name = "gb_dichvu";
            this.gb_dichvu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_dichvu.Size = new System.Drawing.Size(824, 223);
            this.gb_dichvu.TabIndex = 9;
            this.gb_dichvu.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(276, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 44);
            this.button5.TabIndex = 58;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // datagv_dichvu
            // 
            this.datagv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.DonGia,
            this.MoTa,
            this.GhiChu});
            this.datagv_dichvu.Location = new System.Drawing.Point(4, 88);
            this.datagv_dichvu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagv_dichvu.Name = "datagv_dichvu";
            this.datagv_dichvu.RowHeadersWidth = 51;
            this.datagv_dichvu.RowTemplate.Height = 24;
            this.datagv_dichvu.Size = new System.Drawing.Size(814, 130);
            this.datagv_dichvu.TabIndex = 0;
            this.datagv_dichvu.Click += new System.EventHandler(this.datagv_dichvu_Click);
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MADICHVU";
            this.MaDichVu.HeaderText = "Mã Dịch Vụ";
            this.MaDichVu.MinimumWidth = 6;
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.ReadOnly = true;
            this.MaDichVu.Width = 125;
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TENDICHVU";
            this.TenDichVu.HeaderText = "Tên Dịch Vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            this.TenDichVu.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MOTA";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GHICHU";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.BackColor = System.Drawing.Color.Transparent;
            this.gb_thongtin.Controls.Add(this.txtMoTa);
            this.gb_thongtin.Controls.Add(this.txtGhiChu);
            this.gb_thongtin.Controls.Add(this.txtTenDichVu);
            this.gb_thongtin.Controls.Add(this.txtDonGia);
            this.gb_thongtin.Controls.Add(this.txtMaDichVu);
            this.gb_thongtin.Controls.Add(this.lb_ghichu);
            this.gb_thongtin.Controls.Add(this.lb_mota);
            this.gb_thongtin.Controls.Add(this.lb_tendichvu);
            this.gb_thongtin.Controls.Add(this.lb_dongia);
            this.gb_thongtin.Controls.Add(this.lb_madichvu);
            this.gb_thongtin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtin.Location = new System.Drawing.Point(4, 383);
            this.gb_thongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_thongtin.Size = new System.Drawing.Size(667, 164);
            this.gb_thongtin.TabIndex = 10;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin dịch vụ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(440, 30);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(120, 26);
            this.txtMoTa.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(440, 72);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(120, 26);
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDichVu.Location = new System.Drawing.Point(123, 72);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDichVu.Multiline = true;
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(185, 26);
            this.txtTenDichVu.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(123, 116);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 26);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDichVu.Location = new System.Drawing.Point(123, 30);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(92, 26);
            this.txtMaDichVu.TabIndex = 5;
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ghichu.Location = new System.Drawing.Point(358, 76);
            this.lb_ghichu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(60, 19);
            this.lb_ghichu.TabIndex = 4;
            this.lb_ghichu.Text = "Ghi chú";
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(368, 34);
            this.lb_mota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(50, 19);
            this.lb_mota.TabIndex = 3;
            this.lb_mota.Text = "Mô tả";
            // 
            // lb_tendichvu
            // 
            this.lb_tendichvu.AutoSize = true;
            this.lb_tendichvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendichvu.Location = new System.Drawing.Point(14, 76);
            this.lb_tendichvu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tendichvu.Name = "lb_tendichvu";
            this.lb_tendichvu.Size = new System.Drawing.Size(86, 19);
            this.lb_tendichvu.TabIndex = 2;
            this.lb_tendichvu.Text = "Tên dịch vụ";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dongia.Location = new System.Drawing.Point(14, 120);
            this.lb_dongia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(62, 19);
            this.lb_dongia.TabIndex = 1;
            this.lb_dongia.Text = "Đơn giá";
            // 
            // lb_madichvu
            // 
            this.lb_madichvu.AutoSize = true;
            this.lb_madichvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madichvu.Location = new System.Drawing.Point(14, 34);
            this.lb_madichvu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_madichvu.Name = "lb_madichvu";
            this.lb_madichvu.Size = new System.Drawing.Size(84, 19);
            this.lb_madichvu.TabIndex = 0;
            this.lb_madichvu.Text = "Mã dịch vụ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(486, 114);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 26);
            this.txtSearch.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(279, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 101);
            this.button4.TabIndex = 59;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Navy;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(708, 499);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(113, 46);
            this.btSua.TabIndex = 80;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Navy;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(708, 446);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(113, 46);
            this.btXoa.TabIndex = 81;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Navy;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(708, 394);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(113, 46);
            this.btThem.TabIndex = 82;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // btTImKiem
            // 
            this.btTImKiem.BackColor = System.Drawing.Color.Navy;
            this.btTImKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTImKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTImKiem.ForeColor = System.Drawing.Color.White;
            this.btTImKiem.Location = new System.Drawing.Point(708, 93);
            this.btTImKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTImKiem.Name = "btTImKiem";
            this.btTImKiem.Size = new System.Drawing.Size(113, 46);
            this.btTImKiem.TabIndex = 83;
            this.btTImKiem.Text = "Tìm Kiếm";
            this.btTImKiem.UseVisualStyleBackColor = false;
            this.btTImKiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // YC6_2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(839, 552);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTImKiem);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.gb_dichvu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YC6_2_2";
            this.Text = "THAY ĐỔI DỊCH VỤ";
            this.Load += new System.EventHandler(this.YC6_2_2_Load);
            this.gb_dichvu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_dichvu)).EndInit();
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_dichvu;
        private System.Windows.Forms.DataGridView datagv_dichvu;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_tendichvu;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_madichvu;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTImKiem;
    }
}