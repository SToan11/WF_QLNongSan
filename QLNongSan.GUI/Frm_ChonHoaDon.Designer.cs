namespace QLNongSan.GUi
{
    partial class Frm_ChonHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChonHoaDon));
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.lbl_caudan1 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_sotrang = new System.Windows.Forms.Label();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.lbl_mahd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(24, 97);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.ReadOnly = true;
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoadon.Size = new System.Drawing.Size(1552, 448);
            this.dgv_hoadon.TabIndex = 0;
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // lbl_caudan1
            // 
            this.lbl_caudan1.AutoSize = true;
            this.lbl_caudan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caudan1.Location = new System.Drawing.Point(24, 17);
            this.lbl_caudan1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_caudan1.Name = "lbl_caudan1";
            this.lbl_caudan1.Size = new System.Drawing.Size(699, 53);
            this.lbl_caudan1.TabIndex = 1;
            this.lbl_caudan1.Text = "Chọn Hóa Đơn Có Trong Cơ Sở";
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.Lime;
            this.btn_xacnhan.Location = new System.Drawing.Point(224, 854);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(6);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(454, 81);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_thoat.Location = new System.Drawing.Point(886, 854);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(470, 81);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_sotrang
            // 
            this.lbl_sotrang.AutoSize = true;
            this.lbl_sotrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang.Location = new System.Drawing.Point(760, 734);
            this.lbl_sotrang.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_sotrang.Name = "lbl_sotrang";
            this.lbl_sotrang.Size = new System.Drawing.Size(42, 46);
            this.lbl_sotrang.TabIndex = 11;
            this.lbl_sotrang.Text = "1";
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pre.Location = new System.Drawing.Point(464, 719);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(150, 79);
            this.btn_pre.TabIndex = 10;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(944, 719);
            this.btn_next.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(150, 79);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(634, 614);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(6);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.ReadOnly = true;
            this.txt_mahd.Size = new System.Drawing.Size(476, 38);
            this.txt_mahd.TabIndex = 13;
            // 
            // lbl_mahd
            // 
            this.lbl_mahd.AutoSize = true;
            this.lbl_mahd.Location = new System.Drawing.Point(458, 618);
            this.lbl_mahd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mahd.Name = "lbl_mahd";
            this.lbl_mahd.Size = new System.Drawing.Size(171, 32);
            this.lbl_mahd.TabIndex = 14;
            this.lbl_mahd.Text = "Mã Hóa Đơn";
            // 
            // Frm_ChonHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 959);
            this.Controls.Add(this.lbl_mahd);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.lbl_sotrang);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.lbl_caudan1);
            this.Controls.Add(this.dgv_hoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_ChonHoaDon";
            this.Text = "Chọn hóa đơn";
            this.Load += new System.EventHandler(this.Frm_ChonHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label lbl_caudan1;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_sotrang;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label lbl_mahd;
    }
}