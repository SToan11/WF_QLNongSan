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
    public partial class Frm_ChonHoaDon : Form
    {
        private Frm_HoaDon _frmHoaDon;
        BUS_HOADON BUS_HOADON = new BUS_HOADON();
        int sotrang = 1;
        int kichthuoctrang = 5;
        public static string mahd = null;
        public static string tenhd = null;
        public static string tongtien = null;
        public static string manv = null;
        public static string makh = null;
        public Frm_ChonHoaDon(Frm_HoaDon frmHoaDon)
        {
            InitializeComponent();
            _frmHoaDon = frmHoaDon;
        }

        private void lbl_tenhd_Click(object sender, EventArgs e)
        {

        }
        public void loadGridView()
        {
            dgv_hoadon.DataSource = BUS_HOADON.DanhSachHoaDon(sotrang, kichthuoctrang);
            dgv_hoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgv_hoadon.Columns[1].HeaderText = "Mã Nhân Viên";
            dgv_hoadon.Columns[2].HeaderText = "Tên Nhân Viên";
            dgv_hoadon.Columns[3].HeaderText = "Mã Khách Hàng";
            dgv_hoadon.Columns[4].HeaderText = "Tên Khách Hàng";
            dgv_hoadon.Columns[5].HeaderText = "Địa Chỉ Khách Hàng";
            dgv_hoadon.Columns[6].HeaderText = "Ngày Lập Hóa Đơn";
            dgv_hoadon.Columns[7].HeaderText = "Số Điện Thoại Khách Hàng";
            dgv_hoadon.Columns[8].HeaderText = "Tổng Tiền";
        }
        private void Frm_ChonHoaDon_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int tongsodulieu = BUS_HOADON.getTongHoaDon();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            if (sotrang < totalPages)
            {
                sotrang++;
                lbl_sotrang.Text = sotrang.ToString();
                loadGridView();
            }
            else
            {

                MessageBox.Show("Bạn đã ở trang cuối cùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (sotrang > 1)
            {
                sotrang--;
                lbl_sotrang.Text = sotrang.ToString();
                loadGridView();

            }
            else
            {

                MessageBox.Show("Bạn đã ở trang đầu tiên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            mahd = txt_mahd.Text; // Update the static property
            manv = dgv_hoadon.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
            makh = dgv_hoadon.CurrentRow.Cells["MaKhachHang"].Value.ToString();

            if (_frmHoaDon != null)
            {
                _frmHoaDon.loadHoaDon(); // Call the method on the passed Frm_HoaDon instance
            }

            this.Close();
        }

        private void lbl_tenhd_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hoadon.Rows.Count > 1)
            {
                txt_mahd.Text = dgv_hoadon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng Không Tồn Tại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
           
        }
    }
}
