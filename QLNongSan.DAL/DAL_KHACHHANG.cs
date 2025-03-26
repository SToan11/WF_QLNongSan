using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLNongSan.DTO;

namespace QLNongSan.DAL
{
    public class DAL_KhachHang : DBConnect
    {
        public bool kiemTra(DTO_KHACHHANG kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraKhachHang", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenkh", kt.TenKhachHang);
                cmd.Parameters.AddWithValue("@email", kt.Email);

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
        public bool kiemTraXoa(DTO_KHACHHANG kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getKhachHangBiXoa", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenkh", kt.TenKhachHang);
                cmd.Parameters.AddWithValue("@email", kt.Email);

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
        public bool phucHoiKhachHang(DTO_KHACHHANG kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("phuchoiKhachhang", _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", kh.MaKhachHang);
                cmd.Parameters.AddWithValue("@tenkh", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public int getTongKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getTongDataKhachHang", _conn);
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
        public List<DTO_KHACHHANG> HienThiKhachHang(int sotrang, int kichthuoctrang)
        {
            List<DTO_KHACHHANG> list = new List<DTO_KHACHHANG>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("HienThiKhachHang", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sotrang", sotrang);
                cmd.Parameters.AddWithValue("@kichthuoctrang", kichthuoctrang);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new DTO_KHACHHANG
                    {
                        MaKhachHang = reader["MaKhachHang"].ToString(),
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString()
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }
        public bool ThemKhachHang(DTO_KHACHHANG kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("ThemKhachHang", _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenkh", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool SuaKhachHang(DTO_KHACHHANG kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SuaKhachHang", _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", kh.MaKhachHang);
                cmd.Parameters.AddWithValue("@tenkh", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("XoaKhachHang", _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", maKhachHang);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public List<DTO_KHACHHANG> TimKhachHang(string tuKhoa)
        {
            List<DTO_KHACHHANG> list = new List<DTO_KHACHHANG>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("TimKhachHang", _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tukhoa", tuKhoa);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new DTO_KHACHHANG
                    {
                        MaKhachHang = reader["MaKhachHang"].ToString(),
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString()
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

    }
}
