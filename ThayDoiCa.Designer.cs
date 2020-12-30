namespace QLTiecCuoi
{
    partial class ThayDoiCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiCa));
            this.gb_ca = new System.Windows.Forms.GroupBox();
            this.datagv_ca = new System.Windows.Forms.DataGridView();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.lb_tenca = new System.Windows.Forms.Label();
            this.lb_maca = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.gb_ca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_ca)).BeginInit();
            this.gb_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ca
            // 
            this.gb_ca.BackColor = System.Drawing.Color.Transparent;
            this.gb_ca.Controls.Add(this.datagv_ca);
            this.gb_ca.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ca.Location = new System.Drawing.Point(11, 160);
            this.gb_ca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_ca.Name = "gb_ca";
            this.gb_ca.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_ca.Size = new System.Drawing.Size(362, 180);
            this.gb_ca.TabIndex = 1;
            this.gb_ca.TabStop = false;
            // 
            // datagv_ca
            // 
            this.datagv_ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_ca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCa,
            this.TenCa});
            this.datagv_ca.Location = new System.Drawing.Point(4, 83);
            this.datagv_ca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagv_ca.Name = "datagv_ca";
            this.datagv_ca.RowHeadersWidth = 51;
            this.datagv_ca.RowTemplate.Height = 24;
            this.datagv_ca.Size = new System.Drawing.Size(353, 92);
            this.datagv_ca.TabIndex = 0;
            this.datagv_ca.Click += new System.EventHandler(this.datagv_ca_Click);
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MACA";
            this.MaCa.HeaderText = "Mã Ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.ReadOnly = true;
            this.MaCa.Width = 125;
            // 
            // TenCa
            // 
            this.TenCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCa.DataPropertyName = "TENCA";
            this.TenCa.HeaderText = "Tên Ca";
            this.TenCa.MinimumWidth = 6;
            this.TenCa.Name = "TenCa";
            this.TenCa.ReadOnly = true;
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.BackColor = System.Drawing.Color.Transparent;
            this.gb_thongtin.Controls.Add(this.txtTenCa);
            this.gb_thongtin.Controls.Add(this.txtMaCa);
            this.gb_thongtin.Controls.Add(this.lb_tenca);
            this.gb_thongtin.Controls.Add(this.lb_maca);
            this.gb_thongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtin.Location = new System.Drawing.Point(11, 345);
            this.gb_thongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_thongtin.Size = new System.Drawing.Size(259, 117);
            this.gb_thongtin.TabIndex = 2;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin ca";
            // 
            // txtTenCa
            // 
            this.txtTenCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCa.Location = new System.Drawing.Point(110, 74);
            this.txtTenCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(112, 26);
            this.txtTenCa.TabIndex = 6;
            // 
            // txtMaCa
            // 
            this.txtMaCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCa.Location = new System.Drawing.Point(110, 33);
            this.txtMaCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(76, 26);
            this.txtMaCa.TabIndex = 5;
            // 
            // lb_tenca
            // 
            this.lb_tenca.AutoSize = true;
            this.lb_tenca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenca.Location = new System.Drawing.Point(24, 76);
            this.lb_tenca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenca.Name = "lb_tenca";
            this.lb_tenca.Size = new System.Drawing.Size(54, 19);
            this.lb_tenca.TabIndex = 2;
            this.lb_tenca.Text = "Tên ca";
            // 
            // lb_maca
            // 
            this.lb_maca.AutoSize = true;
            this.lb_maca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maca.Location = new System.Drawing.Point(26, 35);
            this.lb_maca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maca.Name = "lb_maca";
            this.lb_maca.Size = new System.Drawing.Size(52, 19);
            this.lb_maca.TabIndex = 0;
            this.lb_maca.Text = "Mã ca";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(158, 126);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 23);
            this.txtSearch.TabIndex = 7;
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
            this.button5.Location = new System.Drawing.Point(72, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 44);
            this.button5.TabIndex = 58;
            this.button5.UseVisualStyleBackColor = false;
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
            this.button4.Location = new System.Drawing.Point(87, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 101);
            this.button4.TabIndex = 59;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.Navy;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(293, 118);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(89, 30);
            this.btTimKiem.TabIndex = 81;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Navy;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(293, 396);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 33);
            this.btXoa.TabIndex = 82;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Navy;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(293, 432);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 30);
            this.btSua.TabIndex = 83;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Navy;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(293, 353);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 39);
            this.btThem.TabIndex = 84;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // ThayDoiCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(400, 472);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gb_thongtin);
            this.Controls.Add(this.gb_ca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThayDoiCa";
            this.Text = "THAY ĐỔI LOẠI CA";
            this.Load += new System.EventHandler(this.YC6_2_1_Load);
            this.gb_ca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_ca)).EndInit();
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ca;
        private System.Windows.Forms.DataGridView datagv_ca;
        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label lb_tenca;
        private System.Windows.Forms.Label lb_maca;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
    }
}