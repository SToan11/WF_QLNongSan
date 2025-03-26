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
using System.IO;

namespace QLNongSan.GUI
{
    public partial class Frm_QLND : Form
    {
        private BUS_QLND BUS_QLND = new BUS_QLND();
        private string checkUrlImage;
        private string fileName;
        private string fileSavePath;
        private string fileAddress;
        private int sotrang = 1;
        private int kichthuoctrang = 5;

        public Frm_QLND()
        {
            InitializeComponent();
        }

        private void LoadGridView_NguoiDung()
        {
            dgv_QLNV.DataSource = BUS_QLND.getNguoiDung(sotrang, kichthuoctrang);
            dgv_QLNV.Columns[0].HeaderText = "Mã Người Dùng";
            dgv_QLNV.Columns[1].HeaderText = "Tên Người Dùng";
            dgv_QLNV.Columns[2].HeaderText = "Giới Tính";
            dgv_QLNV.Columns[3].HeaderText = "Vai Trò";
            dgv_QLNV.Columns[4].HeaderText = "Địa Chỉ";
            dgv_QLNV.Columns[5].HeaderText = "Email";
            dgv_QLNV.Columns[6].HeaderText = "Số Điện Thoại";
            dgv_QLNV.Columns[7].HeaderText = "Hình Ảnh";
        }

        private void ResetValues()
        {
            if (ptb_hinh.Image != null)
            {
                ptb_hinh.Image.Dispose();
                ptb_hinh.Image = null;
            }
            lbl_sotrang.Text = sotrang.ToString();
            txt_mand.Text = null;
            txt_tennd.Text = null;
            rdo_nam.Checked = true;
            rdo_nu.Checked = false;
            rdo_quantri.Checked = true;
            rdo_nhanvien.Checked = false;
            txt_diachi.Text = null;
            txt_email.Text = null;
            txt_sdt.Text = null;
            ptb_hinh.Image = null;
            rtxt_hinh.Text = null;
            txt_timkiem.Text = "Nhập tên nhân viên";
            txt_timkiem.BackColor = Color.LightGray;
        }

        private void ResetThongTin()
        {
            if (ptb_hinh.Image != null)
            {
                ptb_hinh.Image.Dispose();
                ptb_hinh.Image = null;
            }
            txt_mand.Text = null;
            txt_tennd.Text = null;
            rdo_nam.Checked = true;
            rdo_nu.Checked = false;
            rdo_quantri.Checked = true;
            rdo_nhanvien.Checked = false;
            txt_diachi.Text = null;
            txt_email.Text = null;
            txt_sdt.Text = null;
            ptb_hinh.Image = null;
            rtxt_hinh.Text = null;
        }

        private void Frm_QLND_Load(object sender, EventArgs e)
        {
            LoadGridView_NguoiDung();
            ResetValues();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadGridView_NguoiDung();
            ResetValues();
            if (ptb_hinh.Image != null)
            {
                ptb_hinh.Image.Dispose();
                ptb_hinh.Image = null;
            }
            btn_next.Enabled = true;
            btn_pre.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetThongTin();
        }

