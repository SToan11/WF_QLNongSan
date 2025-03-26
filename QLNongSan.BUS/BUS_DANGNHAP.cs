using QLNongSan.DAL;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.BUS
{
    public class BUS_DANGNHAP
    {
        DAL_DANGNHAP dalDN = new DAL_DANGNHAP();


        public bool capNhatMK(string email, string newpass)
        {
            return dalDN.capNhatMK(email, newpass);
        }
        public bool NhanVienDangNhap(DTO_DANGNHAP nhanvien)
        {
            return dalDN.NhanVienDangNhap(nhanvien);
        }

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            return dalDN.NhanVienQuenMatKhau(email);
        }

        public bool TaoMatKhau(string email, string password)
        {
            return dalDN.TaoMatKhauMoi(email, password);
        }

        public DataTable VaiTroNhanVien(string email)
        {
            return dalDN.VaiTroNhanVien(email);
        }
    }
}
