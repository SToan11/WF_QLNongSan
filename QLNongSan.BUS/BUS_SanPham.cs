using DAL_QLSanPham;
using DTO_QLSP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();

        public DataTable getSanPham(int sotrang, int kichthuoctrang)
        {
            return dalSanPham.getSanPham(sotrang, kichthuoctrang);
        }
        public bool kiemTrasp(DTO_QLSanPham kt)
        {
            return dalSanPham.kiemTra(kt);
        }
        public bool kiemtraSPXoa(DTO_QLSanPham kt)
        {
            return dalSanPham.kiemTraSPXoa(kt);
        }
        public bool PhucHoiSanPham(DTO_QLSanPham sp)
        {
            return dalSanPham.phucHoiSanPham(sp);
        }
        public int getTongSoDataSanPham()
        {
            return dalSanPham.getTongsanPham();
        }
        public bool ThemSanPham(DTO_QLSP.DTO_QLSanPham hang)
        {
            return dalSanPham.ThemSanPham(hang);
        }
        public bool SuaSanPham(DTO_QLSP.DTO_QLSanPham hang)
        {
            return dalSanPham.SuaSanPham(hang);
        }
        public bool XoaSanPham(string maHang)
        {
            return dalSanPham.XoaSanPham(maHang);
        }
        public DataTable TimSanPham(string TenHang)
        {
            return dalSanPham.TimSanPham(TenHang);
        }
        public DataTable LoaiHang()
        {
            return dalSanPham.LoaiHang();
        }
    }
}
