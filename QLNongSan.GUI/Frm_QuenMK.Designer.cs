namespace QLNongSan.GUi
{
    partial class Frm_QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuenMK));
            this.xacnhan_btn = new System.Windows.Forms.Button();
            this.nhaplaimatkhau_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matkhaumoi_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_quenmk = new System.Windows.Forms.Label();
            this.mabaomat_txt = new System.Windows.Forms.TextBox();
            this.lbl_mabaomat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xacnhan_btn
            // 
            this.xacnhan_btn.BackColor = System.Drawing.SystemColors.Info;
            this.xacnhan_btn.Location = new System.Drawing.Point(136, 323);
            this.xacnhan_btn.Name = "xacnhan_btn";
            this.xacnhan_btn.Size = new System.Drawing.Size(119, 58);
            this.xacnhan_btn.TabIndex = 25;
            this.xacnhan_btn.Text = "Xác Nhận";
            this.xacnhan_btn.UseVisualStyleBackColor = false;
            this.xacnhan_btn.Click += new System.EventHandler(this.xacnhan_btn_Click);
            // 
            // nhaplaimatkhau_txt
            // 
            this.nhaplaimatkhau_txt.Location = new System.Drawing.Point(100, 284);
            this.nhaplaimatkhau_txt.Name = "nhaplaimatkhau_txt";
            this.nhaplaimatkhau_txt.Size = new System.Drawing.Size(206, 22);
            this.nhaplaimatkhau_txt.TabIndex = 24;
            this.nhaplaimatkhau_txt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // matkhaumoi_text
            // 
            this.matkhaumoi_text.Location = new System.Drawing.Point(100, 203);
            this.matkhaumoi_text.Name = "matkhaumoi_text";
            this.matkhaumoi_text.Size = new System.Drawing.Size(206, 22);
            this.matkhaumoi_text.TabIndex = 22;
            this.matkhaumoi_text.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mật khẩu mới";
            // 
            // lbl_quenmk
            // 
            this.lbl_quenmk.AutoSize = true;
            this.lbl_quenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quenmk.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_quenmk.Location = new System.Drawing.Point(25, 9);
            this.lbl_quenmk.Name = "lbl_quenmk";
            this.lbl_quenmk.Size = new System.Drawing.Size(362, 54);
            this.lbl_quenmk.TabIndex = 26;
            this.lbl_quenmk.Text = "Quên Mật Khẩu";
            // 
            // mabaomat_txt
            // 
            this.mabaomat_txt.Location = new System.Drawing.Point(100, 130);
            this.mabaomat_txt.Name = "mabaomat_txt";
            this.mabaomat_txt.Size = new System.Drawing.Size(206, 22);
            this.mabaomat_txt.TabIndex = 28;
            this.mabaomat_txt.UseSystemPasswordChar = true;
            // 
            // lbl_mabaomat
            // 
            this.lbl_mabaomat.AutoSize = true;
            this.lbl_mabaomat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mabaomat.Location = new System.Drawing.Point(100, 94);
            this.lbl_mabaomat.Name = "lbl_mabaomat";
            this.lbl_mabaomat.Size = new System.Drawing.Size(115, 22);
            this.lbl_mabaomat.TabIndex = 27;
            this.lbl_mabaomat.Text = "Mã Bảo Mật";
            // 
            // Frm_QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(399, 412);
            this.Controls.Add(this.mabaomat_txt);
            this.Controls.Add(this.lbl_mabaomat);
            this.Controls.Add(this.lbl_quenmk);
            this.Controls.Add(this.xacnhan_btn);
            this.Controls.Add(this.nhaplaimatkhau_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matkhaumoi_text);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_QuenMK";
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.Frm_QuenMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xacnhan_btn;
        private System.Windows.Forms.TextBox nhaplaimatkhau_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox matkhaumoi_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_quenmk;
        private System.Windows.Forms.TextBox mabaomat_txt;
        private System.Windows.Forms.Label lbl_mabaomat;
    }
}