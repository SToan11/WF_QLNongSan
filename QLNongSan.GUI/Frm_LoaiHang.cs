using QLNongSan.BUS;
using QLNongSan.DTO;
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
    public partial class Frm_LoaiHang : Form
    {
        private BUS_LoaiHang busLoaiHang;
        int sotrang = 1;
        int kichthuoctrang = 5;
        public Frm_LoaiHang()
        {
            InitializeComponent();
            busLoaiHang = new BUS_LoaiHang();
            txt_timkiem.TextChanged += new EventHandler(txt_timkiem_TextChanged);
        }

        private void Frm_LoaiHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgv_qllh.DataSource = busLoaiHang.HienThiLoaiHang(sotrang, kichthuoctrang);
            dgv_qllh.Columns[0].HeaderText = "Mã Loại Hàng";
            dgv_qllh.Columns[1].HeaderText = "Tên Loại Hàng";
            soTrangHienTai();
            UpdateTongSoTrang();
        }
        private void UpdateTongSoTrang()
        {
            int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham(); // Get the total number of items
            int tongSoTrang = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang; // Calculate total pages
            btn_total.Text = tongSoTrang.ToString(); // Update the label with the total number of pages
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var lh = new DTO_LoaiHang
            {
                TenLoaiHang = txt_tenlh.Text
            };
            if (string.IsNullOrWhiteSpace(txt_tenlh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!busLoaiHang.kiemTra(txt_tenlh.Text))
            {
               
                bool result = busLoaiHang.ThemLoaiHang(lh);
                if (result)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txt_malh.Clear();
                    txt_tenlh.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (busLoaiHang.kiemTra(txt_tenlh.Text) && busLoaiHang.kiemTraXoa(txt_tenlh.Text))
            {
                bool result = busLoaiHang.phucHoiLoaiHang(lh);
                if (result)
                {
                    MessageBox.Show("Phục hồi thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txt_malh.Clear();
                    txt_tenlh.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (busLoaiHang.kiemTra(txt_tenlh.Text) && !busLoaiHang.kiemTraXoa(txt_tenlh.Text))
            {
                MessageBox.Show("Phát Hiện Loại Hàng Đã Có, Vui Lòng Chỉnh Sửa Thay Vì Thêm Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var lh = new DTO_LoaiHang
            {
                MaLoaiHang = txt_malh.Text,
                TenLoaiHang = txt_tenlh.Text
            };

            bool result = busLoaiHang.SuaLoaiHang(lh);
            if (result)
            {
                MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txt_malh.Clear();
                txt_tenlh.Clear();
            }
            else
            {
                MessageBox.Show("Lỗi.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maLoaiHang = txt_malh.Text;

            // xác nhận
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bool result = busLoaiHang.XoaLoaiHang(maLoaiHang);
                if (result)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txt_malh.Clear();
                    txt_tenlh.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi.");
                }
            }
        }


        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_timkiem.Clear();
            btn_next.Enabled = true;
            btn_pre.Enabled = true;
            veTrangDau();
            lbl_3cham.Text = "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_malh.Clear();
            txt_tenlh.Clear();
            txt_malh.ReadOnly = true;
            txt_timkiem.Clear();
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tenLoaiHang = txt_timkiem.Text;
            DataTable ds = busLoaiHang.TimLoaiHang(tenLoaiHang);
            if (ds.Rows.Count > 0)
            {
                dgv_qllh.DataSource = ds;
                btn_next.Enabled = false;
                btn_pre.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy loại hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_qllh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_malh.ReadOnly = true;
            if (dgv_qllh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_qllh.SelectedRows[0];

                // Lấy dữ liệu từ dòng đã chọn
                string maLoaiHang = selectedRow.Cells["MaLoaiHang"].Value.ToString();
                string tenLoaiHang = selectedRow.Cells["TenLoaiHang"].Value.ToString();

                // Hiển thị dữ liệu lên các điều khiển
                txt_malh.Text = maLoaiHang;
                txt_tenlh.Text = tenLoaiHang;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            if (sotrang < totalPages)
            {
                /*btn_pre.Enabled = true;*/
                sotrang++;
                LoadData();
                //updateSoTrang();
                updatest();
                soTrangHienTai();
            }
            else
            {
                /* btn_next.Enabled = false; */
                MessageBox.Show("Bạn đã ở trang cuối cùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (sotrang > 1)
            {
                sotrang--;
                LoadData();
                //updateSoTrang();
                updatest();
                /* btn_next.Enabled = true;*/
                soTrangHienTai();

            }
            else
            {
                /*btn_pre.Enabled = false;*/
                MessageBox.Show("Bạn đã ở trang đầu tiên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void veTrangDau()
        {
            if (sotrang > 1)
            {
                sotrang = 1;
                LoadData();
                updateSoTrang();
                updatest();
                soTrangHienTai();
            }
        }
        //cập nhật số trang
        private void updateSoTrang()
        {
            //lbl_sotrang.Text =  $"{sotrang}";
        }

        //tìm kiếm theo txt_timkiem
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string tenLoaiHang = txt_timkiem.Text;

            DataTable ds = busLoaiHang.TimLoaiHang(tenLoaiHang);

            if (ds.Rows.Count > 0)
            {
                dgv_qllh.DataSource = ds;
                btn_next.Enabled = false;
                btn_pre.Enabled = false;
            }
            else
            {
                dgv_qllh.DataSource = null;

                // nếu sau khi người dùng nhập và nhấn space, nếu không có dữ liệu sẽ thông báo
                if (tenLoaiHang.EndsWith(" "))
                {
                    MessageBox.Show("Không Tìm Thấy loại hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // khi xóa ô txt_timkiem sẽ load lại data
            if (string.IsNullOrWhiteSpace(tenLoaiHang))
            {
                LoadData();
                btn_next.Enabled = true;
                btn_pre.Enabled = true;
                return;
            }
        }
        private void updatest()
        {
            if(sotrang > 2)
            {
                lbl_3cham.Text = $"{sotrang}";
            }
        }

        private void lbl_sotrang_Click(object sender, EventArgs e)
        {
            //sotrang = 1;
        }

        private void btn_sotrang2_Click(object sender, EventArgs e)
        {
            //sotrang = 2;
        }
        private void bacham()
        {
            int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;

            if (totalPages > 2)
            {
                sotrang = totalPages - 1;
                LoadData();
                soTrangHienTai();
            }
        }



        private void lbl_3cham_Click(object sender, EventArgs e)
        {
            bacham();
           
        }

        private void lbl_sotrang2_Click(object sender, EventArgs e)
        {
            int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            //lbl_sotrang2.Text = totalPages.ToString();
        }

        private void btn_st1_Click(object sender, EventArgs e)
        {
            sotrang = 1;
            LoadData();
            soTrangHienTai();
            //lbl_3cham.Text = "...";
        }

        private void btn_st2_Click(object sender, EventArgs e)
        {
            sotrang = 2;
            LoadData();
            soTrangHienTai();
            //lbl_3cham.Text = "...";
        }
        

        private void soTrangHienTai()
        {
            int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;

            Color highlightColor = Color.FromArgb(144, 238, 144); // Light Blue

            btn_st1.BackColor = Color.White;
            btn_st2.BackColor = Color.White;
            lbl_3cham.BackColor = Color.White;
            btn_total.BackColor = Color.White;

            if (sotrang == 1)
            {
                btn_st1.BackColor = highlightColor;
                lbl_3cham.Text = "...";
            }
            else if (sotrang == 2)
            {
                btn_st2.BackColor = highlightColor;
                lbl_3cham.Text = "...";
            }
            else if (sotrang > 2 && sotrang < totalPages)
            {
                lbl_3cham.BackColor = highlightColor;
            }
            else if (sotrang == totalPages)
            {
                btn_total.BackColor = highlightColor;
                lbl_3cham.Text = "...";
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;
            btn_total.Text = totalPages.ToString();
            lbl_3cham.Text = "...";

            sotrang = totalPages;
            LoadData();
            soTrangHienTai();
        }

        private void txt_sotrangmuontim_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_sotrangmuontim.Text, out int result))
            {
                txt_sotrangmuontim.Text = "";
            }
        }

        private void btn_timst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_sotrangmuontim.Text, out int pageNumber))
            {
                // Đảm bảo số trang nằm trong phạm vi hợp lệ
                int tongsodulieu = busLoaiHang.getTongSoDataLoaiSanPham();
                int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;

                if (pageNumber >= 1 && pageNumber <= totalPages)
                {
                    // Đặt trang hiện tại thành số trang được chỉ định
                    sotrang = pageNumber;
                    LoadData();
                    soTrangHienTai(); // cập nhật trang
                    txt_sotrangmuontim.Clear();
                    lbl_3cham.Text = pageNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Số trang không hợp lệ. Vui lòng nhập số trang trong khoảng từ 1 đến " + totalPages, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_sotrangmuontim.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ (VD:1,2,3,...).", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sotrangmuontim.Clear();
            }
        }
    }
}