        public bool isValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void SendMail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("duanquanlynongsan@gmail.com", "sqsc sbex rmcs ypjp");
                MailMessage Msg = new MailMessage
                {
                    From = new MailAddress("duanquanlynongsan@gmail.com"),
                    Subject = "Chào Mừng Thành Viên Mới",
                    Body = "Chào anh/chị. Mật khẩu truy cập phần mềm là abc123, anh/chị vui lòng đăng nhập vào phần mềm và đổi mật khẩu"
                };
                Msg.To.Add(email);
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Gửi Mail Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgv_QLNV.Rows.Count > 1)
            {
                txt_mand.Text = dgv_QLNV.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
                txt_tennd.Text = dgv_QLNV.CurrentRow.Cells["TenNguoiDung"].Value.ToString();
                txt_diachi.Text = dgv_QLNV.CurrentRow.Cells["DiaChi"].Value.ToString();
                txt_email.Text = dgv_QLNV.CurrentRow.Cells["Email"].Value.ToString();
                txt_sdt.Text = dgv_QLNV.CurrentRow.Cells["SDT"].Value.ToString();
                rtxt_hinh.Text = dgv_QLNV.CurrentRow.Cells["Hinh"].Value.ToString();
                checkUrlImage = rtxt_hinh.Text;
                ptb_hinh.Image = Image.FromFile(saveDirectory + dgv_QLNV.CurrentRow.Cells["Hinh"].Value.ToString());
                if (dgv_QLNV.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rdo_nam.Checked = true;
                }
                else
                {
                    rdo_nu.Checked = true;
                }
                if (int.Parse(dgv_QLNV.CurrentRow.Cells["vaiTro"].Value.ToString()) == 1)
                {
                    rdo_quantri.Checked = true;
                }
                else
                {
                    rdo_nhanvien.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng Không Tồn Tại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int role = rdo_quantri.Checked ? 1 : 0;
            string gioitinh = rdo_nu.Checked ? "Nữ" : "Nam";
            if (string.IsNullOrWhiteSpace(txt_tennd.Text) && string.IsNullOrWhiteSpace(txt_sdt.Text) && string.IsNullOrWhiteSpace(txt_email.Text) && string.IsNullOrWhiteSpace(txt_diachi.Text) && !rdo_nam.Checked && !rdo_nu.Checked && !rdo_quantri.Checked && !rdo_nhanvien.Checked && rtxt_hinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennd.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tennd.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Người Dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            if (!int.TryParse(txt_sdt.Text, out int sdt))
            {
                MessageBox.Show("Số Điện Thoại Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            if (txt_sdt.TextLength != 10)
            {
                MessageBox.Show("Số Điện Thoại Phải Đúng Mười Ký Tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }
            else if (!isValid(txt_email.Text.Trim()))
            {
                MessageBox.Show("Bạn Phải Nhập Đúng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Địa Chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }

            if (!rdo_quantri.Checked && !rdo_nhanvien.Checked)
            {
                MessageBox.Show("Vui Lòng Chọn Vai Trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!rdo_nam.Checked && !rdo_nu.Checked)
            {
                MessageBox.Show("Vui Lòng Chọn Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rtxt_hinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Phải Upload Hình Đại Diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_mohinh.Focus();
                return;
            }

            DTO_QLND nd = new DTO_QLND(txt_email.Text.Trim(), txt_tennd.Text.Trim(), txt_diachi.Text.Trim(), role, gioitinh, sdt, "\\AnhNguoiDung\\" + fileName);
            DTO_QLND kt = new DTO_QLND(txt_tennd.Text.Trim(), txt_email.Text.Trim());

            if (!BUS_QLND.kiemTra(kt))
            {
                if (BUS_QLND.themNguoiDung(nd))
                {
                    MessageBox.Show("Thêm Thành Công");
                    File.Copy(fileAddress, fileSavePath, true);
                    ResetValues();
                    LoadGridView_NguoiDung();
                    SendMail(nd.EmailND);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (BUS_QLND.kiemTra(kt) && BUS_QLND.kiemTraXoa(kt))
            {
                if (BUS_QLND.phucHoiNguoiDung(nd))
                {
                    MessageBox.Show("Phục hồi Thành Công");
                    File.Copy(fileAddress, fileSavePath, true);
                    ResetValues();
                    LoadGridView_NguoiDung();
                    SendMail(nd.EmailND);
                }
                else
                {
                    MessageBox.Show("Phục hồi Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (BUS_QLND.kiemTra(kt) && !BUS_QLND.kiemTraXoa(kt))
            {
                MessageBox.Show("Phát Hiện Người Dùng Đã Có, Vui Lòng Chỉnh Sửa Thay Vì Thêm Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int role = rdo_quantri.Checked ? 1 : 0;
            string gioitinh = rdo_nu.Checked ? "Nữ" : "Nam";
            if (string.IsNullOrWhiteSpace(txt_tennd.Text) && string.IsNullOrWhiteSpace(txt_sdt.Text) && string.IsNullOrWhiteSpace(txt_email.Text) && string.IsNullOrWhiteSpace(txt_diachi.Text) && !rdo_nam.Checked && !rdo_nu.Checked && !rdo_quantri.Checked && !rdo_nhanvien.Checked && rtxt_hinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tennd.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Người Dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            if (!int.TryParse(txt_sdt.Text, out int sdt))
            {
                MessageBox.Show("Số Điện Thoại Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            if (txt_sdt.TextLength != 10)
            {
                MessageBox.Show("Số Điện Thoại Phải Đúng Mười Ký Tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }
            else if (!isValid(txt_email.Text.Trim()))
            {
                MessageBox.Show("Bạn Phải Nhập Đúng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Địa Chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }

            if (!rdo_quantri.Checked && !rdo_nhanvien.Checked)
            {
                MessageBox.Show("Vui Lòng Chọn Vai Trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!rdo_nam.Checked && !rdo_nu.Checked)
            {
                MessageBox.Show("Vui Lòng Chọn Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DTO_QLND nd = new DTO_QLND(txt_email.Text.Trim(), txt_tennd.Text.Trim(), txt_diachi.Text.Trim(), role, gioitinh, sdt, rtxt_hinh.Text);
            if (MessageBox.Show("Bạn Có Chắc Muốn Chỉnh Sửa", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (BUS_QLND.updateNguoiDung(nd))
                {
                    if (rtxt_hinh.Text != checkUrlImage)
                    {
                        ptb_hinh.Image = null;
                        File.Copy(fileAddress, fileSavePath, true);
                    }
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    LoadGridView_NguoiDung();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            if (MessageBox.Show("Bạn Có Chắc Muốn Xóa Dữ Liệu", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BUS_QLND.deleteNguoiDung(email))
                {
                    MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    LoadGridView_NguoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tennd = txt_timkiem.Text;
            DataTable ds = BUS_QLND.searchNguoiDung(tennd);
            if (ds.Rows.Count > 0)
            {
                dgv_QLNV.DataSource = ds;
                dgv_QLNV.Columns[0].HeaderText = "Mã Người Dùng";
                dgv_QLNV.Columns[1].HeaderText = "Tên Người Dùng";
                dgv_QLNV.Columns[2].HeaderText = "Giới Tính";
                dgv_QLNV.Columns[3].HeaderText = "Vai Trò";
                dgv_QLNV.Columns[4].HeaderText = "Địa Chỉ";
                dgv_QLNV.Columns[5].HeaderText = "Email";
                dgv_QLNV.Columns[6].HeaderText = "Số Điện Thoại";
                btn_next.Enabled = false;
                btn_pre.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetValues();
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = null;
            txt_timkiem.BackColor = Color.White;
        }

        private void btn_mohinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog
            {
                Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|PNG(*.png)|*.png|All files(*.*)|*.*",
                FilterIndex = 2,
                Title = "Chọn ảnh người dùng"
            };
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                ptb_hinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);

                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = Path.Combine(saveDirectory, "AnhNguoiDung", fileName);
                rtxt_hinh.Text = Path.Combine("AnhNguoiDung", fileName);
            }
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (sotrang > 1)
            {
                sotrang--;
                lbl_sotrang.Text = sotrang.ToString();
                LoadGridView_NguoiDung();
                
            }
            else
            {
                
                MessageBox.Show("Bạn đã ở trang đầu tiên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int tongsodulieu = BUS_QLND.getTongNguoiDung();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            if (sotrang < totalPages)
            {
                sotrang++;
                lbl_sotrang.Text = sotrang.ToString();
                LoadGridView_NguoiDung();
            }
            else
            {
                
                MessageBox.Show("Bạn đã ở trang cuối cùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
