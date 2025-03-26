using QLNongSan.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.BUS
{
    public class BUS_ThongKe
    {
        DAL_ThongKe _dal = new DAL_ThongKe();

        public DataTable GetThongKeHangTonKho(string search = null, int sotrang = 1, int kichthuoctrang = 10)
        {
            return _dal.GetThongKeHangTonKho(search, sotrang, kichthuoctrang);
        }

        public int GetTongSoDataThongKe(string search = null)
        {
            return _dal.GetTongSoDataThongKe(search);
        }

    }
}
