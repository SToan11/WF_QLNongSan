using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_HoaDon
    {
        string mahoadon;
        string manhanvien;
        DateTime ngayban;
        string makhachhang;
        float tongtien;
        string masanpham;
        string tensanpham;
        string loaisanpham;
        int soluong;
        string dongia;
        float thanhtien;

        public string MaHoaDon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        public string MaNhanVien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public DateTime NgayBan
        {
            get { return ngayban; }
            set { ngayban = value; }
        }
        public string MaKhachHang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }
        public float TongTien
        {
            get { return tongtien; }
            set { tongtien = value;}
        }
        public string MaSanPham
        {
            get { return masanpham; }
            set { masanpham = value; }
        }
        public string TenSanPham
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }
        public string LoaiSanPham
        {
            get { return loaisanpham; }
            set { loaisanpham = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public float ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public DTO_HoaDon (string mahoadon, string masanpham, string tensanpham, string loaisanpham, int soluong, string dongia, float thanhtien)
        {
            this.mahoadon = mahoadon;
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.loaisanpham = loaisanpham;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }

        public DTO_HoaDon (string mahoadon, string manhanvien, DateTime ngayban, string makhachhang, float tongtien, string masanpham, string tensanpham, string loaisanpham, int soluong, string dongia, float thanhtien, string maHoaDon, string maNhanVien, DateTime ngayBan, string maKhachHang, float tongTien, string maSanPham, string tenSanPham, string loaiSanPham, int soLuong, string donGia, float thanhTien)
        {
            this.mahoadon = mahoadon;
            this.manhanvien = manhanvien;
            this.ngayban = ngayban;
            this.makhachhang = makhachhang;
            this.tongtien = tongtien;
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.loaisanpham = loaisanpham;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }
        public DTO_HoaDon() { }
    }
}
