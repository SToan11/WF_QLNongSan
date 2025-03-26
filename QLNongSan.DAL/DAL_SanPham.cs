using DTO_QLSP;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNongSan.DAL;
using QLNongSan.DTO;

namespace DAL_QLSanPham
{
    public class DAL_SanPham : DBConnect
    {

        public DataTable getSanPham(int sotrang, int kichthuoctrang)
        {

            DataTable dtHang = new DataTable();
            try
            {

                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DsSanPham";
                cmd.Parameters.AddWithValue("sotrang", sotrang);
                cmd.Parameters.AddWithValue("kichthuoctrang", kichthuoctrang);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtHang);


            }
            finally { _conn.Close(); }
            return dtHang;
        }
        public bool kiemTraSPXoa(DTO_QLSanPham kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getSanPhamBiXoa";
                cmd.Parameters.AddWithValue("@tensp", kt);
                

                // Execute the query and get the result
                int result = (int)cmd.ExecuteScalar();

                // Return true if a matching user is found
                return result > 0;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool phucHoiSanPham(DTO_QLSanPham hang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "phucHoisanpham";
                cmd.Parameters.AddWithValue("tensp", hang.TenSanPham);
                cmd.Parameters.AddWithValue("soluong", hang.SoLuong);
                cmd.Parameters.AddWithValue("dongia", hang.DonGia);
                cmd.Parameters.AddWithValue("hinhanh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("ghichu", hang.GhiChu);
                cmd.Parameters.AddWithValue("loaisp", hang.LoaiSanPham);
                cmd.Parameters.AddWithValue("maloaihang", hang.MaLoaiSanPham);
                cmd.Parameters.AddWithValue("ngay", hang.NgayThem);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public int getTongsanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getTongDataSanPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // Execute the query and get the result
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    return result;
                }
                return 0;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool kiemTra(DTO_QLSanPham kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraSanPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tensp", kt.TenSanPham);
                

                // Execute the query and get the result
                int result = (int)cmd.ExecuteScalar();

                // Return true if a matching user is found
                return result > 0;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool ThemSanPham(DTO_QLSanPham hang)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemSanPham";
                cmd.Parameters.AddWithValue("tensp", hang.TenSanPham);
                cmd.Parameters.AddWithValue("soluong", hang.SoLuong);
                cmd.Parameters.AddWithValue("dongia", hang.DonGia);
                cmd.Parameters.AddWithValue("hinhanh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("ghichu", hang.GhiChu);
                cmd.Parameters.AddWithValue("loaisp", hang.LoaiSanPham);
                cmd.Parameters.AddWithValue("maloaihang", hang.MaLoaiSanPham);
                cmd.Parameters.AddWithValue("ngay", hang.NgayThem);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.Write("lỗi: " + ex);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool SuaSanPham(DTO_QLSP.DTO_QLSanPham hang)
        {


            //using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaSanPham";
                cmd.Parameters.AddWithValue("tensp", hang.TenSanPham);
                cmd.Parameters.AddWithValue("soluong", hang.SoLuong);
                cmd.Parameters.AddWithValue("dongia", hang.DonGia);
                cmd.Parameters.AddWithValue("hinhanh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("ghichu", hang.GhiChu);
                cmd.Parameters.AddWithValue("loaisp", hang.LoaiSanPham);
                cmd.Parameters.AddWithValue("maloaihang", hang.MaLoaiSanPham);
                cmd.Parameters.AddWithValue("ngay", hang.NgayThem);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public bool XoaSanPham(string maHang)
        {

            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaSanPham";
                cmd.Parameters.AddWithValue("masp", maHang);
                cmd.Connection = _conn;
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {

                Console.Write("lỗi: " + ex);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public DataTable TimSanPham(string tenHang)
        {

            //Store Procedure
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimSanPham";
                cmd.Parameters.AddWithValue("tensp", tenHang);
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public DataTable LoaiHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachLoaiHang"; // Đảm bảo stored procedure này tồn tại
                cmd.Connection = _conn;
                DataTable dsLoaiHang = new DataTable();
                dsLoaiHang.Load(cmd.ExecuteReader());
                return dsLoaiHang;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
