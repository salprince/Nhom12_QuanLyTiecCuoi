namespace QLTiecCuoi
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btNhanVien = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(153, 116);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(132, 26);
            this.Username.TabIndex = 2;
            this.Username.Text = "Huyen";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(153, 185);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(132, 22);
            this.Password.TabIndex = 3;
            this.Password.Text = "18520865";
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(21, 114);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(95, 23);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(25, 186);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 23);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackgroundColor = System.Drawing.Color.Navy;
            this.btNhanVien.ButtonImage = null;
            this.btNhanVien.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btNhanVien.ButtonText = "Đăng Nhập";
            this.btNhanVien.ClickBackColor = System.Drawing.Color.White;
            this.btNhanVien.ClickTextColor = System.Drawing.Color.White;
            this.btNhanVien.CornerRadius = 5;
            this.btNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.btNhanVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btNhanVien.HoverBackgroundColor = System.Drawing.Color.White;
            this.btNhanVien.HoverTextColor = System.Drawing.Color.Navy;
            this.btNhanVien.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btNhanVien.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btNhanVien.Location = new System.Drawing.Point(83, 247);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(138, 38);
            this.btNhanVien.TabIndex = 20;
            this.btNhanVien.TextColor = System.Drawing.Color.White;
            this.btNhanVien.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btNhanVien.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(303, 324);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private XanderUI.XUIButton btNhanVien;
    }
}

