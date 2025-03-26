using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_KHACHHANG
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }

        public DTO_KHACHHANG(string maKhachHang, string tenKhachHang, string gioiTinh, string diaChi, string email, string sdt)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang= tenKhachHang;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.Email = email;
            this.SDT = sdt;
        }

        public DTO_KHACHHANG(string tenKhachHang, string email)
        {
            this.TenKhachHang = tenKhachHang;
            this.Email = email;
        }

        public DTO_KHACHHANG()
        { }
    }

}
