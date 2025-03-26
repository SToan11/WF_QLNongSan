using DTO_QLSP;
using QLNongSan.BUS;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNongSan.GUi
{
    public partial class Frm_SanPham : Form
    {
        int sotrang = 1;
        int kichthuoctrang = 5;
        BUS_SanPham bushang = new BUS_SanPham();
        string checkUrlImage;//kiểm tra hinh khi câp nhật
        string fileName;  // ten file
        string fileSavePath;//url store image  
        string fileAddress;// url load images
        string maloaihang = "";
        public Frm_SanPham()
        {
            InitializeComponent();
            LoadHangIntoComboBox();
        }
        private void LoadHangIntoComboBox()
        {

            DataTable dtLoaiHang = bushang.LoaiHang();
            cbo_loaihang.DataSource = dtLoaiHang;
            cbo_loaihang.DisplayMember = "TenLoaiHang";
            cbo_loaihang.ValueMember = "MaLoaiHang";
        }
        private void ResetValues()
        {
            if (pbHinh.Image != null)
            {
                pbHinh.Image.Dispose();
                pbHinh.Image = null;
            }
            txt_dongia.Text = null;
            txt_tensp.Text = null;
            txt_soluong.Text = null;
            txt_masp.Text = null;
            txt_hinh.Text = null;
            txt_ghichu.Text = null;
            pbHinh.Text = null;
            dtp_ngay.Enabled = false;
            cbo_loaihang.Text = "Vui Lòng Chọn Loại Hàng";


        }
        private void LoadSanPham()
        {
            dgv_QLSP.DataSource = bushang.getSanPham(sotrang, kichthuoctrang);
            dgv_QLSP.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_QLSP.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_QLSP.Columns[2].HeaderText = "Số Lượng";
            dgv_QLSP.Columns[3].HeaderText = "Loại Sản Phẩm";
            dgv_QLSP.Columns[4].HeaderText = "Đơn Giá";
            dgv_QLSP.Columns[5].HeaderText = "Ngày Thêm";
            dgv_QLSP.Columns[6].HeaderText = "Hình Ảnh";
            dgv_QLSP.Columns[7].HeaderText = "Ghi Chú";

        }
        private void cbo_loaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_loaihang.SelectedIndex != -1) // Ensure an item is selected
            {
                maloaihang = cbo_loaihang.SelectedValue.ToString();
            }
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            cbo_loaihang.Text = "Vui Lòng Chọn Loại Hàng";
            dtp_ngay.Enabled =  false;
            dtp_ngay.Format = DateTimePickerFormat.Custom;
            dtp_ngay.CustomFormat = "dd/MM/yyyy";
            ResetValues();
            LoadSanPham();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txt_soluong.Text.Trim().ToString(), out intSoLuong); //ep kiểu để kiểm tra là số hay chữ
            float floatDonGia;
            string formattedPrice = txt_dongia.Text.Trim().Replace(" đ", "").Replace(",", "");
            bool isFloatNhap = float.TryParse(formattedPrice, out floatDonGia);

            if (txt_tensp.Text.Trim().Length == 0) // kiem tra phai nhap data
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();
                return;
            }
            else if (!isInt || int.Parse(txt_soluong.Text) < 0) // kiem tra so nguyen > 0
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm >0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(formattedPrice) < 0) // kiem tra so > 0
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập >0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dongia.Focus();
                return;
            }
            else if (txt_hinh.Text.Trim().Length == 0) // kiem tra phai nhap hinh
            {
                MessageBox.Show("Bạn phải upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_mo.Focus();
                return;
            }
            else
            {
                string tien = formattedPrice;
                DateTime ngayThem = dtp_ngay.Value;
                DTO_QLSanPham h = new DTO_QLSanPham(txt_tensp.Text, int.Parse(txt_soluong.Text), int.Parse(tien), ngayThem, "\\Images\\" + fileName, maloaihang, txt_ghichu.Text, cbo_loaihang.Text);
                DTO_QLSanPham kt = new DTO_QLSanPham(txt_tensp.Text.Trim(), cbo_loaihang.Text.Trim());
                if (!bushang.kiemTrasp(kt))
                {
                    if (bushang.ThemSanPham(h))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Copy(fileAddress, fileSavePath, true);// copy file hinh vao ung dung
                        ResetValues();
                        LoadSanPham(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (bushang.kiemTrasp(kt) && bushang.kiemtraSPXoa(kt))
                {
                    if (bushang.PhucHoiSanPham(h))
                    {
                        pbHinh.Image.Dispose();
                        pbHinh.Image = null;
                        MessageBox.Show("Phục hồi Thành Công");
                        File.Copy(fileAddress, fileSavePath, true);
                        ResetValues();
                        LoadSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Phục hồi Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if ((bushang.kiemTrasp(kt) && !bushang.kiemtraSPXoa(kt)))
                {
                    MessageBox.Show("Phát Hiện Người Dùng Đã Có, Vui Lòng Chỉnh Sửa Thay Vì Thêm Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgv_QLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgv_QLSP.Rows.Count > 1)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_masp.Text = dgv_QLSP.CurrentRow.Cells["MasanPham"].Value.ToString();
                txt_tensp.Text = dgv_QLSP.CurrentRow.Cells["TenSanPham"].Value.ToString();
                txt_soluong.Text = dgv_QLSP.CurrentRow.Cells["SoLuong"].Value.ToString();
                cbo_loaihang.Text = dgv_QLSP.CurrentRow.Cells["LoaiSanPham"].Value.ToString();
                txt_dongia.Text = string.Format("{0} đ", Convert.ToDouble(dgv_QLSP.CurrentRow.Cells["DonGia"].Value));
                txt_hinh.Text = dgv_QLSP.CurrentRow.Cells["HinhAnh"].Value.ToString();
                checkUrlImage = txt_hinh.Text;//giữ đường dẫn file hình
                pbHinh.Image = Image.FromFile(saveDirectory + dgv_QLSP.CurrentRow.Cells["HinhAnh"].Value.ToString());
                txt_ghichu.Text = dgv_QLSP.CurrentRow.Cells["GhiChu"].Value.ToString();
                dtp_ngay.Text = dgv_QLSP.CurrentRow.Cells["NgayThem"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maHang = txt_masp.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //do something if YES
                if (bushang.XoaSanPham(maHang))
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    LoadSanPham(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //do something if NO
                ResetValues();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txt_soluong.Text.Trim().ToString(), out intSoLuong); //ep kiểu để kiểm tra là số hay chữ
            float floatDonGia;
            string formattedPrice = txt_dongia.Text.Trim().Replace(" đ", "").Replace(",", "");
            bool isFloatNhap = float.TryParse(formattedPrice, out floatDonGia);

            if (txt_tensp.Text.Trim().Length == 0) // kiem tra phai nhap data
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();
                return;
            }
            else if (!isInt || int.Parse(txt_soluong.Text) < 0) // kiem tra so nguyen > 0
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm >0, số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(formattedPrice) < 0) // kiem tra so > 0
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập >0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_dongia.Focus();
                return;
            }
            else if (txt_hinh.Text.Trim().Length == 0) // kiem tra phai nhap hinh
            {
                MessageBox.Show("Bạn phải upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_mo.Focus();
                return;
            }
            else
            {
                string tien = formattedPrice;
                DateTime ngayThem = dtp_ngay.Value;
                DTO_QLSanPham h = new DTO_QLSanPham(txt_tensp.Text, int.Parse(txt_soluong.Text), int.Parse(tien), ngayThem, "\\Images\\" + fileName, maloaihang, txt_ghichu.Text, cbo_loaihang.Text);
                if (bushang.SuaSanPham(h))
                {
                    if (txt_hinh.Text != checkUrlImage)//nêu có thay doi hình
                        try
                        {
                            File.Copy(fileAddress, fileSavePath, true);// copy file hinh vao ung dung
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("lỗi: "+ ex);
                        }
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValues();
                    LoadSanPham(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pbHinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;// combine with file name*/
                txt_hinh.Text = "\\Images\\" + fileName;
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            btn_next.Enabled = true;
            btn_pre.Enabled = true;
        }

        private void btn_lammoithongtin_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenhang = txt_timkiem.Text;
            DataTable ds = bushang.TimSanPham(tenhang);
            if (ds.Rows.Count > 0)
            {
                dgv_QLSP.DataSource = ds;
                dgv_QLSP.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgv_QLSP.Columns[1].HeaderText = "Tên Sản Phẩm";
                dgv_QLSP.Columns[2].HeaderText = "Số Lượng";
                dgv_QLSP.Columns[3].HeaderText = "Loại Sản Phẩm";
                dgv_QLSP.Columns[4].HeaderText = "Đơn Giá";
                dgv_QLSP.Columns[5].HeaderText = "Hình Ảnh";
                dgv_QLSP.Columns[6].HeaderText = "Ghi Chú";
                foreach (DataGridViewRow row in dgv_QLSP.Rows)
                {
                    if (row.Cells["DonGia"].Value != null)
                    {
                        row.Cells["DonGia"].Value = string.Format("{0} đ", Convert.ToDouble(row.Cells["DonGia"].Value));
                    }
                }
                btn_next.Enabled = false;
                btn_pre.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_timkiem.Text = "Nhập Tên sản phẩm";
            txt_timkiem.BackColor = Color.LightGray;
            ResetValues();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (sotrang > 1)
            {
                sotrang--;
                lbl_sotrang.Text = sotrang.ToString();
                LoadSanPham();
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
            int tongsodulieu = bushang.getTongSoDataSanPham();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            if (sotrang < totalPages)
            {
                /*btn_pre.Enabled = true;*/
                sotrang++;
                lbl_sotrang.Text = sotrang.ToString();
                LoadSanPham();
            }
            else
            {
               /* btn_next.Enabled = false; */
                MessageBox.Show("Bạn đã ở trang cuối cùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngay = DateTime.Now;
            dtp_ngay.Text = ngay.ToString();
        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
