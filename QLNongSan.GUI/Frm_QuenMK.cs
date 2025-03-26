using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNongSan.BUS;
using System.Reflection;

namespace QLNongSan.GUi
{
    public partial class Frm_QuenMK : Form
    {
        BUS_DANGNHAP bus_dangnhap = new BUS_DANGNHAP();
        string mabaomat = "";
        public Frm_QuenMK()
        {
            InitializeComponent();
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        //Gui email bao mat
        public void SendMailBaoMat(string email, string mabaomat)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.Body = "Chào anh/ chị. Mã Bảo Mật Là: " + mabaomat;
                Msg.To.Add(email);
                Msg.From = new MailAddress("DuAnQuanLyNongSan@gmail.com");
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential("DuAnQuanLyNongSan@gmail.com", "sqsc sbex rmcs ypjp");
                client.Send(Msg);
                MessageBox.Show("Kiểm Tra Hoàn Tất, Một Mã Bảo Mật Đã Được Gửi Tới Email Của Bạn","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void xacnhan_btn_Click(object sender, EventArgs e)
        {
            string nhaplaimk = nhaplaimatkhau_txt.Text;
            if (string.IsNullOrEmpty(matkhaumoi_text.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (matkhaumoi_text.Text.Length < 8)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu từ 8 ký tự trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matkhaumoi_text.Text != nhaplaimk)
            {
                MessageBox.Show("Mật Khẩu Không Khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (mabaomat != mabaomat_txt.Text)
            {
                MessageBox.Show("Mã Bảo Mật Không Đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (bus_dangnhap.NhanVienQuenMatKhau(form_login.mail))
            {
                string matkhaumoi = bus_dangnhap.encryption(matkhaumoi_text.Text);
                bus_dangnhap.capNhatMK(form_login.mail, matkhaumoi);
                MessageBox.Show("Cập Nhật Mật Khẩu Thành Công. Vui Lòng Đăng Nhập Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Frm_QuenMK_Load(object sender, EventArgs e)
        {
            mabaomat = RandomString(6, true);
            SendMailBaoMat(form_login.mail, mabaomat);
        }
    }
}
