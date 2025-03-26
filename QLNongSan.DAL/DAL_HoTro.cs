using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DAL
{
    public class DAL_HoTro : DBConnect
    {
        public bool HoTroKH(DTO_HoTro ht)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("hotrokh", _conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", ht.Email);
                cmd.Parameters.AddWithValue("@noidung", ht.NoiDung);
                cmd.Parameters.AddWithValue("@thoigian", ht.ThoiGian);

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
    }
}
