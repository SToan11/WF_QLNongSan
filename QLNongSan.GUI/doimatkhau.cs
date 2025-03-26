using QLNongSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNongSan.GUi
{
    public partial class doimatkhau : Form
    {
        private BUS_DOIMATKHAU busDoiMatKhau = new BUS_DOIMATKHAU();

        public doimatkhau()
        {
            InitializeComponent();
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void doimatkhau_btn_Click(object sender, EventArgs e)
        {
            string email = emailhientai.Text.Trim();
            string oldPassword = matkhauhientai_txt.Text;
            string oldpassword_mh = busDoiMatKhau.encryption(oldPassword);
            string newPassword = matkhaumoi_text.Text;
            string newpassword_mh = busDoiMatKhau.encryption(newPassword);

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword.Length < 8)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu từ 8 ký tự trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matkhaumoi_text.Text !=  nhaplaimatkhau_txt.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isChanged = busDoiMatKhau.ChangePassword(email, oldpassword_mh, newpassword_mh);

            if (isChanged)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doimatkhau_btn_Click_1(object sender, EventArgs e)
        {
            string email = emailhientai.Text.Trim();
            string oldPassword = matkhauhientai_txt.Text;
            string oldpassword_mh = busDoiMatKhau.encryption(oldPassword);
            string newPassword = matkhaumoi_text.Text;
            string newpassword_mh = busDoiMatKhau.encryption(newPassword);

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword.Length < 8)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu từ 8 ký tự trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matkhaumoi_text.Text != nhaplaimatkhau_txt.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isChanged = busDoiMatKhau.ChangePassword(email, oldpassword_mh, newpassword_mh);

            if (isChanged)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
