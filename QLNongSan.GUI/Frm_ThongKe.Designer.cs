namespace QLNongSan.GUi
{
    partial class Frm_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_timst = new System.Windows.Forms.Button();
            this.txt_sotrangmuontim = new System.Windows.Forms.TextBox();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_st2 = new System.Windows.Forms.Button();
            this.btn_st1 = new System.Windows.Forms.Button();
            this.lbl_3cham = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.btn_xuat);
            this.panel1.Controls.Add(this.btn_timst);
            this.panel1.Controls.Add(this.txt_sotrangmuontim);
            this.panel1.Controls.Add(this.btn_total);
            this.panel1.Controls.Add(this.btn_st2);
            this.panel1.Controls.Add(this.btn_st1);
            this.panel1.Controls.Add(this.lbl_3cham);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_pre);
            this.panel1.Controls.Add(this.dgv_thongke);
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.txt_timkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3187, 1476);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1989, 148);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1415, 949);
            this.chart1.TabIndex = 42;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(1708, 960);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(222, 93);
            this.btn_xuat.TabIndex = 41;
            this.btn_xuat.Text = "Xuất Thống Kê";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_timst
            // 
            this.btn_timst.BackColor = System.Drawing.SystemColors.Control;
            this.btn_timst.Image = ((System.Drawing.Image)(resources.GetObject("btn_timst.Image")));
            this.btn_timst.Location = new System.Drawing.Point(1005, 248);
            this.btn_timst.Margin = new System.Windows.Forms.Padding(6);
            this.btn_timst.Name = "btn_timst";
            this.btn_timst.Size = new System.Drawing.Size(114, 59);
            this.btn_timst.TabIndex = 33;
            this.btn_timst.UseVisualStyleBackColor = false;
            this.btn_timst.Click += new System.EventHandler(this.btn_timst_Click);
            // 
            // txt_sotrangmuontim
            // 
            this.txt_sotrangmuontim.Location = new System.Drawing.Point(893, 256);
            this.txt_sotrangmuontim.Name = "txt_sotrangmuontim";
            this.txt_sotrangmuontim.Size = new System.Drawing.Size(100, 38);
            this.txt_sotrangmuontim.TabIndex = 40;
            this.txt_sotrangmuontim.TextChanged += new System.EventHandler(this.txt_sotrangmuontim_TextChanged);
            // 
            // btn_total
            // 
            this.btn_total.BackColor = System.Drawing.Color.White;
            this.btn_total.Location = new System.Drawing.Point(1059, 1027);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(51, 48);
            this.btn_total.TabIndex = 39;
            this.btn_total.Text = "2";
            this.btn_total.UseVisualStyleBackColor = false;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_st2
            // 
            this.btn_st2.BackColor = System.Drawing.Color.White;
            this.btn_st2.Location = new System.Drawing.Point(865, 1025);
            this.btn_st2.Name = "btn_st2";
            this.btn_st2.Size = new System.Drawing.Size(51, 48);
            this.btn_st2.TabIndex = 38;
            this.btn_st2.Text = "2";
            this.btn_st2.UseVisualStyleBackColor = false;
            this.btn_st2.Click += new System.EventHandler(this.btn_st2_Click);
            // 
            // btn_st1
            // 
            this.btn_st1.BackColor = System.Drawing.Color.White;
            this.btn_st1.Location = new System.Drawing.Point(796, 1027);
            this.btn_st1.Name = "btn_st1";
            this.btn_st1.Size = new System.Drawing.Size(51, 48);
            this.btn_st1.TabIndex = 37;
            this.btn_st1.Text = "1";
            this.btn_st1.UseVisualStyleBackColor = false;
            this.btn_st1.Click += new System.EventHandler(this.btn_st1_Click);
            // 
            // lbl_3cham
            // 
            this.lbl_3cham.AutoSize = true;
            this.lbl_3cham.BackColor = System.Drawing.Color.White;
            this.lbl_3cham.Location = new System.Drawing.Point(981, 1034);
            this.lbl_3cham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_3cham.Name = "lbl_3cham";
            this.lbl_3cham.Size = new System.Drawing.Size(38, 32);
            this.lbl_3cham.TabIndex = 36;
            this.lbl_3cham.Text = "...";
            this.lbl_3cham.Click += new System.EventHandler(this.lbl_3cham_Click);
            // 
            // btn_next
            // 
            this.btn_next.AutoSize = true;
            this.btn_next.Location = new System.Drawing.Point(1138, 1027);
            this.btn_next.Margin = new System.Windows.Forms.Padding(6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(150, 48);
            this.btn_next.TabIndex = 35;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(622, 1027);
            this.btn_pre.Margin = new System.Windows.Forms.Padding(6);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(150, 48);
            this.btn_pre.TabIndex = 34;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(54, 341);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.RowTemplate.Height = 24;
            this.dgv_thongke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongke.Size = new System.Drawing.Size(1876, 610);
            this.dgv_thongke.TabIndex = 28;
            this.dgv_thongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongke_CellContentClick);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(1346, 243);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(212, 68);
            this.btn_lammoi.TabIndex = 27;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(1346, 132);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(212, 68);
            this.btn_timkiem.TabIndex = 25;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(730, 150);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(572, 38);
            this.txt_timkiem.TabIndex = 24;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(912, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê sản phẩm";
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3187, 1476);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThongKe";
            this.Text = "Frm_ThongKe";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.Button btn_timst;
        private System.Windows.Forms.TextBox txt_sotrangmuontim;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_st2;
        private System.Windows.Forms.Button btn_st1;
        private System.Windows.Forms.Label lbl_3cham;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}