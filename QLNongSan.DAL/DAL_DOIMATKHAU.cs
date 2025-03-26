using System;
using System.Data;
using System.Data.SqlClient;

namespace QLNongSan.DAL
{
    public class DAL_DOIMATKHAU : DBConnect
    {
        public int ChangePassword(string email, string oldPassword, string newPassword)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DoiMK", _conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@oldpass", oldPassword);
                    cmd.Parameters.AddWithValue("@newpass", newPassword);

                    SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    _conn.Open();
                    cmd.ExecuteNonQuery();
                    int result = (int)returnParameter.Value;

                    return result;
                }
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần) và xử lý ngoại lệ
                throw new Exception("Có lỗi xảy ra khi đổi mật khẩu: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }
    }
}
