using System.Collections.Generic;
using QLNongSan.DAL;
using QLNongSan.DTO;

namespace QLNongSan.BUS
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalKhachHang = new DAL_KhachHang();

        public List<DTO_KHACHHANG> HienThiKhachHang(int sotrang, int kichthuoctrang)
        {
            return dalKhachHang.HienThiKhachHang(sotrang, kichthuoctrang);
        }

        public bool kiemTra(DTO_KHACHHANG kt)
        {
            return dalKhachHang.kiemTra(kt);
        }
        public bool kiemTraXoa(DTO_KHACHHANG kt)
        {
            return dalKhachHang.kiemTraXoa(kt);
        }
        public bool phucHoiKhachHang(DTO_KHACHHANG kh)
        {
            return dalKhachHang.phucHoiKhachHang(kh);
        }
        public int getTongKhachHang()
        {
            return dalKhachHang.getTongKhachHang();
        }
        public bool ThemKhachHang(DTO_KHACHHANG kh)
        {
            return dalKhachHang.ThemKhachHang(kh);
        }

        public bool SuaKhachHang(DTO_KHACHHANG kh)
        {
            return dalKhachHang.SuaKhachHang(kh);
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            return dalKhachHang.XoaKhachHang(maKhachHang);
        }

        public List<DTO_KHACHHANG> TimKhachHang(string tuKhoa)
        {
            return dalKhachHang.TimKhachHang(tuKhoa);
        }
    }
}
