﻿namespace QLNongSan.GUi
{
    partial class Frm_HoTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoTro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_vd = new System.Windows.Forms.TextBox();
            this.btn_gui = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.dtp_ngayhotro = new System.Windows.Forms.DateTimePicker();
            this.btn_dong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 62);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hỗ trợ khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vấn đề cần hỗ trợ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(741, 213);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(644, 38);
            this.txt_email.TabIndex = 12;
            // 
            // txt_vd
            // 
            this.txt_vd.Location = new System.Drawing.Point(741, 316);
            this.txt_vd.Multiline = true;
            this.txt_vd.Name = "txt_vd";
            this.txt_vd.Size = new System.Drawing.Size(644, 286);
            this.txt_vd.TabIndex = 13;
            // 
            // btn_gui
            // 
            this.btn_gui.Location = new System.Drawing.Point(506, 719);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(277, 105);
            this.btn_gui.TabIndex = 14;
            this.btn_gui.Text = "Gửi";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(904, 719);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(277, 105);
            this.btn_lammoi.TabIndex = 15;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // dtp_ngayhotro
            // 
            this.dtp_ngayhotro.CustomFormat = "hh:mm:ss dd/MM/yyyy ";
            this.dtp_ngayhotro.Enabled = false;
            this.dtp_ngayhotro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayhotro.Location = new System.Drawing.Point(317, 409);
            this.dtp_ngayhotro.Name = "dtp_ngayhotro";
            this.dtp_ngayhotro.Size = new System.Drawing.Size(390, 38);
            this.dtp_ngayhotro.TabIndex = 16;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(697, 897);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(277, 105);
            this.btn_dong.TabIndex = 17;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_dong);
            this.panel1.Controls.Add(this.dtp_ngayhotro);
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.btn_gui);
            this.panel1.Controls.Add(this.txt_vd);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1847, 1122);
            this.panel1.TabIndex = 0;
            // 
            // Frm_HoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1847, 1122);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HoTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hỗ trợ khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_vd;
        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.DateTimePicker dtp_ngayhotro;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Panel panel1;
    }
}