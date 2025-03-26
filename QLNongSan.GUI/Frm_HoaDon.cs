using Microsoft.Office.Interop.Excel;
using QLNongSan.BUS;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QLNongSan.GUi
{
    public partial class Frm_HoaDon : Form
    {
        BUS_HOADON BUS_HOADON = new BUS_HOADON();
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        private void LoadGridView_HoaDon()
        {
            dgv_HoaDon.DataSource = BUS_HOADON.DanhSachSanPhamHoaDon(txt_MaHD.Text);
            dgv_HoaDon.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_HoaDon.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_HoaDon.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgv_HoaDon.Columns[3].HeaderText = "Đơn Giá";
            dgv_HoaDon.Columns[4].HeaderText = "Số Lượng";
            dgv_HoaDon.Columns[5].HeaderText = "Thành Tiền";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HoaDon.Rows.Count > 1)
            {
                masp_txt.Text = dgv_HoaDon.CurrentRow.Cells["MaSanPham"].Value.ToString();
                cbo_tensp.Text = dgv_HoaDon.CurrentRow.Cells["TenSanPham"].Value.ToString();
                txt_LoaiSP.Text = dgv_HoaDon.CurrentRow.Cells["LoaiSanPham"].Value.ToString();
                txt_DonGia.Text = dgv_HoaDon.CurrentRow.Cells["DonGia"].Value.ToString() + " đ";
                nud_soluong.Value = int.Parse(dgv_HoaDon.CurrentRow.Cells["SoLuong"].Value.ToString());
                txt_thanhtien.Text = dgv_HoaDon.CurrentRow.Cells["ThanhTien"].Value.ToString() + " đ";
                tongTien();
            }
            else
            {
                MessageBox.Show("Bảng Không Tồn Tại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tongTien()
        {
            try
            {
                int tongtien = 0; // Initialize total amount

                foreach (DataGridViewRow row in dgv_HoaDon.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string GiaTriO = row.Cells["ThanhTien"].Value?.ToString() ?? "0"; // Handle null values
                        if (int.TryParse(GiaTriO, out int ThanhTien))
                        {
                            tongtien += ThanhTien; // Accumulate the total
                        }
                        else
                        {
                            MessageBox.Show($"Cannot parse value '{GiaTriO}' to a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                txt_TongTien.Text = tongtien.ToString() + " đ"; // Format the total amount and display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tính tổng. Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void loadHoaDon()
        {
            txt_MaHD.Text = Frm_ChonHoaDon.mahd;
            DataRow thongtinnv = BUS_HOADON.thongTinNguoiDung(Frm_ChonHoaDon.manv);

            if (thongtinnv != null)
            {
                // Assuming you have textboxes to display the details
                txt_MaNV.Text = thongtinnv["MaNguoiDung"].ToString();
                cbo_tennv.Text = thongtinnv["TenNguoiDung"].ToString();
                // Add more fields as necessary
            }
            DataRow thongtinkh = BUS_HOADON.thongTinKhachHang(Frm_ChonHoaDon.makh);

            if (thongtinkh != null)
            {
                // Assuming you have textboxes to display the details
                makh_txt.Text = thongtinkh["MaKhachHang"].ToString();
                cbo_tenkh.Text = thongtinkh["TenKhachHang"].ToString();
                txt_DiaChi.Text = thongtinkh["DiaChi"].ToString();
                txt_SDT.Text = thongtinkh["SDT"].ToString();
                // Add more fields as necessary
            }
            LoadGridView_HoaDon();
            tongTien();

        }
        private void loadCombo()
        {
            try
            {
                System.Data.DataTable dsloaihang = BUS_HOADON.dssanpham();
                cbo_tensp.DataSource = dsloaihang;
                cbo_tensp.DisplayMember = "TenSanPham";
                cbo_tensp.ValueMember = "MaSanPham";
                System.Data.DataTable dsnhanvien = BUS_HOADON.dsnhanvien();
                cbo_tennv.DataSource = dsnhanvien;
                cbo_tennv.DisplayMember = "TenNguoiDung";
                cbo_tennv.ValueMember = "MaNguoiDung";
                System.Data.DataTable dskhachhang = BUS_HOADON.dskhachhang();
                cbo_tenkh.DataSource = dskhachhang;
                cbo_tenkh.DisplayMember = "TenKhachHang";
                cbo_tenkh.ValueMember = "MaKhachHang";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void resetValue()
        {
            nud_soluong.Visible = false;
            cbo_tensp.Text = null;
            cbo_tennv.Text = null;
            cbo_tenkh.Text = null;
            txt_DiaChi.Text = null;
            txt_DonGia.Text = null;
            txt_LoaiSP.Text = null;
            txt_MaHD.Text = null;
            txt_MaNV.Text = null;
            txt_SDT.Text = null;
            nud_soluong.Value = 0;
            txt_timkiem.Text = "Tìm Tên Sản Phẩm";
            txt_TongTien.Text = null;
            makh_txt.Text = null;
            masp_txt.Text = null;
            txt_thanhtien.Text = null;
        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            dtp_ngaydathang.Format = DateTimePickerFormat.Custom;
            dtp_ngaydathang.CustomFormat = "dd/MM/yyyy";
            loadCombo();
            LoadGridView_HoaDon();
            resetValue();
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = null;
            txt_timkiem.BackColor = Color.White;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_tennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tennv.SelectedIndex != -1 && !string.IsNullOrEmpty(cbo_tennv.Text))
            {
                try
                {
                    // Retrieve the selected product's ID
                    string nhanvienID = cbo_tennv.SelectedValue.ToString();

                    // Fetch details of the selected product
                    DataRow thongtinnv = BUS_HOADON.thongTinNguoiDung(nhanvienID);

                    if (thongtinnv != null)
                    {
                        // Assuming you have textboxes to display the details
                        txt_MaNV.Text = thongtinnv["MaNguoiDung"].ToString();
                        // Add more fields as necessary
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tải thông tin sản phẩm: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbo_tensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tensp.SelectedIndex != -1 && !string.IsNullOrEmpty(cbo_tensp.Text))
            {
                try
                {
                    // Retrieve the selected product's ID
                    string sanphamID = cbo_tensp.SelectedValue.ToString();

                    // Fetch details of the selected product
                    DataRow thongtinsp = BUS_HOADON.thongTinSanPham(sanphamID);

                    if (thongtinsp != null)
                    {
                        // Assuming you have textboxes to display the details
                        masp_txt.Text = thongtinsp["MaSanPham"].ToString();
                        txt_LoaiSP.Text = thongtinsp["TenLoaiHang"].ToString();
                        txt_DonGia.Text = thongtinsp["DonGia"].ToString();
                        nud_soluong.Value = 1;
                        nud_soluong.Visible = true;
                        // Add more fields as necessary
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tải thông tin sản phẩm: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void cbo_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tenkh.SelectedIndex != -1 && !string.IsNullOrEmpty(cbo_tenkh.Text))
            {
                try
                {
                    // Retrieve the selected product's ID
                    string khachhangID = cbo_tenkh.SelectedValue.ToString();

                    // Fetch details of the selected product
                    DataRow thongtinkh = BUS_HOADON.thongTinKhachHang(khachhangID);

                    if (thongtinkh != null)
                    {
                        // Assuming you have textboxes to display the details
                        makh_txt.Text = thongtinkh["MaKhachHang"].ToString();
                        txt_DiaChi.Text = thongtinkh["DiaChi"].ToString();
                        txt_SDT.Text = thongtinkh["SDT"].ToString();
                        // Add more fields as necessary
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tải thông tin sản phẩm: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nud_soluong_ValueChanged(object sender, EventArgs e)
        {
            if (cbo_tensp.SelectedIndex != -1)
            {
                try
                {
                    // Retrieve the selected product's ID
                    string sanphamID = cbo_tensp.SelectedValue.ToString();

                    // Fetch details of the selected product
                    DataRow thongtinsp = BUS_HOADON.thongTinSanPham(sanphamID);

                    if (thongtinsp != null)
                    {
                        // Extract the price and available quantity from the fetched data
                        string dongiaStr = thongtinsp["DonGia"].ToString().Replace("đ", "").Trim(); // Remove currency symbol and whitespace

                        // Get the quantity entered by the user from the NumericUpDown control
                        int soluong = (int)nud_soluong.Value;
                        // Calculate and display the total price if the unit price is valid
                        if (int.TryParse(dongiaStr, out int dongia))
                        {
                            int thanhtien = dongia * soluong;
                            txt_thanhtien.Text = thanhtien.ToString() + " đ";
                        }
                        else
                        {
                            MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sản phẩm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi tính toán thành tiền: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_chonhoadon_Click(object sender, EventArgs e)
        {
            Frm_ChonHoaDon frm = new Frm_ChonHoaDon(this);
            frm.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that an invoice has been selected
                if (string.IsNullOrEmpty(txt_MaHD.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Hóa Đơn Trước Khi Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validate that an employee has been selected
                if (string.IsNullOrEmpty(txt_MaNV.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Nhân Viên Trước Khi Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validate that a customer has been selected
                if (string.IsNullOrEmpty(makh_txt.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Khách Hàng Trước Khi Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validate that a product has been selected
                if (string.IsNullOrEmpty(masp_txt.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Sản Phẩm Trước Khi Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Retrieve the maximum available quantity of the product
                int soluongmax = BUS_HOADON.laySoLuongHienTai(masp_txt.Text);

                // Get the quantity entered by the user from the NumericUpDown control
                int soluong = (int)nud_soluong.Value;

                // Check if the entered quantity exceeds the available stock
                if (soluong > soluongmax)
                {
                    MessageBox.Show("Số lượng không được lớn hơn số lượng sản phẩm trong kho. (Số Lượng Tối Đa Của Sản Phẩm Này Là: " + soluongmax + " Sản Phẩm).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nud_soluong.Value = soluongmax; // Adjust the quantity to the maximum available
                    soluong = soluongmax; // Update the quantity to reflect the adjusted value
                    return; // Exit the method
                }

                // Check if the entered quantity is less than 1
                if (nud_soluong.Value < 1)
                {
                    MessageBox.Show("Số lượng không được trống hoặc bé hơn 1.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nud_soluong.Value = 1; // Set the quantity to the minimum allowed value
                    return; // Exit the method
                }

                // Check if the product already exists in the invoice
                bool productExists = BUS_HOADON.kiemTra(masp_txt.Text, txt_MaHD.Text);
                if (productExists)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit the method
                }
                else
                {
                    // Calculate the total amount for the product
                    float thanhtien = float.Parse(txt_thanhtien.Text.Replace("đ", "").Trim());
                    float dongia = float.Parse(txt_DonGia.Text.Replace("đ", "").Trim());

                    // Create a DTO object for the invoice
                    DTO_HoaDon hd = new DTO_HoaDon(txt_MaHD.Text, masp_txt.Text, cbo_tensp.Text, txt_LoaiSP.Text, soluong, dongia.ToString(), thanhtien);

                    // Add the product to the invoice
                    if (BUS_HOADON.themSanPhamHoaDon(hd))
                    {
                        MessageBox.Show("Thêm Sản Phẩm Vào Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_HoaDon(); // Refresh the invoice grid view
                        tongTien(); // Recalculate the total amount

                        // Update the total amount in the database
                        float tongtien;
                        string tongTienText = txt_TongTien.Text.Replace("đ", "").Trim();
                        if (!float.TryParse(tongTienText, out tongtien))
                        {
                            MessageBox.Show("Tổng Tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Exit the method
                        }
                        else
                        {
                            BUS_HOADON.capNhatTongTien(txt_MaHD.Text, tongtien);
                        }

                        // Update the stock quantity
                        BUS_HOADON.truSoLuong(masp_txt.Text, soluong);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Sản Phẩm Vào Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Có lỗi xảy ra khi tính toán thành tiền: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_MaHD.Text))
                {
                    if (BUS_HOADON.deleteHoaDon(txt_MaHD.Text))
                    {
                        MessageBox.Show("Xóa Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetValue();
                        LoadGridView_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa hóa đơn: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaNV.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Mã Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(makh_txt.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Mã Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!string.IsNullOrEmpty(txt_MaHD.Text))
                {
                    MessageBox.Show("Vui Lòng Làm Mới Thông Tin Trước Khi Thêm Hóa Đơn Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!string.IsNullOrEmpty(txt_MaNV.Text) && !string.IsNullOrEmpty(makh_txt.Text))
                {
                    if (BUS_HOADON.taoHoaDon(txt_MaNV.Text, dtp_ngaydathang.Value, makh_txt.Text))
                    {
                        MessageBox.Show("Thêm Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetValue();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm hóa đơn: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        { 
            loadCombo();
            resetValue();
            LoadGridView_HoaDon();
            tongTien();
        }

        private void btn_suahoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaNV.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Mã Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(makh_txt.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Mã Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    tongTien();
                    float tongtien;
                    string tongTienText = txt_TongTien.Text.Replace("đ", "").Trim();
                    if (!float.TryParse(tongTienText, out tongtien))
                    {
                        MessageBox.Show("Tổng Tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (BUS_HOADON.suaHoaDon(txt_MaHD.Text, txt_MaNV.Text, dtp_ngaydathang.Value,makh_txt.Text, tongtien))
                    {
                        MessageBox.Show("Sửa Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetValue();
                        LoadGridView_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Retrieve the maximum available quantity of the product from the database
            // int soluongmax = BUS_HOADON.laySoLuongHienTai(masp_txt.Text);

            // Get the quantity entered by the user from the NumericUpDown control
            // int soluong = (int)nud_soluong.Value;

            // Check if the entered quantity is more than the available stock
            // if (soluong > soluongmax)
            // {
            //     // Show an error message if the entered quantity exceeds the available stock
            //     MessageBox.Show("Số lượng không được lớn hơn số lượng sản phẩm trong kho. (Số Lượng Tối Đa Của Sản Phẩm Này Là: " + soluongmax + " Sản Phẩm).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     // Adjust the NumericUpDown value to the maximum available quantity
            //     nud_soluong.Value = soluongmax;
            //     // Update the quantity variable to reflect the adjusted value
            //     soluong = soluongmax;
            //     // Exit the method after showing the error
            //     return;
            // }

            // Check if the quantity is less than 1
            // if (soluong < 1)
            // {
            //     // Show an error message if the entered quantity is less than 1
            //     MessageBox.Show("Số lượng không được trống hoặc bé hơn 1.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     // Set the NumericUpDown value to the minimum allowed value (1)
            //     nud_soluong.Value = 1;
            //     // Exit the method after showing the error
            //     return;
            // }

            // If validation passes, proceed with updating the quantity
            // Get the current quantity of the product from the database
            // int soluonghientai = BUS_HOADON.laySoLuongHienTai(masp_txt.Text);
            // Calculate the difference between the new quantity and the current quantity
            // int soluongchenhlech = soluong - soluonghientai;

            // Check if the difference is negative, meaning we need to subtract
            // if (soluongchenhlech < 0)
            // {
            //     // Subtract the absolute value of the difference from the current quantity
            //     BUS_HOADON.truSoLuong(masp_txt.Text, Math.Abs(soluongchenhlech));
            // }
            // Check if the difference is positive, meaning we need to add
            // else if (soluongchenhlech > 0)
            // {
            //     // Add the difference to the current quantity
            //     BUS_HOADON.congSoLuong(masp_txt.Text, soluongchenhlech);
            // }
            // else
            // {
            //     // If the difference is zero, no change is needed
            //     MessageBox.Show("No change needed.");
            // }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaHD.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Hóa Đơn Trước Khi Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(masp_txt.Text))
                {
                    MessageBox.Show("Bạn Phải Chọn Sản Phẩm Trước Khi Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (BUS_HOADON.xoaSanPhamHoaDon(txt_MaHD.Text, masp_txt.Text))
                    {
                        BUS_HOADON.congSoLuong(masp_txt.Text, int.Parse(nud_soluong.Value.ToString()));
                        MessageBox.Show("Xóa Sản Phẩm Khỏi Hóa Đơn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_HoaDon();
                        tongTien();
                        float tongtien;
                        string tongTienText = txt_TongTien.Text.Replace("đ", "").Trim();
                        if (!float.TryParse(tongTienText, out tongtien))
                        {
                            MessageBox.Show("Tổng Tiền không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            BUS_HOADON.capNhatTongTien(txt_MaHD.Text, tongtien);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa Sản Phẩm Khỏi Hóa Đơn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tính toán thành tiền: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tensp = txt_timkiem.Text;
            string mahd = txt_MaHD.Text;
            System.Data.DataTable ds = BUS_HOADON.searchSanPhamHoaDon(mahd,tensp);
            if(tensp == "Tìm Tên Sản Phẩm")
            {
                LoadGridView_HoaDon();
            }
            else if (ds.Rows.Count > 0)
            {
                dgv_HoaDon.DataSource = ds;
                dgv_HoaDon.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgv_HoaDon.Columns[1].HeaderText = "Tên Sản Phẩm";
                dgv_HoaDon.Columns[2].HeaderText = "Loại Sản Phẩm";
                dgv_HoaDon.Columns[3].HeaderText = "Đơn Giá";
                dgv_HoaDon.Columns[4].HeaderText = "Số Lượng";
                dgv_HoaDon.Columns[5].HeaderText = "Thành Tiền";
                txt_timkiem.Text = "Tìm Tên Sản Phẩm";
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExportFile(System.Data.DataTable dataTable, string sheetName, string title, string tongtien, string tenkhachhang, string diachi, string sdt)
        {
            // Create Excel objects
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Create a new Excel Workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Create the title
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Add customer details
            Microsoft.Office.Interop.Excel.Range customerNameLabel = oSheet.get_Range("A2", "A2");
            customerNameLabel.Value2 = "Tên Khách Hàng:";
            customerNameLabel.ColumnWidth = 12;


            Microsoft.Office.Interop.Excel.Range customerNameValueRange = oSheet.get_Range("B2", "B2");
            customerNameValueRange.Value2 = tenkhachhang;
            customerNameValueRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;


            Microsoft.Office.Interop.Excel.Range addressLabel = oSheet.get_Range("A3", "A3");
            addressLabel.Value2 = "Địa Chỉ:";

            Microsoft.Office.Interop.Excel.Range addressValueRange = oSheet.get_Range("B3", "B3");
            addressValueRange.Value2 = diachi;
            addressValueRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;


            Microsoft.Office.Interop.Excel.Range sdtlabel = oSheet.get_Range("A4", "A4");
            sdtlabel.Value2 = "Số Điện Thoại:";

            Microsoft.Office.Interop.Excel.Range sdtlabelrange = oSheet.get_Range("B4", "B4");
            sdtlabelrange.Value2 = sdt;
            sdtlabelrange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;


            Microsoft.Office.Interop.Excel.Range totalAmountLabel = oSheet.get_Range("A5", "A5");
            totalAmountLabel.Value2 = "Tổng Tiền:";
            totalAmountLabel.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range totalAmountValue = oSheet.get_Range("B5", "B5");
            totalAmountValue.Value2 = tongtien;

            // Create column headers
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A6", "A6");
            cl1.Value2 = "Mã Sản Phẩm";
            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B6", "B6");
            cl2.Value2 = "Tên Sản Phẩm";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C6", "C6");
            cl3.Value2 = "Loại Sản Phẩm";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D6", "D6");
            cl4.Value2 = "Đơn Giá";
            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E6", "E6");
            cl5.Value2 = "Số Lượng";
            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F6", "F6");
            cl6.Value2 = "Thành Tiền";
            cl6.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A6", "F6");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Create the data array from the DataTable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // Set the range for data
            int rowStart = 7;  // Adjust rowStart to account for additional labels
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 2;
            int columnEnd = dataTable.Columns.Count;

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void btn_xuat_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            DataColumn col1 = new DataColumn("1");
            DataColumn col2 = new DataColumn("2");
            DataColumn col3 = new DataColumn("3");
            DataColumn col4 = new DataColumn("4");
            DataColumn col5 = new DataColumn("5");
            DataColumn col6 = new DataColumn("6");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);

            foreach (DataGridViewRow row in dgv_HoaDon.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = row.Cells[0].Value;
                dtrow[1] = row.Cells[1].Value;
                dtrow[2] = row.Cells[2].Value;
                dtrow[3] = row.Cells[3].Value;
                dtrow[4] = row.Cells[4].Value;
                dtrow[5] = row.Cells[5].Value;

                dataTable.Rows.Add(dtrow);
            }
            string tongtien = txt_TongTien.Text;
            string tenkhachhang = cbo_tenkh.Text;
            string diachi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            ExportFile(dataTable, "Hóa Đơn", "Hóa Đơn Bán Hàng", tongtien, tenkhachhang, diachi, sdt);
        }
    }
}
