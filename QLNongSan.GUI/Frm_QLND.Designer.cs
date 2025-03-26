namespace QLNongSan.GUI
{
    partial class Frm_QLND
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLND));
            this.dgv_QLNV = new System.Windows.Forms.DataGridView();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.grb_chucnang = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tennd = new System.Windows.Forms.TextBox();
            this.lbl_tennd = new System.Windows.Forms.Label();
            this.lbl_mand = new System.Windows.Forms.Label();
            this.txt_mand = new System.Windows.Forms.TextBox();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_quantri = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nhanvien = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.RichTextBox();
            this.grb_vaitro = new System.Windows.Forms.GroupBox();
            this.grb_gioitinh = new System.Windows.Forms.GroupBox();
            this.grb_nhapthongtin = new System.Windows.Forms.GroupBox();
            this.rtxt_hinh = new System.Windows.Forms.RichTextBox();
            this.btn_mohinh = new System.Windows.Forms.Button();
            this.ptb_hinh = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.lbl_sotrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).BeginInit();
            this.grb_chucnang.SuspendLayout();
            this.grb_vaitro.SuspendLayout();
            this.grb_gioitinh.SuspendLayout();
            this.grb_nhapthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLNV
            // 
            this.dgv_QLNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_QLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLNV.Location = new System.Drawing.Point(376, 31);
            this.dgv_QLNV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgv_QLNV.Name = "dgv_QLNV";
            this.dgv_QLNV.ReadOnly = true;
            this.dgv_QLNV.RowHeadersWidth = 51;
            this.dgv_QLNV.RowTemplate.Height = 24;
            this.dgv_QLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLNV.Size = new System.Drawing.Size(2019, 930);
            this.dgv_QLNV.TabIndex = 5;
            this.dgv_QLNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLNV_CellContentClick);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(1736, 62);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(227, 91);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(1067, 86);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(652, 38);
            this.txt_timkiem.TabIndex = 7;
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lammoi.Location = new System.Drawing.Point(787, 62);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(269, 91);
            this.btn_lammoi.TabIndex = 5;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(528, 62);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(245, 91);
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
            this.btn_sua.Location = new System.Drawing.Point(269, 62);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(245, 91);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // grb_chucnang
            // 
            this.grb_chucnang.Controls.Add(this.btn_timkiem);
            this.grb_chucnang.Controls.Add(this.txt_timkiem);
            this.grb_chucnang.Controls.Add(this.btn_lammoi);
            this.grb_chucnang.Controls.Add(this.btn_xoa);
            this.grb_chucnang.Controls.Add(this.btn_sua);
            this.grb_chucnang.Controls.Add(this.btn_them);
            this.grb_chucnang.Location = new System.Drawing.Point(376, 1147);
            this.grb_chucnang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_chucnang.Name = "grb_chucnang";
            this.grb_chucnang.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_chucnang.Size = new System.Drawing.Size(2019, 193);
            this.grb_chucnang.TabIndex = 4;
            this.grb_chucnang.TabStop = false;
            this.grb_chucnang.Text = "Chức Năng";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(11, 62);
            this.btn_them.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(245, 91);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tennd
            // 
            this.txt_tennd.Location = new System.Drawing.Point(336, 117);
            this.txt_tennd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_tennd.Name = "txt_tennd";
            this.txt_tennd.Size = new System.Drawing.Size(439, 38);
            this.txt_tennd.TabIndex = 3;
            // 
            // lbl_tennd
            // 
            this.lbl_tennd.AutoSize = true;
            this.lbl_tennd.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_tennd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tennd.Location = new System.Drawing.Point(11, 117);
            this.lbl_tennd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.lbl_mand.Location = new System.Drawing.Point(11, 52);
            this.lbl_mand.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_mand.Name = "lbl_mand";
            this.lbl_mand.Size = new System.Drawing.Size(254, 39);
            this.lbl_mand.TabIndex = 1;
            this.lbl_mand.Text = "Mã Người Dùng";
            // 
            // txt_mand
            // 
            this.txt_mand.Location = new System.Drawing.Point(336, 48);
            this.txt_mand.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_mand.Name = "txt_mand";
            this.txt_mand.ReadOnly = true;
            this.txt_mand.Size = new System.Drawing.Size(439, 38);
            this.txt_mand.TabIndex = 0;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nu.Location = new System.Drawing.Point(496, 41);
            this.rdo_nu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(108, 50);
            this.rdo_nu.TabIndex = 1;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_quantri
            // 
            this.rdo_quantri.AutoSize = true;
            this.rdo_quantri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_quantri.Location = new System.Drawing.Point(32, 41);
            this.rdo_quantri.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdo_quantri.Name = "rdo_quantri";
            this.rdo_quantri.Size = new System.Drawing.Size(211, 50);
            this.rdo_quantri.TabIndex = 0;
            this.rdo_quantri.TabStop = true;
            this.rdo_quantri.Text = "Quản Trị";
            this.rdo_quantri.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nam.Location = new System.Drawing.Point(32, 41);
            this.rdo_nam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(141, 50);
            this.rdo_nam.TabIndex = 0;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nhanvien
            // 
            this.rdo_nhanvien.AutoSize = true;
            this.rdo_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nhanvien.Location = new System.Drawing.Point(496, 41);
            this.rdo_nhanvien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdo_nhanvien.Name = "rdo_nhanvien";
            this.rdo_nhanvien.Size = new System.Drawing.Size(243, 50);
            this.rdo_nhanvien.TabIndex = 1;
            this.rdo_nhanvien.TabStop = true;
            this.rdo_nhanvien.Text = "Nhân Viên";
            this.rdo_nhanvien.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(192, 1178);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 91);
            this.button1.TabIndex = 14;
            this.button1.Text = "Làm Mới Thông Tin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 649);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số Điện Thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(275, 646);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(500, 38);
            this.txt_sdt.TabIndex = 10;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(11, 594);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(103, 39);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(152, 591);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(623, 38);
            this.txt_email.TabIndex = 8;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(11, 453);
            this.lbl_diachi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(130, 39);
            this.lbl_diachi.TabIndex = 7;
            this.lbl_diachi.Text = "Địa Chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(152, 453);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(623, 123);
            this.txt_diachi.TabIndex = 6;
            this.txt_diachi.Text = "";
            // 
            // grb_vaitro
            // 
            this.grb_vaitro.Controls.Add(this.rdo_nhanvien);
            this.grb_vaitro.Controls.Add(this.rdo_quantri);
            this.grb_vaitro.Location = new System.Drawing.Point(21, 312);
            this.grb_vaitro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_vaitro.Name = "grb_vaitro";
            this.grb_vaitro.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_vaitro.Size = new System.Drawing.Size(757, 129);
            this.grb_vaitro.TabIndex = 5;
            this.grb_vaitro.TabStop = false;
            this.grb_vaitro.Text = "Vai Trò";
            // 
            // grb_gioitinh
            // 
            this.grb_gioitinh.Controls.Add(this.rdo_nu);
            this.grb_gioitinh.Controls.Add(this.rdo_nam);
            this.grb_gioitinh.Location = new System.Drawing.Point(21, 172);
            this.grb_gioitinh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_gioitinh.Name = "grb_gioitinh";
            this.grb_gioitinh.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_gioitinh.Size = new System.Drawing.Size(757, 129);
            this.grb_gioitinh.TabIndex = 4;
            this.grb_gioitinh.TabStop = false;
            this.grb_gioitinh.Text = "Giới Tính";
            // 
            // grb_nhapthongtin
            // 
            this.grb_nhapthongtin.BackColor = System.Drawing.SystemColors.Control;
            this.grb_nhapthongtin.Controls.Add(this.rtxt_hinh);
            this.grb_nhapthongtin.Controls.Add(this.btn_mohinh);
            this.grb_nhapthongtin.Controls.Add(this.ptb_hinh);
            this.grb_nhapthongtin.Controls.Add(this.button1);
            this.grb_nhapthongtin.Controls.Add(this.label1);
            this.grb_nhapthongtin.Controls.Add(this.txt_sdt);
            this.grb_nhapthongtin.Controls.Add(this.lbl_email);
            this.grb_nhapthongtin.Controls.Add(this.txt_email);
            this.grb_nhapthongtin.Controls.Add(this.lbl_diachi);
            this.grb_nhapthongtin.Controls.Add(this.txt_diachi);
            this.grb_nhapthongtin.Controls.Add(this.grb_vaitro);
            this.grb_nhapthongtin.Controls.Add(this.grb_gioitinh);
            this.grb_nhapthongtin.Controls.Add(this.txt_tennd);
            this.grb_nhapthongtin.Controls.Add(this.lbl_tennd);
            this.grb_nhapthongtin.Controls.Add(this.lbl_mand);
            this.grb_nhapthongtin.Controls.Add(this.txt_mand);
            this.grb_nhapthongtin.Location = new System.Drawing.Point(2405, 31);
            this.grb_nhapthongtin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_nhapthongtin.Name = "grb_nhapthongtin";
            this.grb_nhapthongtin.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grb_nhapthongtin.Size = new System.Drawing.Size(789, 1309);
            this.grb_nhapthongtin.TabIndex = 3;
            this.grb_nhapthongtin.TabStop = false;
            this.grb_nhapthongtin.Text = "Nhập Thông Tin";
            // 
            // rtxt_hinh
            // 
            this.rtxt_hinh.Location = new System.Drawing.Point(21, 804);
            this.rtxt_hinh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rtxt_hinh.Name = "rtxt_hinh";
            this.rtxt_hinh.Size = new System.Drawing.Size(351, 331);
            this.rtxt_hinh.TabIndex = 17;
            this.rtxt_hinh.Text = "";
            // 
            // btn_mohinh
            // 
            this.btn_mohinh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mohinh.Image = ((System.Drawing.Image)(resources.GetObject("btn_mohinh.Image")));
            this.btn_mohinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mohinh.Location = new System.Drawing.Point(21, 699);
            this.btn_mohinh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_mohinh.Name = "btn_mohinh";
            this.btn_mohinh.Size = new System.Drawing.Size(357, 93);
            this.btn_mohinh.TabIndex = 16;
            this.btn_mohinh.Text = "Mở Hình";
            this.btn_mohinh.UseVisualStyleBackColor = false;
            this.btn_mohinh.Click += new System.EventHandler(this.btn_mohinh_Click);
            // 
            // ptb_hinh
            // 
            this.ptb_hinh.Location = new System.Drawing.Point(389, 699);
            this.ptb_hinh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ptb_hinh.Name = "ptb_hinh";
            this.ptb_hinh.Size = new System.Drawing.Size(379, 439);
            this.ptb_hinh.TabIndex = 15;
            this.ptb_hinh.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(1531, 1016);
            this.btn_next.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(149, 79);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pre.Location = new System.Drawing.Point(1051, 1016);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(149, 79);
            this.btn_pre.TabIndex = 7;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // lbl_sotrang
            // 
            this.lbl_sotrang.AutoSize = true;
            this.lbl_sotrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang.Location = new System.Drawing.Point(1347, 1032);
            this.lbl_sotrang.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_sotrang.Name = "lbl_sotrang";
            this.lbl_sotrang.Size = new System.Drawing.Size(42, 46);
            this.lbl_sotrang.TabIndex = 8;
            this.lbl_sotrang.Text = "1";
            this.lbl_sotrang.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_QLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3403, 1357);
            this.Controls.Add(this.lbl_sotrang);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.dgv_QLNV);
            this.Controls.Add(this.grb_chucnang);
            this.Controls.Add(this.grb_nhapthongtin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_QLND";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.Frm_QLND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).EndInit();
            this.grb_chucnang.ResumeLayout(false);
            this.grb_chucnang.PerformLayout();
            this.grb_vaitro.ResumeLayout(false);
            this.grb_vaitro.PerformLayout();
            this.grb_gioitinh.ResumeLayout(false);
            this.grb_gioitinh.PerformLayout();
            this.grb_nhapthongtin.ResumeLayout(false);
            this.grb_nhapthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLNV;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.GroupBox grb_chucnang;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tennd;
        private System.Windows.Forms.Label lbl_tennd;
        private System.Windows.Forms.Label lbl_mand;
        private System.Windows.Forms.TextBox txt_mand;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_quantri;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_nhanvien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.RichTextBox txt_diachi;
        private System.Windows.Forms.GroupBox grb_vaitro;
        private System.Windows.Forms.GroupBox grb_gioitinh;
        private System.Windows.Forms.GroupBox grb_nhapthongtin;
        private System.Windows.Forms.Button btn_mohinh;
        private System.Windows.Forms.PictureBox ptb_hinh;
        private System.Windows.Forms.RichTextBox rtxt_hinh;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Label lbl_sotrang;
    }
}