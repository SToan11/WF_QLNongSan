using QLNongSan.BUS;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace QLNongSan.GUi
{
    public partial class Frm_ThongKe : Form
    {
        int sotrang = 1;
        int kichthuoctrang = 5;

        public Frm_ThongKe()
        {
            InitializeComponent();
            LoadData();
        }
        BUS_ThongKe _bus = new BUS_ThongKe();

        private void LoadData(string search = null)
        {
            try
            {
                dgv_thongke.DataSource = _bus.GetThongKeHangTonKho(search, sotrang, kichthuoctrang);
                CreateChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CreateChart()
        {
            //Xóa tất cả các dữ liệu hiện có
            chart1.Series.Clear();

            // Tạo chuỗi giá trị hàng tồn kho
            Series seriesInventoryValue = new Series("Giá Trị Tồn Kho");
            seriesInventoryValue.ChartType = SeriesChartType.Column;
            chart1.Series.Add(seriesInventoryValue);

            // Tạo chuỗi sản phẩm đã bán
            Series seriesSold = new Series("Doanh Thu Tháng");
            seriesSold.ChartType = SeriesChartType.Column;
            chart1.Series.Add(seriesSold);

            // Lấy dữ liệu từ DataGridView hoặc trực tiếp từ thủ tục được lưu trữ
            DataTable dt = _bus.GetThongKeHangTonKho();

            foreach (DataRow row in dt.Rows)
            {
                // Thêm điểm dữ liệu vào chuỗi cho giá trị hàng tồn kho
                seriesInventoryValue.Points.AddXY(row["Tên Sản Phẩm"].ToString(),
                    Convert.ToDouble(row["Tổng Giá Trị Tồn"].ToString().Replace(" VND", "").Replace(",", "")));

                // Thêm điểm dữ liệu vào chuỗi để có doanh thu hàng tháng
                seriesSold.Points.AddXY(row["Tên Sản Phẩm"].ToString(),
                    Convert.ToDouble(row["Doanh Thu Tháng"].ToString().Replace(" VND", "").Replace(",", "")));
            }

            // Tùy chỉnh giao diện biểu đồ nếu cần
            chart1.Titles.Add("Thống Kê Sản Phẩm");
            chart1.ChartAreas[0].AxisX.Title = "Tên Sản Phẩm";
            chart1.ChartAreas[0].AxisY.Title = "Giá Trị (VND)";
        }


        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_timkiem.Clear();
            txt_timkiem.Focus();
            LoadData();
            veTrangDau();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string search = txt_timkiem.Text.Trim();
            LoadData(search);
        }

        private void dgv_thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            soTrangHienTai();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string search = txt_timkiem.Text;

            DataTable ds = _bus.GetThongKeHangTonKho(search);

            if (ds.Rows.Count > 0)
            {
                dgv_thongke.DataSource = ds;
            }
            else
            {
                dgv_thongke.DataSource = null;

                // nếu sau khi người dùng nhập và nhấn space, nếu không có dữ liệu sẽ thông báo
                if (search.EndsWith(" "))
                {
                    MessageBox.Show("Không tìm thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // khi xóa ô txt_timkiem sẽ load lại data
            if (string.IsNullOrWhiteSpace(search))
            {
                LoadData();
                return;
            }
        }

        private void veTrangDau()
        {
            if (sotrang > 1)
            {
                sotrang = 1;
                LoadData();
                //updateSoTrang();
                updatest();
                soTrangHienTai();
            }
        }

        private void updatest()
        {
            if (sotrang > 2)
            {
                lbl_3cham.Text = $"{sotrang}";
            }
        }

        private void soTrangHienTai()
        {
            int tongsodulieu = _bus.GetTongSoDataThongKe();
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

        

        private void bacham()
        {
            int tongsodulieu = _bus.GetTongSoDataThongKe();
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;

            if (totalPages > 2)
            {
                sotrang = totalPages - 1;
                LoadData();
                soTrangHienTai();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
            int tongsodulieu = _bus.GetTongSoDataThongKe(txt_timkiem.Text.Trim()); // Pass the search string
            int totalPages = (tongsodulieu + kichthuoctrang - 1) / kichthuoctrang;

            if (sotrang < totalPages)
            {
                sotrang++;
                LoadData();
                updatest();
                soTrangHienTai();
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

        private void btn_st1_Click(object sender, EventArgs e)
        {
            sotrang = 1;
            LoadData();
            soTrangHienTai();
        }

        private void btn_st2_Click(object sender, EventArgs e)
        {
            sotrang = 2;
            LoadData();
            soTrangHienTai();
        }

        private void lbl_3cham_Click(object sender, EventArgs e)
        {
            bacham();
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            

            int tongsodulieu = _bus.GetTongSoDataThongKe();
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
                int tongsodulieu = _bus.GetTongSoDataThongKe();
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

        private async void btn_xuat_Click(object sender, EventArgs e)
        {
            if (dgv_thongke.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string fileName = $"ThongKe_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            string directoryPath = @"D:\Du An 1(.NET)\xuat";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, fileName);

            await ExportAllPagesToExcel(filePath);
            MessageBox.Show($"Xuất dữ liệu thành công.\nFile được lưu tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task ExportAllPagesToExcel(string filePath)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

            worksheet.Cells[1, "A"] = "THỐNG KÊ";
            var range = worksheet.get_Range("A1", "J1");
            range.Merge();
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Set background color to yellow
            range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

            worksheet.Cells[2, "I"] = "Thời gian xuất:";
            worksheet.Cells[2, "J"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            worksheet.Cells[3, "A"] = "Mã Sản Phẩm";
            worksheet.Cells[3, "B"] = "Tên Sản Phẩm";
            worksheet.Cells[3, "C"] = "Loại Sản Phẩm";
            worksheet.Cells[3, "D"] = "Số Lượng Tồn";
            worksheet.Cells[3, "E"] = "Đơn Giá";
            worksheet.Cells[3, "F"] = "Tổng Giá Trị Tồn";
            worksheet.Cells[3, "G"] = "Tổng Số Sản Phẩm";
            worksheet.Cells[3, "H"] = "Doanh Thu Tháng";
            worksheet.Cells[3, "I"] = "Doanh Thu Quý";
            worksheet.Cells[3, "J"] = "Tổng Doanh Thu";

            int currentRow = 4;
            int totalPages = CalculateTotalPages();
            int currentPage = 1;

            while (currentPage <= totalPages)
            {
                DataTable pageData = _bus.GetThongKeHangTonKho(txt_timkiem.Text.Trim(), currentPage, kichthuoctrang);

                foreach (DataRow row in pageData.Rows)
                {
                    for (int col = 0; col < row.ItemArray.Length; col++)
                    {
                        worksheet.Cells[currentRow, col + 1] = row[col].ToString();
                    }
                    currentRow++;
                }

                currentPage++;
            }

            // AutoFit columns
            worksheet.Columns.AutoFit();

            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();
        }



        private int CalculateTotalPages()
        {
            int totalRecords = _bus.GetTongSoDataThongKe(txt_timkiem.Text.Trim());
            return (totalRecords + kichthuoctrang - 1) / kichthuoctrang;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
