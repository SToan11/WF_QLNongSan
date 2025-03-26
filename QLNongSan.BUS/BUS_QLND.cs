using QLNongSan.DAL;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.BUS
{
    public class BUS_QLND
    {
        DAL_QLND dAL_QLND = new DAL_QLND();
        public DataTable getNguoiDung(int sotrang, int kichthuoctrang)
        {
            return dAL_QLND.getNguoiDung(sotrang,kichthuoctrang);
        }
        public int getTongNguoiDung()
        {
            return dAL_QLND.getTongNguoiDung();
        }
        public bool themNguoiDung(DTO_QLND nd)
        {
            return dAL_QLND.themNguoiDung(nd);
        }
        public bool kiemTra(DTO_QLND kt)
        {
            return dAL_QLND.kiemTra(kt);
        }
        public bool updateNguoiDung(DTO_QLND nd)
        {
            return dAL_QLND.updateNguoiDung(nd);
        }
        public bool kiemTraXoa(DTO_QLND kt)
        {
            return dAL_QLND.kiemTraXoa(kt);
        }
        public bool phucHoiNguoiDung(DTO_QLND nd)
        {
            return dAL_QLND.phucHoiNguoiDung(nd);
        }
        public bool deleteNguoiDung(string email)
        {
            return dAL_QLND.deleteNguoiDung(email);
        }
        public DataTable searchNguoiDung(string tennd)
        {
            return dAL_QLND.searchNguoiDung(tennd);
        }
    }
}
