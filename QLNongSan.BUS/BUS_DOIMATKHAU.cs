using System;
using System.Security.Cryptography;
using System.Text;
using QLNongSan.DAL;

namespace QLNongSan.BUS
{
    public class BUS_DOIMATKHAU
    {
        private DAL_DOIMATKHAU dalDoiMatKhau = new DAL_DOIMATKHAU();

        public bool ChangePassword(string email, string oldPassword, string newPassword)
        {
            int result = dalDoiMatKhau.ChangePassword(email, oldPassword, newPassword);

            if (result == 1)
            {
                return true; // Đổi mật khẩu thành công
            }
            else
            {
                return false; // Đổi mật khẩu thất bại
            }
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
    }
}
