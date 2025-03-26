using DAL_QLSanPham;
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
    public class BUS_LoaiHang
    {

        DAL_LoaiHang dalLoaiHang = new DAL_LoaiHang();
        public bool kiemTra(string tenloaihang)
        {
            return dalLoaiHang.kiemTra(tenloaihang);
        }
        public bool kiemTraXoa(string tenloaihang)
        {
            return dalLoaiHang.kiemTraXoa(tenloaihang);    
        }
        public bool phucHoiLoaiHang(DTO_LoaiHang lh)
        {
            return dalLoaiHang.phucHoiLoaiHang(lh);
        }
        public DataTable HienThiLoaiHang(int sotrang, int kichthuoctrang)
        {
            return dalLoaiHang.HienThiLoaiHang(sotrang, kichthuoctrang);
        }
        public int getTongSoDataLoaiSanPham()
        {
            return dalLoaiHang.getTongLoaisanPham();
        }
        public bool ThemLoaiHang(DTO_LoaiHang lh)
        {
            return dalLoaiHang.ThemLoaiHang(lh);
        }

        public bool SuaLoaiHang(DTO_LoaiHang lh)
        {
            return dalLoaiHang.SuaLoaiHang(lh);
        }

        public bool XoaLoaiHang(string maLoaiHang)
        {
            return dalLoaiHang.XoaLoaiHang(maLoaiHang);
        }

        public DataTable TimLoaiHang(string tenLoaiHang)
        {
            return dalLoaiHang.TimLoaiHang(tenLoaiHang);
        }
    }
}
