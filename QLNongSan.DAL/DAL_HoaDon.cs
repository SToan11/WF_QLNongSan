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
    public class DAL_HoaDon : DBConnect
    {
        public DataTable dssanpham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DSSP";
                DataTable dssanpham = new DataTable();
                dssanpham.Load(cmd.ExecuteReader());
                return dssanpham;
            }catch (Exception ex) {
                Console.Write("lỗi: " + ex);
            }
            finally { _conn.Close(); }
            return null;
        }
        public DataTable dsnhanvien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DSNV";
                DataTable dsnhanvien = new DataTable();
                dsnhanvien.Load(cmd.ExecuteReader());
                return dsnhanvien;
            }
            catch (Exception ex)
            {
                Console.Write("lỗi: " + ex);
            }
            finally { _conn.Close(); }
            return null;
        }
        public DataTable dskhachhang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DSKH";
                DataTable dskhachhang = new DataTable();
                dskhachhang.Load(cmd.ExecuteReader());
                return dskhachhang;
            }
            catch (Exception ex)
            {
                Console.Write("lỗi: " + ex);
            }
            finally { _conn.Close(); }
            return null;
        }

        public DataRow thongTinSanPham(string masp)
        {
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("thongTinSanPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masp", masp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Check if there is any row in the DataTable
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]; // Return the first DataRow
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (logging, rethrowing, etc.)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null; // Return null if no data is found or an exception occurs
        }
        public DataRow thongTinKhachHang(string makh)
        {
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("thongTinKhachHang", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", makh);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Check if there is any row in the DataTable
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]; // Return the first DataRow
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (logging, rethrowing, etc.)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null; // Return null if no data is found or an exception occurs
        }
        public DataRow thongTinNhanVien(string manv)
        {
            DataTable dt = new DataTable();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("thongTinNhanVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", manv);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                // Check if there is any row in the DataTable
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]; // Return the first DataRow
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (logging, rethrowing, etc.)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null; // Return null if no data is found or an exception occurs
        }
        public DataTable DanhSachHoaDon(int sotrang, int kichthuoctrang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachHoaDon";
                cmd.Parameters.AddWithValue("sotrang", sotrang);
                cmd.Parameters.AddWithValue("kichthuoctrang", kichthuoctrang);
                DataTable dshoadon = new DataTable();
                dshoadon.Load(cmd.ExecuteReader());
                return dshoadon;
            }
            finally { _conn.Close(); }
        }

        public int getTongHoaDon()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("getTongDataHoaDon", _conn);
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
        public bool taoHoaDon(string manv,DateTime ngayban, string makh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoHoaDon";
                cmd.Parameters.AddWithValue("manv", manv);
                cmd.Parameters.AddWithValue("ngayban", ngayban);
                cmd.Parameters.AddWithValue("makh", makh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool deleteHoaDon(string mahoadon)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaHoaDon";
                cmd.Parameters.AddWithValue("MaHoaDon", mahoadon);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool capNhatTongTien(string mahoadon, float tongtien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "capNhatTongTien";
                cmd.Parameters.AddWithValue("mahd", mahoadon);
                cmd.Parameters.AddWithValue("tongtien", tongtien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool suaHoaDon(string mahd, string manv, DateTime ngayban, string makh, float tongtien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "suaHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
                cmd.Parameters.AddWithValue("manv", manv);
                cmd.Parameters.AddWithValue("ngayban", ngayban);
                cmd.Parameters.AddWithValue("makh", makh);
                cmd.Parameters.AddWithValue("tongtien", tongtien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool suaSanPhamHoaDon(string mahd, string masp,string tensp, string loaisp, int soluong,string dongia, float thanhtien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "suaSanPhamHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
                cmd.Parameters.AddWithValue("masp", masp);
                cmd.Parameters.AddWithValue("tensp",tensp);
                cmd.Parameters.AddWithValue("loaisanpham", loaisp);
                cmd.Parameters.AddWithValue("soluong", soluong);
                cmd.Parameters.AddWithValue("dongia", dongia);
                cmd.Parameters.AddWithValue("thanhtien", thanhtien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool xoaSanPhamHoaDon(string mahd, string masp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoaSanPhamHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
                cmd.Parameters.AddWithValue("masp", masp);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool themSanPhamHoaDon(DTO_HoaDon hd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemSanPhamHoaDon";
                cmd.Parameters.AddWithValue("mahd", hd.MaHoaDon);
                cmd.Parameters.AddWithValue("masp", hd.MaSanPham);
                cmd.Parameters.AddWithValue("tensp", hd.TenSanPham);
                cmd.Parameters.AddWithValue("loaisanpham", hd.LoaiSanPham);
                cmd.Parameters.AddWithValue("soluong", hd.SoLuong);
                cmd.Parameters.AddWithValue("dongia", hd.DonGia);
                cmd.Parameters.AddWithValue("thanhtien", hd.ThanhTien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable DanhSachSanPhamHoaDon(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoadSanPhamHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
                DataTable dssphoadon = new DataTable();
                dssphoadon.Load(cmd.ExecuteReader());
                return dssphoadon;
            }
            finally { _conn.Close(); }
        }
        public DataTable searchSanPhamHoaDon(string mahd, string tensp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimSanPhamHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
                cmd.Parameters.AddWithValue("tensp", tensp);
                cmd.Connection = _conn;
                DataTable ds = new DataTable();
                ds.Load(cmd.ExecuteReader());
                return ds;
            }
            finally { _conn.Close(); }
        }

        public bool truSoLuong(string masp, int soluong)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "truSoLuong";
                cmd.Parameters.AddWithValue("masp", masp);
                cmd.Parameters.AddWithValue("soluong", soluong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool congSoLuong(string masp, int soluong)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "congSoLuong";
                cmd.Parameters.AddWithValue("masp", masp);
                cmd.Parameters.AddWithValue("soluong", soluong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public int LaySoLuongHienTai(string masp)
        {
            int soLuong = 0; // Default value in case of an error
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "laySoLuongHienTai";
                cmd.Parameters.AddWithValue("@masp", masp);

                // Execute the command and get the result
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out soLuong))
                {
                    return soLuong;
                }
            }
            finally
            {
                _conn.Close();
            }
            return soLuong; // Returns 0 if something went wrong
        }

        public bool kiemTra(string masp, string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("KiemTraSanPhamHoaDon", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSanPham", masp);
                cmd.Parameters.AddWithValue("@mahd", mahd);

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
    }
}
