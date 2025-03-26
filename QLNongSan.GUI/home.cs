using QLNongSan.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNongSan.GUi
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            // this.FormClosing += new FormClosingEventHandler(home_FormClosing);
        }

        private void home_Load(object sender, EventArgs e)
        {
            //PhanQuyen();
        }

        //private void PhanQuyen()
        //{
        //    if (form_login.session == 0)
        //    {
        //        btn_nguoidung.Visible = false;
        //        btn_thongke.Visible = false;
        //    }
        //        else if (form_login.session == 1)
        //        {
        //        if (form_login.profile == 0) // Employee
        //        {
        //            btn_nguoidung.Visible = false;
        //            btn_thongke.Visible = false;
        //        }
        //        else if (form_login.profile == 1) // Manager
        //        {
        //            btn_nguoidung.Visible = true;
        //            btn_thongke.Visible = true;
        //        }
        //    }
        //}

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(childForm);
            pnl_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_home.Text;
            this.WindowState = FormWindowState.Maximized;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_sanpham.Text;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new Frm_SanPham());
        }

        private void btn_loaisp_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_loaisp.Text;
            //this.WindowState= FormWindowState.Normal;
            OpenChildForm(new Frm_LoaiHang());
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_khachhang.Text;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new form_quanlykhachhang());
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_hoadon.Text;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new Frm_HoaDon());
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_thongke.Text;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new Frm_ThongKe());
        }

        private void btn_nguoidung_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_nguoidung.Text;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new Frm_QLND());
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_doimk.Text;
            //this.WindowState = FormWindowState.Normal;
            //OpenChildForm(new doimatkhau());
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();
            if (dmk != null)
            {
                lbl_text.Text = btn_home.Text;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_thongtin.Text;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new Frm_GTSP());
        }

        private void btn_dhsudung_Click(object sender, EventArgs e)
        {
            string url = "https://onedrive.live.com/edit?id=F558DDA6F7916754!113&resid=F558DDA6F7916754!113&ithint=file%2cdocx&authkey=!AL438U5EgbwV4T8&wdo=2&cid=f558dda6f7916754";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi mở trình duyệt: " + ex.Message);
            }
        }

        private void btn_hotro_Click(object sender, EventArgs e)
        {
            lbl_text.Text = btn_hotro.Text;
            this.WindowState = FormWindowState.Maximized;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            Frm_HoTro ht = new Frm_HoTro();
            ht.ShowDialog();
            if (ht != null)
            {
                lbl_text.Text = btn_home.Text;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban có muốn thoát không ?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                form_login f1 = new form_login();
                f1.ShowDialog();
                this.Close();
            }
        }
        //private void home_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Bạn có muốn quay về trang đăng nhập không? Chọn 'Yes' để quay lại hoặc 'No' để thoát hoàn toàn chương trình.", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        //
        //    if (result == DialogResult.Yes)
        //    {
                // quay về màn hình đăng nhập
        //        this.Hide();
        //        form_login lg = new form_login();
        //        lg.ShowDialog();
        //        this.Close(); 
        //    }
        //    else if (result == DialogResult.No)
        //    {
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
