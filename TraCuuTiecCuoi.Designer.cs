namespace QLTiecCuoi
{
    partial class TraCuuTiecCuoi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuyTiec = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.dgvTC = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Danh Sách Tiệc Cưới";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.Navy;
            this.btThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.White;
            this.btThanhToan.Location = new System.Drawing.Point(1178, 34);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(152, 57);
            this.btThanhToan.TabIndex = 68;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1009, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 68;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.btnHuyTiec);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 709);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1560, 128);
            this.panel2.TabIndex = 70;
            // 
            // btnHuyTiec
            // 
            this.btnHuyTiec.BackColor = System.Drawing.Color.LightCyan;
            this.btnHuyTiec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHuyTiec.FlatAppearance.BorderSize = 0;
            this.btnHuyTiec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTiec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTiec.ForeColor = System.Drawing.Color.Black;
            this.btnHuyTiec.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnHuyTiec.IconColor = System.Drawing.Color.Black;
            this.btnHuyTiec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTiec.Location = new System.Drawing.Point(132, 0);
            this.btnHuyTiec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyTiec.Name = "btnHuyTiec";
            this.btnHuyTiec.Size = new System.Drawing.Size(179, 128);
            this.btnHuyTiec.TabIndex = 53;
            this.btnHuyTiec.Text = "Hủy Tiệc";
            this.btnHuyTiec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTiec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyTiec.UseVisualStyleBackColor = false;
            this.btnHuyTiec.Click += new System.EventHandler(this.btnHuyTiec_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightCyan;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(0, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 128);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvTC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTC.BackgroundColor = System.Drawing.Color.White;
            this.dgvTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.DoubleBuffered = true;
            this.dgvTC.EnableHeadersVisualStyles = false;
            this.dgvTC.GridColor = System.Drawing.Color.White;
            this.dgvTC.HeaderBgColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvTC.HeaderForeColor = System.Drawing.Color.Navy;
            this.dgvTC.Location = new System.Drawing.Point(51, 149);
            this.dgvTC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTC.RowHeadersWidth = 51;
            this.dgvTC.Size = new System.Drawing.Size(1279, 506);
            this.dgvTC.TabIndex = 71;
            this.dgvTC.SelectionChanged += new System.EventHandler(this.dgvTC_SelectionChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(627, 81);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 1);
            this.panel5.TabIndex = 73;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteCustomSource.AddRange(new string[] {
            "Dương",
            "Phạm",
            "Trần",
            "Nguyễn",
            "Lê",
            "Trịnh",
            "Phan",
            "Vũ",
            "Võ",
            "Đặng",
            "Bùi",
            "Đỗ",
            "Hồ",
            "Ngô",
            "Đoàn",
            "Thân",
            "Trương",
            "Quách",
            "Bạch",
            "Lý",
            "Đào",
            "Hà",
            "Hoàng",
            "Huynh",
            "Hồ"});
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.BackColor = System.Drawing.Color.LightCyan;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(627, 61);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(375, 23);
            this.txtTimKiem.TabIndex = 72;
            // 
            // TraCuuTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1560, 837);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvTC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraCuuTiecCuoi";
            this.Text = "TRA CỨU TIỆC CƯỚI";
            this.Load += new System.EventHandler(this.TraCuuTiecCuoi_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHuyTiec;
        private FontAwesome.Sharp.IconButton btnSua;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTC;
        private System.Windows.Forms.TextBox textBoxTimkiem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}