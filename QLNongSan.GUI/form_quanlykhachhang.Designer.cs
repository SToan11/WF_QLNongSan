namespace QLNongSan.GUi
{
    partial class form_quanlykhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_quanlykhachhang));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.RichTextBox();
            this.grb_gioitinh = new System.Windows.Forms.GroupBox();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.lbl_tennd = new System.Windows.Forms.Label();
            this.lbl_mand = new System.Windows.Forms.Label();
            this.txt_tennd = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.grb_chucnang = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.dgv_QLKH = new System.Windows.Forms.DataGridView();
            this.txt_mand = new System.Windows.Forms.TextBox();
            this.grb_nhapthongtin = new System.Windows.Forms.GroupBox();
            this.lammoi_btn = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.lbl_sotrang = new System.Windows.Forms.Label();
            this.grb_gioitinh.SuspendLayout();
            this.grb_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLKH)).BeginInit();
            this.grb_nhapthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 529);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số Điện Thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(274, 525);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(500, 38);
            this.txt_sdt.TabIndex = 10;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 475);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(103, 39);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(152, 471);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(622, 38);
            this.txt_email.TabIndex = 8;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(12, 333);
            this.lbl_diachi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(130, 39);
            this.lbl_diachi.TabIndex = 7;
            this.lbl_diachi.Text = "Địa Chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(152, 333);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(622, 122);
            this.txt_diachi.TabIndex = 6;
            this.txt_diachi.Text = "";
            // 
            // grb_gioitinh
            // 
            this.grb_gioitinh.Controls.Add(this.rdo_nu);
            this.grb_gioitinh.Controls.Add(this.rdo_nam);
            this.grb_gioitinh.Location = new System.Drawing.Point(20, 170);
            this.grb_gioitinh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_gioitinh.Name = "grb_gioitinh";
            this.grb_gioitinh.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_gioitinh.Size = new System.Drawing.Size(758, 130);
            this.grb_gioitinh.TabIndex = 4;
            this.grb_gioitinh.TabStop = false;
            this.grb_gioitinh.Text = "Giới Tính";
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nu.Location = new System.Drawing.Point(496, 41);
            this.rdo_nu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(108, 50);
            this.rdo_nu.TabIndex = 1;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nam.Location = new System.Drawing.Point(32, 41);
            this.rdo_nam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(141, 50);
            this.rdo_nam.TabIndex = 0;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // lbl_tennd
            // 
            this.lbl_tennd.AutoSize = true;
            this.lbl_tennd.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_tennd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tennd.Location = new System.Drawing.Point(12, 116);
            this.lbl_tennd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_tennd.Name = "lbl_tennd";
            this.lbl_tennd.Size = new System.Drawing.Size(266, 39);
            this.lbl_tennd.TabIndex = 2;
            this.lbl_tennd.Text = "Tên Người Dùng";
            // 
            // lbl_mand
            // 
            this.lbl_mand.AutoSize = true;
            this.lbl_mand.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_mand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mand.Location = new System.Drawing.Point(12, 52);
            this.lbl_mand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mand.Name = "lbl_mand";
            this.lbl_mand.Size = new System.Drawing.Size(254, 39);
            this.lbl_mand.TabIndex = 1;
            this.lbl_mand.Text = "Mã Người Dùng";
            // 
            // txt_tennd
            // 
            this.txt_tennd.Location = new System.Drawing.Point(284, 116);
            this.txt_tennd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_tennd.Name = "txt_tennd";
            this.txt_tennd.Size = new System.Drawing.Size(490, 38);
            this.txt_tennd.TabIndex = 3;
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
            // grb_chucnang
            // 
            this.grb_chucnang.Controls.Add(this.btn_timkiem);
            this.grb_chucnang.Controls.Add(this.txt_timkiem);
            this.grb_chucnang.Controls.Add(this.btn_lammoi);
            this.grb_chucnang.Controls.Add(this.btn_capnhat);
            this.grb_chucnang.Controls.Add(this.btn_xoa);
            this.grb_chucnang.Controls.Add(this.btn_sua);
            this.grb_chucnang.Controls.Add(this.btn_them);
            this.grb_chucnang.Location = new System.Drawing.Point(431, 865);
            this.grb_chucnang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_chucnang.Name = "grb_chucnang";
            this.grb_chucnang.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_chucnang.Size = new System.Drawing.Size(2018, 194);
            this.grb_chucnang.TabIndex = 7;
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
            this.btn_lammoi.Location = new System.Drawing.Point(1068, 62);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(262, 91);
            this.btn_lammoi.TabIndex = 6;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_capnhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_capnhat.Image")));
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(786, 62);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(270, 91);
            this.btn_capnhat.TabIndex = 5;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
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
            // dgv_QLKH
            // 
            this.dgv_QLKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_QLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLKH.Location = new System.Drawing.Point(431, 83);
            this.dgv_QLKH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv_QLKH.Name = "dgv_QLKH";
            this.dgv_QLKH.RowHeadersWidth = 51;
            this.dgv_QLKH.RowTemplate.Height = 24;
            this.dgv_QLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLKH.Size = new System.Drawing.Size(2018, 727);
            this.dgv_QLKH.TabIndex = 8;
            this.dgv_QLKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLKH_CellContentClick);
            this.dgv_QLKH.SelectionChanged += new System.EventHandler(this.dgv_QLKH_SelectionChanged);
            // 
            // txt_mand
            // 
            this.txt_mand.Location = new System.Drawing.Point(274, 48);
            this.txt_mand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_mand.Name = "txt_mand";
            this.txt_mand.ReadOnly = true;
            this.txt_mand.Size = new System.Drawing.Size(500, 38);
            this.txt_mand.TabIndex = 0;
            // 
            // grb_nhapthongtin
            // 
            this.grb_nhapthongtin.BackColor = System.Drawing.SystemColors.Control;
            this.grb_nhapthongtin.Controls.Add(this.lammoi_btn);
            this.grb_nhapthongtin.Controls.Add(this.label1);
            this.grb_nhapthongtin.Controls.Add(this.txt_sdt);
            this.grb_nhapthongtin.Controls.Add(this.lbl_email);
            this.grb_nhapthongtin.Controls.Add(this.txt_email);
            this.grb_nhapthongtin.Controls.Add(this.lbl_diachi);
            this.grb_nhapthongtin.Controls.Add(this.txt_diachi);
            this.grb_nhapthongtin.Controls.Add(this.grb_gioitinh);
            this.grb_nhapthongtin.Controls.Add(this.txt_tennd);
            this.grb_nhapthongtin.Controls.Add(this.lbl_tennd);
            this.grb_nhapthongtin.Controls.Add(this.lbl_mand);
            this.grb_nhapthongtin.Controls.Add(this.txt_mand);
            this.grb_nhapthongtin.Location = new System.Drawing.Point(2461, 83);
            this.grb_nhapthongtin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_nhapthongtin.Name = "grb_nhapthongtin";
            this.grb_nhapthongtin.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grb_nhapthongtin.Size = new System.Drawing.Size(790, 976);
            this.grb_nhapthongtin.TabIndex = 6;
            this.grb_nhapthongtin.TabStop = false;
            this.grb_nhapthongtin.Text = "Nhập Thông Tin";
            // 
            // lammoi_btn
            // 
            this.lammoi_btn.BackColor = System.Drawing.SystemColors.Control;
            this.lammoi_btn.Image = ((System.Drawing.Image)(resources.GetObject("lammoi_btn.Image")));
            this.lammoi_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lammoi_btn.Location = new System.Drawing.Point(192, 636);
            this.lammoi_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lammoi_btn.Name = "lammoi_btn";
            this.lammoi_btn.Size = new System.Drawing.Size(440, 91);
            this.lammoi_btn.TabIndex = 15;
            this.lammoi_btn.Text = "Làm Mới Thông Tin";
            this.lammoi_btn.UseVisualStyleBackColor = false;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1773, 821);
            this.btn_next.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(150, 45);
            this.btn_next.TabIndex = 24;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(701, 821);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(150, 45);
            this.btn_pre.TabIndex = 23;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // lbl_sotrang
            // 
            this.lbl_sotrang.AutoSize = true;
            this.lbl_sotrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang.Location = new System.Drawing.Point(1293, 821);
            this.lbl_sotrang.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_sotrang.Name = "lbl_sotrang";
            this.lbl_sotrang.Size = new System.Drawing.Size(42, 46);
            this.lbl_sotrang.TabIndex = 25;
            this.lbl_sotrang.Text = "1";
            // 
            // form_quanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3412, 1182);
            this.Controls.Add(this.lbl_sotrang);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.grb_chucnang);
            this.Controls.Add(this.dgv_QLKH);
            this.Controls.Add(this.grb_nhapthongtin);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "form_quanlykhachhang";
            this.Text = "form_quanlykhachhang";
            this.Load += new System.EventHandler(this.form_quanlykhachhang_Load);
            this.grb_gioitinh.ResumeLayout(false);
            this.grb_gioitinh.PerformLayout();
            this.grb_chucnang.ResumeLayout(false);
            this.grb_chucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLKH)).EndInit();
            this.grb_nhapthongtin.ResumeLayout(false);
            this.grb_nhapthongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.RichTextBox txt_diachi;
        private System.Windows.Forms.GroupBox grb_gioitinh;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.Label lbl_tennd;
        private System.Windows.Forms.Label lbl_mand;
        private System.Windows.Forms.TextBox txt_tennd;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox grb_chucnang;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridView dgv_QLKH;
        private System.Windows.Forms.TextBox txt_mand;
        private System.Windows.Forms.GroupBox grb_nhapthongtin;
        private System.Windows.Forms.Button lammoi_btn;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Label lbl_sotrang;
    }
}