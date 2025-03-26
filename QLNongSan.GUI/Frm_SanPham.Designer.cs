namespace QLNongSan.GUi
{
    partial class Frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SanPham));
            this.dgv_QLSP = new System.Windows.Forms.DataGridView();
            this.cbo_loaihang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mo = new System.Windows.Forms.Button();
            this.grb_nhapthongtin = new System.Windows.Forms.GroupBox();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hinh = new System.Windows.Forms.RichTextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lammoithongtin = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.lbl_tennd = new System.Windows.Forms.Label();
            this.lbl_mand = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.grb_chucnang = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_sotrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSP)).BeginInit();
            this.grb_nhapthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.grb_chucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QLSP
            // 
            this.dgv_QLSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_QLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLSP.Location = new System.Drawing.Point(384, 62);
            this.dgv_QLSP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv_QLSP.Name = "dgv_QLSP";
            this.dgv_QLSP.RowHeadersWidth = 51;
            this.dgv_QLSP.RowTemplate.Height = 24;
            this.dgv_QLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLSP.Size = new System.Drawing.Size(2018, 717);
            this.dgv_QLSP.TabIndex = 18;
            this.dgv_QLSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLSP_CellContentClick);
            // 
            // cbo_loaihang
            // 
            this.cbo_loaihang.FormattingEnabled = true;
            this.cbo_loaihang.Location = new System.Drawing.Point(274, 269);
            this.cbo_loaihang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbo_loaihang.Name = "cbo_loaihang";
            this.cbo_loaihang.Size = new System.Drawing.Size(498, 39);
            this.cbo_loaihang.TabIndex = 15;
            this.cbo_loaihang.SelectedIndexChanged += new System.EventHandler(this.cbo_loaihang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 39);
            this.label2.TabIndex = 23;
            this.label2.Text = "Loại Hàng";
            // 
            // btn_mo
            // 
            this.btn_mo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mo.Image = ((System.Drawing.Image)(resources.GetObject("btn_mo.Image")));
            this.btn_mo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mo.Location = new System.Drawing.Point(20, 388);
            this.btn_mo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_mo.Name = "btn_mo";
            this.btn_mo.Size = new System.Drawing.Size(228, 91);
            this.btn_mo.TabIndex = 21;
            this.btn_mo.Text = "       Mở Hình";
            this.btn_mo.UseVisualStyleBackColor = false;
            this.btn_mo.Click += new System.EventHandler(this.btn_mo_Click);
            // 
            // grb_nhapthongtin
            // 
            this.grb_nhapthongtin.BackColor = System.Drawing.SystemColors.Control;
            this.grb_nhapthongtin.Controls.Add(this.dtp_ngay);
            this.grb_nhapthongtin.Controls.Add(this.cbo_loaihang);
            this.grb_nhapthongtin.Controls.Add(this.label2);
            this.grb_nhapthongtin.Controls.Add(this.btn_mo);
            this.grb_nhapthongtin.Controls.Add(this.pbHinh);
            this.grb_nhapthongtin.Controls.Add(this.label1);
            this.grb_nhapthongtin.Controls.Add(this.txt_hinh);
            this.grb_nhapthongtin.Controls.Add(this.txt_soluong);
            this.grb_nhapthongtin.Controls.Add(this.label3);
            this.grb_nhapthongtin.Controls.Add(this.btn_lammoithongtin);
            this.grb_nhapthongtin.Controls.Add(this.lbl_email);
            this.grb_nhapthongtin.Controls.Add(this.txt_dongia);
            this.grb_nhapthongtin.Controls.Add(this.lbl_diachi);
            this.grb_nhapthongtin.Controls.Add(this.txt_ghichu);
            this.grb_nhapthongtin.Controls.Add(this.txt_tensp);
            this.grb_nhapthongtin.Controls.Add(this.lbl_tennd);
            this.grb_nhapthongtin.Controls.Add(this.lbl_mand);
            this.grb_nhapthongtin.Controls.Add(this.txt_masp);
            this.grb_nhapthongtin.Location = new System.Drawing.Point(2418, 56);
            this.grb_nhapthongtin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_nhapthongtin.Name = "grb_nhapthongtin";
            this.grb_nhapthongtin.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_nhapthongtin.Size = new System.Drawing.Size(790, 976);
            this.grb_nhapthongtin.TabIndex = 19;
            this.grb_nhapthongtin.TabStop = false;
            this.grb_nhapthongtin.Text = "Nhập Thông Tin";
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay.Location = new System.Drawing.Point(274, 329);
            this.dtp_ngay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(498, 38);
            this.dtp_ngay.TabIndex = 24;
            this.dtp_ngay.ValueChanged += new System.EventHandler(this.dtp_ngay_ValueChanged);
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(272, 388);
            this.pbHinh.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(504, 306);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinh.TabIndex = 20;
            this.pbHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày Thêm";
            // 
            // txt_hinh
            // 
            this.txt_hinh.Location = new System.Drawing.Point(20, 490);
            this.txt_hinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_hinh.Name = "txt_hinh";
            this.txt_hinh.Size = new System.Drawing.Size(224, 200);
            this.txt_hinh.TabIndex = 17;
            this.txt_hinh.Text = "";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(274, 157);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(500, 38);
            this.txt_soluong.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số Lượng";
            // 
            // btn_lammoithongtin
            // 
            this.btn_lammoithongtin.BackColor = System.Drawing.SystemColors.Control;
            this.btn_lammoithongtin.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoithongtin.Image")));
            this.btn_lammoithongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lammoithongtin.Location = new System.Drawing.Point(212, 845);
            this.btn_lammoithongtin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_lammoithongtin.Name = "btn_lammoithongtin";
            this.btn_lammoithongtin.Size = new System.Drawing.Size(440, 91);
            this.btn_lammoithongtin.TabIndex = 14;
            this.btn_lammoithongtin.Text = "Làm Mới Thông Tin";
            this.btn_lammoithongtin.UseVisualStyleBackColor = false;
            this.btn_lammoithongtin.Click += new System.EventHandler(this.btn_lammoithongtin_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 215);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(246, 39);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Đơn Giá (VNĐ)";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(274, 211);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(500, 38);
            this.txt_dongia.TabIndex = 8;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(10, 707);
            this.lbl_diachi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(142, 39);
            this.lbl_diachi.TabIndex = 7;
            this.lbl_diachi.Text = "Ghi Chú";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(162, 707);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(610, 122);
            this.txt_ghichu.TabIndex = 6;
            this.txt_ghichu.Text = "";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(274, 103);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(500, 38);
            this.txt_tensp.TabIndex = 3;
            // 
            // lbl_tennd
            // 
            this.lbl_tennd.AutoSize = true;
            this.lbl_tennd.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_tennd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tennd.Location = new System.Drawing.Point(12, 107);
            this.lbl_tennd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_tennd.Name = "lbl_tennd";
            this.lbl_tennd.Size = new System.Drawing.Size(244, 39);
            this.lbl_tennd.TabIndex = 2;
            this.lbl_tennd.Text = "Tên Sản Phẩm";
            // 
            // lbl_mand
            // 
            this.lbl_mand.AutoSize = true;
            this.lbl_mand.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_mand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mand.Location = new System.Drawing.Point(12, 52);
            this.lbl_mand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mand.Name = "lbl_mand";
            this.lbl_mand.Size = new System.Drawing.Size(232, 39);
            this.lbl_mand.TabIndex = 1;
            this.lbl_mand.Text = "Mã Sản Phẩm";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(274, 48);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.ReadOnly = true;
            this.txt_masp.Size = new System.Drawing.Size(500, 38);
            this.txt_masp.TabIndex = 0;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(270, 62);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(246, 91);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(12, 62);
            this.btn_them.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(246, 91);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(528, 62);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(246, 91);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // grb_chucnang
            // 
            this.grb_chucnang.Controls.Add(this.btn_timkiem);
            this.grb_chucnang.Controls.Add(this.txt_timkiem);
            this.grb_chucnang.Controls.Add(this.btn_lammoi);
            this.grb_chucnang.Controls.Add(this.btn_xoa);
            this.grb_chucnang.Controls.Add(this.btn_sua);
            this.grb_chucnang.Controls.Add(this.btn_them);
            this.grb_chucnang.Location = new System.Drawing.Point(388, 839);
            this.grb_chucnang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_chucnang.Name = "grb_chucnang";
            this.grb_chucnang.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_chucnang.Size = new System.Drawing.Size(2018, 194);
            this.grb_chucnang.TabIndex = 20;
            this.grb_chucnang.TabStop = false;
            this.grb_chucnang.Text = "Chức Năng";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(1866, 62);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(140, 91);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(1342, 85);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(508, 38);
            this.txt_timkiem.TabIndex = 7;
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lammoi.Location = new System.Drawing.Point(786, 62);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(262, 91);
            this.btn_lammoi.TabIndex = 6;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(658, 793);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(150, 45);
            this.btn_pre.TabIndex = 21;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1730, 793);
            this.btn_next.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(150, 45);
            this.btn_next.TabIndex = 22;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_sotrang
            // 
            this.lbl_sotrang.AutoSize = true;
            this.lbl_sotrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang.Location = new System.Drawing.Point(1250, 793);
            this.lbl_sotrang.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_sotrang.Name = "lbl_sotrang";
            this.lbl_sotrang.Size = new System.Drawing.Size(42, 46);
            this.lbl_sotrang.TabIndex = 23;
            this.lbl_sotrang.Text = "1";
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3354, 1185);
            this.Controls.Add(this.lbl_sotrang);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.dgv_QLSP);
            this.Controls.Add(this.grb_nhapthongtin);
            this.Controls.Add(this.grb_chucnang);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_SanPham";
            this.Text = "Frm_SanPham";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSP)).EndInit();
            this.grb_nhapthongtin.ResumeLayout(false);
            this.grb_nhapthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.grb_chucnang.ResumeLayout(false);
            this.grb_chucnang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLSP;
        private System.Windows.Forms.ComboBox cbo_loaihang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mo;
        private System.Windows.Forms.GroupBox grb_nhapthongtin;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_hinh;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lammoithongtin;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.RichTextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label lbl_tennd;
        private System.Windows.Forms.Label lbl_mand;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox grb_chucnang;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.Label lbl_sotrang;
    }
}