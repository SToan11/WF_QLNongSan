using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DAL
{
    public class DAL_ThongKe:DBConnect
    {
        public DataTable GetThongKeHangTonKho(string search = null, int sotrang = 1, int kichthuoctrang = 5)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand("ThongKeHangTonKho", _conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@search", string.IsNullOrEmpty(search) ? (object)DBNull.Value : search);
                    cmd.Parameters.AddWithValue("@sotrang", sotrang);
                    cmd.Parameters.AddWithValue("@kichthuoctrang", kichthuoctrang);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public int GetTongSoDataThongKe(string search = null)
        {
            int totalRecords = 0;
            try
            {
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand("ThongKeHangTonKho", _conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
                    if (!string.IsNullOrEmpty(search))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@search", DBNull.Value);
                    }

                    // Provide default values for paging parameters
                    cmd.Parameters.AddWithValue("@sotrang", 1); // Default value
                    cmd.Parameters.AddWithValue("@kichthuoctrang", 10); // Default value

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Assuming the stored procedure returns the total count as the first result
                        totalRecords = reader.GetInt32(reader.GetOrdinal("Tổng Số Sản Phẩm"));
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return totalRecords;
        }

    }
}
