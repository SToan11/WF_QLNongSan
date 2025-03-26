using DTO_QLSP;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DAL
{
    public class DAL_LoaiHang : DBConnect
    {
        public DataTable HienThiLoaiHang(int SoTrang, int KichThuocTrang)
        {
            DataTable dtLoaiHang = new DataTable();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DSLoaiHang";
                cmd.Parameters.AddWithValue("sotrang", SoTrang);
                cmd.Parameters.AddWithValue("kichthuoctrang", KichThuocTrang);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtLoaiHang);


            }
            finally { _conn.Close(); }
            return dtLoaiHang;
        }
        public bool kiemTra(string tenloaihang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraLoaiHang", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenlh", tenloaihang);

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

        public bool kiemTraXoa(string tenloaihang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraLoaiHangBiXoa", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenlh", tenloaihang);

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
        public bool phucHoiLoaiHang(DTO_LoaiHang lh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "phucHoiLoaihang";  // Add this line
                cmd.Parameters.AddWithValue("@TenLoaiHang", lh.TenLoaiHang);
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
        public int getTongLoaisanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getTongDataLoaiSanPham", _conn);
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
        public bool ThemLoaiHang(DTO_LoaiHang lh)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemLoaiHang";
                cmd.Parameters.AddWithValue("@TenLoaiHang", lh.TenLoaiHang);

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


        public bool SuaLoaiHang(DTO_LoaiHang lh)
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
                cmd.CommandText = "SuaLoaiHang";
                cmd.Parameters.AddWithValue("@MaLoaiHang", lh.MaLoaiHang);  // Add this line
                cmd.Parameters.AddWithValue("@TenLoaiHang", lh.TenLoaiHang);
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


        public bool XoaLoaiHang(string maLoaiHang)
        {

            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaLoaiHang";
                cmd.Parameters.AddWithValue("@MaLoaiHang", maLoaiHang);
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

        public DataTable TimLoaiHang(string tenLoaiHang)
        {

            //Store Procedure
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimLoaiHang";
                cmd.Parameters.AddWithValue("@tenloaihang", tenLoaiHang);
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
    }
}
