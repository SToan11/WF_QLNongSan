using QLNongSan.BUS;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNongSan.GUi
{
    public partial class Frm_HoTro : Form
    {
        public Frm_HoTro()
        {
            InitializeComponent();
            this.FormClosing += Frm_HoTro_FormClosing;
        }
        private void Frm_HoTro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txt_email.Text.Length != 0 || txt_vd.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the closing operation
                }
            }
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail\.com(\.vn)?$");
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập email");
                return;
            }

            if (txt_vd.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa ghi phản hồi");
                return;
            }

            if (!checkEmail(txt_email.Text))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn muốn góp ý như trên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Hotro_khachhang())
                {
                    MessageBox.Show("Thành công! \nCảm ơn bạn đã góp ý!");
                    txt_email.Text = "";
                    txt_vd.Text = "";
                    dtp_ngayhotro.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Thất bại! Không gửi được phản hồi.");
                }
            }
            else
            {
                MessageBox.Show("Chưa gửi phản hồi!");
            }
        }


        public bool Hotro_khachhang()
        {
            var ht = new DTO_HoTro
            {
                Email = txt_email.Text,
                NoiDung = txt_vd.Text,
                ThoiGian = dtp_ngayhotro.Value
            };

            var busHoTro = new BUS_HoTro();
            return busHoTro.HoTroKH(ht);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length == 0 || txt_vd.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa ghi");
            }
            else if (txt_vd.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa ghi phản hồi");
            }
            else if (txt_email.Text.Length != 0 || txt_vd.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn làm mới không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txt_email.Text = "";
                    txt_vd.Text = "";
                }
                else
                {

                }
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Length != 0 || txt_vd.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
