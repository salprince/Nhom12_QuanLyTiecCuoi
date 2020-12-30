namespace QLTiecCuoi
{
    partial class QuanLyNhanVien
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
            this.dgv_DanhSachNV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenDN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btNVThuong = new System.Windows.Forms.RadioButton();
            this.btNVQL = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachNV
            // 
            this.dgv_DanhSachNV.AllowUserToOrderColumns = true;
            this.dgv_DanhSachNV.ColumnHeadersHeight = 40;
            this.dgv_DanhSachNV.Location = new System.Drawing.Point(44, 59);
            this.dgv_DanhSachNV.Name = "dgv_DanhSachNV";
            this.dgv_DanhSachNV.RowHeadersWidth = 45;
            this.dgv_DanhSachNV.RowTemplate.Height = 24;
            this.dgv_DanhSachNV.Size = new System.Drawing.Size(652, 198);
            this.dgv_DanhSachNV.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 26);
            this.label4.TabIndex = 85;
            this.label4.Text = "Danh Sách Nhân Viên";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Navy;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btThem.Location = new System.Drawing.Point(721, 83);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(97, 61);
            this.btThem.TabIndex = 86;
            this.btThem.Text = "+";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.them_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(721, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 64);
            this.button1.TabIndex = 87;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 498);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 92;
            this.label3.Text = "Loại Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 439);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 90;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // tbTenDN
            // 
            this.tbTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDN.Location = new System.Drawing.Point(217, 52);
            this.tbTenDN.Name = "tbTenDN";
            this.tbTenDN.Size = new System.Drawing.Size(451, 30);
            this.tbTenDN.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 387);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 88;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 93;
            this.label5.Text = "Thêm Mới";
            // 
            // btNVThuong
            // 
            this.btNVThuong.AutoSize = true;
            this.btNVThuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNVThuong.Location = new System.Drawing.Point(284, 215);
            this.btNVThuong.Name = "btNVThuong";
            this.btNVThuong.Size = new System.Drawing.Size(92, 26);
            this.btNVThuong.TabIndex = 94;
            this.btNVThuong.TabStop = true;
            this.btNVThuong.Text = "Thường";
            this.btNVThuong.UseVisualStyleBackColor = true;
            this.btNVThuong.CheckedChanged += new System.EventHandler(this.Thuong_Check);
            // 
            // btNVQL
            // 
            this.btNVQL.AutoSize = true;
            this.btNVQL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNVQL.Location = new System.Drawing.Point(481, 215);
            this.btNVQL.Name = "btNVQL";
            this.btNVQL.Size = new System.Drawing.Size(98, 26);
            this.btNVQL.TabIndex = 95;
            this.btNVQL.TabStop = true;
            this.btNVQL.Text = "Quản Lý";
            this.btNVQL.UseVisualStyleBackColor = true;
            this.btNVQL.CheckedChanged += new System.EventHandler(this.QL_Check);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btNVThuong);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.btNVQL);
            this.panel1.Controls.Add(this.tbTenNV);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbTenDN);
            this.panel1.Location = new System.Drawing.Point(27, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 283);
            this.panel1.TabIndex = 96;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Navy;
            this.btOK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOK.Location = new System.Drawing.Point(693, 192);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(97, 71);
            this.btOK.TabIndex = 97;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNV.Location = new System.Drawing.Point(217, 157);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(451, 30);
            this.tbTenNV.TabIndex = 95;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(217, 103);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(451, 30);
            this.tbPass.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(27, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 260);
            this.panel2.TabIndex = 97;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_DanhSachNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.DSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton btNVThuong;
        private System.Windows.Forms.RadioButton btNVQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Panel panel2;
    }
}