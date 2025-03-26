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
    public class DAL_DANGNHAP : DBConnect
    {
        public bool NhanVienDangNhap(DTO_DANGNHAP nhanvien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("email", nhanvien.Email);
                cmd.Parameters.AddWithValue("pass", nhanvien.Matkhau);

                if(Convert.ToInt16(cmd.ExecuteScalar()) > 0) { 
                    return true;
                }
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool capNhatMK(string email, string newpass)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "capNhatMK";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("newpass", newpass);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally { _conn.Close(); }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMK";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool TaoMatKhauMoi(string email, string password)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DoiMK";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", password);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { _conn.Close(); }
            return false;
        }

        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                //Kết nối 
                _conn.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTroNV]";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Connection = _conn;

                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;

            }

            finally
            {
                _conn.Close();
            }
        }
    }
}
