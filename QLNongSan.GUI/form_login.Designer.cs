namespace QLNongSan.GUi
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_ghinho = new System.Windows.Forms.CheckBox();
            this.lkl_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(228, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1455, 98);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng nhập hệ thống Quản lý nông sản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_ghinho);
            this.groupBox2.Controls.Add(this.lkl_quenmatkhau);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_dangnhap);
            this.groupBox2.Controls.Add(this.txt_matkhau);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(722, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(990, 521);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đăng nhập";
            // 
            // chb_ghinho
            // 
            this.chb_ghinho.AutoSize = true;
            this.chb_ghinho.Location = new System.Drawing.Point(58, 326);
            this.chb_ghinho.Margin = new System.Windows.Forms.Padding(6);
            this.chb_ghinho.Name = "chb_ghinho";
            this.chb_ghinho.Size = new System.Drawing.Size(344, 57);
            this.chb_ghinho.TabIndex = 10;
            this.chb_ghinho.Text = "Hiện mật khẩu";
            this.chb_ghinho.UseVisualStyleBackColor = true;
            this.chb_ghinho.CheckedChanged += new System.EventHandler(this.chb_ghinho_CheckedChanged_1);
            // 
            // lkl_quenmatkhau
            // 
            this.lkl_quenmatkhau.AutoSize = true;
            this.lkl_quenmatkhau.Location = new System.Drawing.Point(602, 326);
            this.lkl_quenmatkhau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lkl_quenmatkhau.Name = "lkl_quenmatkhau";
            this.lkl_quenmatkhau.Size = new System.Drawing.Size(341, 53);
            this.lkl_quenmatkhau.TabIndex = 9;
            this.lkl_quenmatkhau.TabStop = true;
            this.lkl_quenmatkhau.Text = "Quên mật khẩu?";
            this.lkl_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_quenmatkhau_LinkClicked);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Lime;
            this.btn_thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_thoat.Location = new System.Drawing.Point(532, 422);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(428, 87);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.Lime;
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Location = new System.Drawing.Point(38, 422);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(6);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(428, 87);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(296, 196);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(6);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(660, 60);
            this.txt_matkhau.TabIndex = 6;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(296, 91);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(660, 60);
            this.txt_email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 53);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(606, 521);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QLNongSan.GUi.Properties.Resources.ssss;
            this.pictureBox1.Location = new System.Drawing.Point(6, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1824, 849);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chb_ghinho;
        private System.Windows.Forms.LinkLabel lkl_quenmatkhau;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}