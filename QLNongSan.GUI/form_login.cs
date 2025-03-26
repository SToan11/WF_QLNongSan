using QLNongSan.BUS;
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
using QLNongSan.DTO;

namespace QLNongSan.GUi
{
    public partial class form_login : Form
    {
        BUS_DANGNHAP busdangnhap = new BUS_DANGNHAP();
        public static int session = 0;
        public static int profile = 0;
        public static string mail;

        public string vaitro { set; get; }
        public form_login()
        {
            InitializeComponent();
        }

        /* tao chuoi ngau nhien*/
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
        //Tao day so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //Gui email
        public void SendMail(string email, string password)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.Body = "Chào anh/ chị. Mật khẩu mới: " + password;
                Msg.To.Add(email);
                Msg.From = new MailAddress("DuAnQuanLyNongSan@gmail.com");
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential("DuAnQuanLyNongSan@gmail.com", "sqsc sbex rmcs ypjp");
                client.Send(Msg);
                MessageBox.Show("Gửi mail thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_DANGNHAP nv = new DTO_DANGNHAP();
                nv.Email = txt_email.Text;
                string mk = txt_matkhau.Text; //Mật khẩu để so sánh với mật khẩu được mã hóa trong cơ sở dữ liệu
                string mahoamk = busdangnhap.encryption(mk);
                nv.Matkhau = mahoamk;

                if (busdangnhap.NhanVienDangNhap(nv)) // successful login
                {
                    form_login.mail = nv.Email; // Pass the login email to frmMain
                    DataTable dt = busdangnhap.VaiTroNhanVien(nv.Email);
                    vaitro = dt.Rows[0][0].ToString();

                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //session = 1; // trạng thái đăng nhập

                    this.Hide();

                    if (vaitro == "1") // quản lý
                    {
                        using (home hm = new home())
                        {
                            hm.ShowDialog();
                        }
                        this.Close();
                    }
                    else if (vaitro == "0") // nhân viên
                    {
                        using (home_nv hnv = new home_nv())
                        {
                            hnv.ShowDialog();
                        }
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_email.Text = null;
                    txt_matkhau.Text = null;
                    txt_email.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
            }
        }

        private void lkl_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = txt_email.Text.Trim();
            if (!string.IsNullOrEmpty(email))
            {
                if (busdangnhap.NhanVienQuenMatKhau(email))
                {
                    form_login.mail = email;  // Ensure this is set before opening Frm_QuenMK
                    Frm_QuenMK frm_QuenMK = new Frm_QuenMK();
                    frm_QuenMK.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập Email để nhận thông tin phục hồi mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            form_login.session = 0;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chb_ghinho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_ghinho_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_ghinho.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
