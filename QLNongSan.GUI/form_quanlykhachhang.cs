using QLNongSan.BUS;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLNongSan.GUi
{
    public partial class form_quanlykhachhang : Form
    {
        private BUS_KhachHang busKhachHang;
        private int sotrang = 1;
        private int kichthuoctrang = 5;
        public form_quanlykhachhang()
        {
            InitializeComponent();
            busKhachHang = new BUS_KhachHang();
        }


        private void LoadData()
        {
            List<DTO_KHACHHANG> danhSachKhachHang = busKhachHang.HienThiKhachHang(sotrang, kichthuoctrang);
            dgv_QLKH.DataSource = danhSachKhachHang;
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            var kh = new DTO_KHACHHANG
            {
                MaKhachHang = txt_mand.Text,
                TenKhachHang = txt_tennd.Text,
                GioiTinh = rdo_nam.Checked ? "Nam" : "Nữ",
                DiaChi = txt_diachi.Text,
                Email = txt_email.Text,
                SDT = txt_sdt.Text
            };
            var kt = new DTO_KHACHHANG
            {
                TenKhachHang = txt_tennd.Text,
                Email = txt_email.Text
            };

            string gioitinh = rdo_nu.Checked ? "Nữ" : "Nam";
            if (string.IsNullOrWhiteSpace(txt_tennd.Text) && string.IsNullOrWhiteSpace(txt_sdt.Text) && string.IsNullOrWhiteSpace(txt_email.Text) && string.IsNullOrWhiteSpace(txt_diachi.Text) && !rdo_nam.Checked && !rdo_nu.Checked)
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tennd.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennd.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Điện Thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            if (!long.TryParse(txt_sdt.Text, out long sdt))
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

            if (!rdo_nam.Checked && !rdo_nu.Checked)
            {
                MessageBox.Show("Vui Lòng Chọn Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!busKhachHang.kiemTra(kt))
            {
                bool result = busKhachHang.ThemKhachHang(kh);
                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (busKhachHang.kiemTra(kt) && busKhachHang.kiemTraXoa(kt))
            {
                if (busKhachHang.phucHoiKhachHang(kh))
                {
                    MessageBox.Show("Phục hồi Thành Công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Phục hồi Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (busKhachHang.kiemTra(kt) && !busKhachHang.kiemTraXoa(kt))
            {
                MessageBox.Show("Phát Hiện Khách Hàng Đã Có, Vui Lòng Chỉnh Sửa Thay Vì Thêm Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string gioitinh = rdo_nu.Checked ? "Nữ" : "Nam";
            if (string.IsNullOrWhiteSpace(txt_tennd.Text) && string.IsNullOrWhiteSpace(txt_sdt.Text) && string.IsNullOrWhiteSpace(txt_email.Text) && string.IsNullOrWhiteSpace(txt_diachi.Text) && !rdo_nam.Checked && !rdo_nu.Checked)
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

            if (!long.TryParse(txt_sdt.Text, out long sdt))
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

            if (!rdo_nam.Checked && !rdo_nu.Checked)
            {
                MessageBox.Show("Vui Lòng Chọn Giới Tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var kh = new DTO_KHACHHANG
            {
                MaKhachHang = txt_mand.Text,
                TenKhachHang = txt_tennd.Text,
                GioiTinh = rdo_nam.Checked ? "Nam" : "Nữ",
                DiaChi = txt_diachi.Text,
                Email = txt_email.Text,
                SDT = txt_sdt.Text
            };

            bool result = busKhachHang.SuaKhachHang(kh);
            if (result)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa thông tin khách hàng.","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maKhachHang = txt_mand.Text;

            if (string.IsNullOrEmpty(maKhachHang))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool result = busKhachHang.XoaKhachHang(maKhachHang);
            if (result)
            {
                MessageBox.Show("Xóa khách hàng thành công!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa khách hàng,", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            LoadData();


        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_mand.Clear();
            txt_tennd.Clear();
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            txt_timkiem.Clear();

            rdo_nam.Checked = true; // Hoặc mặc định giới tính là Nam
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txt_timkiem.Text;
            List<DTO_KHACHHANG> danhSachKhachHang = busKhachHang.TimKhachHang(tuKhoa);
            dgv_QLKH.DataSource = danhSachKhachHang;

        }
        
        private void form_quanlykhachhang_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void dgv_QLKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_QLKH.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_QLKH.SelectedRows[0];

                // Lấy dữ liệu từ dòng đã chọn
                string maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                string tenKhachHang = selectedRow.Cells["TenKhachHang"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string sdt = selectedRow.Cells["SDT"].Value.ToString();

                // Hiển thị dữ liệu lên các điều khiển
                txt_mand.Text = maKhachHang;
                txt_tennd.Text = tenKhachHang;
                txt_diachi.Text = diaChi;
                txt_email.Text = email;
                txt_sdt.Text = sdt;
                rdo_nam.Checked = gioiTinh == "Nam";
                rdo_nu.Checked = gioiTinh == "Nữ";
            }
        }

        private void dgv_QLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (sotrang > 1)
            {
                sotrang--;
                lbl_sotrang.Text = sotrang.ToString();
                LoadData();
                /* btn_next.Enabled = true;*/

            }
            else
            {
                /*btn_pre.Enabled = false;*/
                MessageBox.Show("Bạn đã ở trang đầu tiên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int tongsodulieu = busKhachHang.getTongKhachHang();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            if (sotrang < totalPages)
            {
                sotrang++;
                lbl_sotrang.Text = sotrang.ToString();
                LoadData();
            }
            else
            {

                MessageBox.Show("Bạn đã ở trang cuối cùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
