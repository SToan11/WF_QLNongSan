using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNongSan.DTO;

namespace QLNongSan.DAL
{
    public class DAL_QLND : DBConnect
    {
        public DataTable getNguoiDung(int sotrang, int kichthuoctrang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DSNguoiDung";
                cmd.Parameters.AddWithValue("sotrang", sotrang);
                cmd.Parameters.AddWithValue("kichthuoctrang", kichthuoctrang);
                cmd.Connection = _conn;
                DataTable dsnguoidung = new DataTable();
                dsnguoidung.Load(cmd.ExecuteReader());
                return dsnguoidung;
            }
            finally
            {
                _conn.Close();
            }
        }
        public int getTongNguoiDung()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getTongData", _conn);
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
        public bool themNguoiDung(DTO_QLND nd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemNguoiDung";
                cmd.Parameters.AddWithValue("tennd", nd.TenNguoiDung);
                cmd.Parameters.AddWithValue("gioitinh", nd.GioiTinh);
                cmd.Parameters.AddWithValue("vaitro", nd.VaiTro);
                cmd.Parameters.AddWithValue("diaChi", nd.DiaChi);
                cmd.Parameters.AddWithValue("email", nd.EmailND);
                cmd.Parameters.AddWithValue("sdt", nd.SDT);
                cmd.Parameters.AddWithValue("hinh", nd.Hinh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool kiemTra(DTO_QLND kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraNguoiDung", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tennd", kt.TenNguoiDung);
                cmd.Parameters.AddWithValue("@email", kt.EmailND);

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
        public bool kiemTraXoa(DTO_QLND kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getNguoiDungBiXoa", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tennd", kt.TenNguoiDung);
                cmd.Parameters.AddWithValue("@email", kt.EmailND);

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
        public bool updateNguoiDung(DTO_QLND nd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaNguoiDung";
                cmd.Parameters.AddWithValue("tennd", nd.TenNguoiDung);
                cmd.Parameters.AddWithValue("gioitinh", nd.GioiTinh);
                cmd.Parameters.AddWithValue("vaitro", nd.VaiTro);
                cmd.Parameters.AddWithValue("diachi", nd.DiaChi);
                cmd.Parameters.AddWithValue("email", nd.EmailND);
                cmd.Parameters.AddWithValue("sdt", nd.SDT);
                cmd.Parameters.AddWithValue("hinh", nd.Hinh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool phucHoiNguoiDung(DTO_QLND nd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "phucHoiNguoiDung";
                cmd.Parameters.AddWithValue("tennd", nd.TenNguoiDung);
                cmd.Parameters.AddWithValue("gioitinh", nd.GioiTinh);
                cmd.Parameters.AddWithValue("vaitro", nd.VaiTro);
                cmd.Parameters.AddWithValue("diachi", nd.DiaChi);
                cmd.Parameters.AddWithValue("email", nd.EmailND);
                cmd.Parameters.AddWithValue("sdt", nd.SDT);
                cmd.Parameters.AddWithValue("hinh", nd.Hinh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool deleteNguoiDung(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaNguoiDung";
                cmd.Parameters.AddWithValue("email", email);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable searchNguoiDung(string tennd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimNguoiDung";
                cmd.Parameters.AddWithValue("tennd", tennd);
                cmd.Connection = _conn;
                DataTable ds = new DataTable();
                ds.Load(cmd.ExecuteReader());
                return ds;
            }
            finally { _conn.Close(); }
        }
    }
}
