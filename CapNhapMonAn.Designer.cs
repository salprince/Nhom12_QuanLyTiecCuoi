namespace QLTiecCuoi
{
    partial class CapNhapMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhapMonAn));
            this.gb_monan = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.datagv_monan = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.lb_tenmonan = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_mamonan = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.gb_monan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_monan)).BeginInit();
            this.gb_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_monan
            // 
            this.gb_monan.BackColor = System.Drawing.Color.Transparent;
            this.gb_monan.Controls.Add(this.button5);
            this.gb_monan.Controls.Add(this.datagv_monan);
            this.gb_monan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_monan.Location = new System.Drawing.Point(7, 141);
            this.gb_monan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_monan.Name = "gb_monan";
            this.gb_monan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_monan.Size = new System.Drawing.Size(904, 236);
            this.gb_monan.TabIndex = 2;
            this.gb_monan.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(328, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 44);
            this.button5.TabIndex = 58;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // datagv_monan
            // 
            this.datagv_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_monan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.MoTa,
            this.DonGia,
            this.GhiChu});
            this.datagv_monan.Location = new System.Drawing.Point(4, 81);
            this.datagv_monan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagv_monan.Name = "datagv_monan";
            this.datagv_monan.RowHeadersWidth = 51;
            this.datagv_monan.RowTemplate.Height = 24;
            this.datagv_monan.Size = new System.Drawing.Size(896, 151);
            this.datagv_monan.TabIndex = 0;
            this.datagv_monan.Click += new System.EventHandler(this.datagv_monan_Click);
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MAMONAN";
            this.MaMonAn.HeaderText = "Mã Món Ăn";
            this.MaMonAn.MinimumWidth = 6;
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.ReadOnly = true;
            this.MaMonAn.Width = 125;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TENMONAN";
            this.TenMonAn.HeaderText = "Tên Món Ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            this.TenMonAn.Width = 220;
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
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
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
            this.gb_thongtin.Controls.Add(this.txtTenMonAn);
            this.gb_thongtin.Controls.Add(this.txtGhiChu);
            this.gb_thongtin.Controls.Add(this.txtMoTa);
            this.gb_thongtin.Controls.Add(this.txtDonGia);
            this.gb_thongtin.Controls.Add(this.txtMaMonAn);
            this.gb_thongtin.Controls.Add(this.lb_ghichu);
            this.gb_thongtin.Controls.Add(this.lb_mota);
            this.gb_thongtin.Controls.Add(this.lb_tenmonan);
            this.gb_thongtin.Controls.Add(this.lb_dongia);
            this.gb_thongtin.Controls.Add(this.lb_mamonan);
            this.gb_thongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtin.Location = new System.Drawing.Point(7, 382);
            this.gb_thongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_thongtin.Size = new System.Drawing.Size(738, 151);
            this.gb_thongtin.TabIndex = 3;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonAn.Location = new System.Drawing.Point(123, 74);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenMonAn.Multiline = true;
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(204, 23);
            this.txtTenMonAn.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(478, 74);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(120, 23);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(478, 32);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(120, 23);
            this.txtMoTa.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(123, 113);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 23);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonAn.Location = new System.Drawing.Point(123, 32);
            this.txtMaMonAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(86, 23);
            this.txtMaMonAn.TabIndex = 5;
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ghichu.Location = new System.Drawing.Point(403, 76);
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
            this.lb_mota.Location = new System.Drawing.Point(403, 34);
            this.lb_mota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(50, 19);
            this.lb_mota.TabIndex = 3;
            this.lb_mota.Text = "Mô tả";
            // 
            // lb_tenmonan
            // 
            this.lb_tenmonan.AutoSize = true;
            this.lb_tenmonan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenmonan.Location = new System.Drawing.Point(14, 76);
            this.lb_tenmonan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenmonan.Name = "lb_tenmonan";
            this.lb_tenmonan.Size = new System.Drawing.Size(87, 19);
            this.lb_tenmonan.TabIndex = 2;
            this.lb_tenmonan.Text = "Tên món ăn";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dongia.Location = new System.Drawing.Point(14, 115);
            this.lb_dongia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(62, 19);
            this.lb_dongia.TabIndex = 1;
            this.lb_dongia.Text = "Đơn giá";
            // 
            // lb_mamonan
            // 
            this.lb_mamonan.AutoSize = true;
            this.lb_mamonan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mamonan.Location = new System.Drawing.Point(14, 34);
            this.lb_mamonan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mamonan.Name = "lb_mamonan";
            this.lb_mamonan.Size = new System.Drawing.Size(85, 19);
            this.lb_mamonan.TabIndex = 0;
            this.lb_mamonan.Text = "Mã món ăn";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(528, 105);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 32);
            this.txtSearch.TabIndex = 11;
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
            this.button4.Location = new System.Drawing.Point(327, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 101);
            this.button4.TabIndex = 59;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(769, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 72;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Navy;
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(769, 388);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 46);
            this.btThem.TabIndex = 73;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Navy;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(769, 438);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 46);
            this.btXoa.TabIndex = 74;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Navy;
            this.btSua.FlatAppearance.BorderSize = 0;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(769, 487);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(96, 46);
            this.btSua.TabIndex = 75;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // CapNhapMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(922, 558);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.gb_monan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CapNhapMonAn";
            this.Text = "THAY ĐỔI MÓN ĂN";
            this.Load += new System.EventHandler(this.YC6_2_3_Load);
            this.gb_monan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_monan)).EndInit();
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_monan;
        private System.Windows.Forms.DataGridView datagv_monan;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.Label lb_tenmonan;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_mamonan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
    }
}